#nullable enable

using System;
using System.IO;
using System.Linq;
using GitCommands;
using GitUI.Properties;

namespace GitUI.Shells
{
    public class BashShell : ShellDescriptor
    {
        public BashShell()
        {
            Name = "bash";
            Type = ShellType.Bash;
            Icon = Images.GitForWindows;

            const string justBash = "bash.exe"; // Generic bash, should generally be in the git dir
            const string justSh = "sh.exe";     // Fallback to SH
            Executable = new Lazy<(string, string?, string?)>(
                () => new[] { justBash, justSh }
                        .Select(executableName =>
                        {
                            if (PathUtil.TryFindShellPath(executableName, out var exePath))
                            {
                                return (name: executableName, path: exePath, commandLine: $"{executableName.Quote()} --login -i");
                            }

                            return (name: executableName, path: (string?)null, commandLine: (string?)null);
                        })
                        .FirstOrDefault(executable => executable.path != null));
        }

        public override string GetTerminalStartCommand(string path)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(path);
                if (directoryInfo.Exists)
                {
                    string posixPath = "/" + directoryInfo.FullName.ToPosixPath().Remove(1, 1);
                    return $"cd {posixPath.QuoteNE()}";
                }
            }
            catch
            {
                // no-op
            }

            return string.Empty;
        }
    }
}
