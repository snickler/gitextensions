#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GitCommands.Config;
using GitExtUtils;
using GitUIPluginInterfaces;

namespace GitCommands.DiffMergeTools
{
    public class CustomDiffMergeToolProvider
    {
        private readonly Func<IGitModule> _getModule;
        private readonly object _syncRoot = new object();
        private static string? _currentWorkingDirectory;
        private static List<string>? _currentWorkingDirectoryDiffTools;
        private static List<string>? _currentWorkingDirectoryMergeTools;

        public CustomDiffMergeToolProvider(Func<IGitModule> getModule)
        {
            _getModule = getModule;
        }

        /// <summary>
        /// Get a list of diff/merge tools known by Git.
        /// </summary>
        /// <param name="isDiff">diff or merge.</param>
        /// <returns>the list.</returns>
        public async Task<IReadOnlyList<string>> LoadAsync(bool isDiff)
        {
            IGitModule module = GetModule();
            lock (_syncRoot)
            {
                bool needsReload = !string.Equals(_currentWorkingDirectory, module.WorkingDir, StringComparison.Ordinal)
                    || (isDiff && _currentWorkingDirectoryDiffTools is null)
                    || (_currentWorkingDirectoryMergeTools is null);

                if (!needsReload)
                {
                    return isDiff ? _currentWorkingDirectoryDiffTools! : _currentWorkingDirectoryMergeTools!;
                }
                else
                {
                    _currentWorkingDirectory = module.WorkingDir;
                    _currentWorkingDirectoryDiffTools = null;
                    _currentWorkingDirectoryMergeTools = null;
                }
            }

            // Note that --gui has no effect here
            var args = new GitArgumentBuilder(isDiff ? "difftool" : "mergetool") { "--tool-help" };
            string output = await GetModule().GitExecutable.GetOutputAsync(args);

            var toolKey = isDiff ? SettingKeyString.DiffToolKey : SettingKeyString.MergeToolKey;
            var defaultTool = module.GetEffectiveSetting(toolKey);

            List<string> customTools = ParseCustomDiffMergeTools(output, defaultTool);
            if (isDiff)
            {
                Debug.Assert(_currentWorkingDirectoryDiffTools is null, "A race condition, must be investigated");
                _currentWorkingDirectoryDiffTools = customTools;
            }
            else
            {
                Debug.Assert(_currentWorkingDirectoryMergeTools is null, "A race condition, must be investigated");
                _currentWorkingDirectoryMergeTools = customTools;
            }

            return customTools;
        }

        private IGitModule GetModule()
        {
            IGitModule? module = _getModule();
            if (module is null)
            {
                throw new ArgumentException($"Require a valid instance of {nameof(IGitModule)}");
            }

            return module;
        }

        /// <summary>
        /// Parse the output from 'git difftool --tool-help'.
        /// </summary>
        /// <param name="output">The output string.</param>
        /// <returns>list with tool names.</returns>
        private static List<string> ParseCustomDiffMergeTools(string output, string? defaultTool)
        {
            List<string> tools = new();

            // Simple parsing of the textual output opposite to porcelain format
            // https://github.com/git/git/blob/main/git-mergetool--lib.sh#L298
            // An alternative is to parse "git config --get-regexp difftool'\..*\.cmd'" and see show_tool_names()

            // The sections to parse in the text has a 'header', then break parsing at first non match

            foreach (string lline in output.Split('\n'))
            {
                if (lline == "The following tools are valid, but not currently available:")
                {
                    // No more usable tools
                    break;
                }

                if (!lline.StartsWith("\t\t"))
                {
                    continue;
                }

                // two tabs, then toolname, cmd (if split in 3) in second
                // cmd is unreliable for diff and not needed but could be used for mergetool special handling
                string[] delimit = { " ", ".cmd" };
                string[] tool = lline.Substring(2).Split(delimit, 2, StringSplitOptions.None);
                if (tool.Length == 0)
                {
                    continue;
                }

                // Ignore (known) tools that must run in a terminal
                string[] ignoredTools = { "vimdiff", "vimdiff2", "vimdiff3" };
                var toolName = tool[0];
                if (!string.IsNullOrWhiteSpace(toolName) && !tools.Contains(toolName) && !ignoredTools.Contains(toolName))
                {
                    tools.Add(toolName);
                }
            }

            // Return the default tool first
            return tools.OrderBy(tool => tool != defaultTool).ThenBy(tool => tool).ToList();
        }
    }
}
