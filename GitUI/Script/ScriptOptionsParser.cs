using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using GitCommands;
using GitCommands.Config;
using GitCommands.Git;
using GitCommands.UserRepositoryHistory;
using GitUI.Browsing;
using GitUI.Browsing.Dialogs;
using GitUI.UserControls.RevisionGrid;
using GitUIPluginInterfaces;
using JetBrains.Annotations;

namespace GitUI.Script
{
    internal interface IExternalMethods : ICanGetCurrentRevision,
        ICanGetQuickItemSelectorLocation,
        ICanGetSelectedRevisions,
        ICanLatestSelectedRevision
    {
    }

    internal sealed class ScriptOptionsParser : IScriptOptionsParser
    {
        public static readonly IReadOnlyList<string> Options = new[]
        {
            "sHashes",
            "sTag",
            "sBranch",
            "sLocalBranch",
            "sRemoteBranch",
            "sRemote",
            "sRemoteUrl",
            "sRemotePathFromUrl",
            "sHash",
            "sMessage",
            "sAuthor",
            "sCommitter",
            "sAuthorDate",
            "sCommitDate",
            "cTag",
            "cBranch",
            "cLocalBranch",
            "cRemoteBranch",
            "cHash",
            "cMessage",
            "cAuthor",
            "cCommitter",
            "cAuthorDate",
            "cCommitDate",
            "cDefaultRemote",
            "cDefaultRemoteUrl",
            "cDefaultRemotePathFromUrl",
            "UserInput",
            "UserFiles",
            "WorkingDir"
        };
        public static readonly IReadOnlyList<string> Options = new[]
        {
            "sHashes",
            "sTag",
            "sBranch",
            "sLocalBranch",
            "sRemoteBranch",
            "sRemoteBranchName",
            "sRemote",
            "sRemoteUrl",
            "sRemotePathFromUrl",
            "sHash",
            "sMessage",
            "sAuthor",
            "sCommitter",
            "sAuthorDate",
            "sCommitDate",
            "cTag",
            "cBranch",
            "cLocalBranch",
            "cRemoteBranch",
            "cRemoteBranchName",
            "cHash",
            "cMessage",
            "cAuthor",
            "cCommitter",
            "cAuthorDate",
            "cCommitDate",
            "cDefaultRemote",
            "cDefaultRemoteUrl",
            "cDefaultRemotePathFromUrl",
            "RepoName",
            "UserInput",
            "UserFiles",
            "WorkingDir"
        };
        private readonly ISimpleDialog _simpleDialog;
        private readonly ICanGetCurrentRevision _canGetCurrentRevision;
        private readonly ICanGetQuickItemSelectorLocation _canGetQuickItemSelectorLocation;
        private readonly ICanGetSelectedRevisions _canGetSelectedRevisions;
        private readonly ICanLatestSelectedRevision _canLatestSelectedRevision;

        public ScriptOptionsParser(
            ISimpleDialog simpleDialog,
            ICanGetCurrentRevision canGetCurrentRevision = null,
            ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation = null,
            ICanGetSelectedRevisions canGetSelectedRevisions = null,
            ICanLatestSelectedRevision canLatestSelectedRevision = null)
        {
            _simpleDialog = simpleDialog ?? throw new ArgumentNullException(nameof(simpleDialog));
            _canGetCurrentRevision = canGetCurrentRevision;
            _canGetQuickItemSelectorLocation = canGetQuickItemSelectorLocation;
            _canGetSelectedRevisions = canGetSelectedRevisions;
            _canLatestSelectedRevision = canLatestSelectedRevision;
        }

        public ScriptOptionsParser(ISimpleDialog simpleDialog, IExternalMethods externalMethods = null)
            : this(simpleDialog, externalMethods, externalMethods, externalMethods, externalMethods)
        {
        }

        public ScriptOptionsParser(ISimpleDialog simpleDialog)
            : this(simpleDialog, null)
        {
        }

        public (string argument, bool abort) Parse(string argument, IGitModule module)
        {
            GitRevision selectedRevision = null;
            GitRevision currentRevision = null;

            IReadOnlyList<GitRevision> allSelectedRevisions = Array.Empty<GitRevision>();
            var selectedLocalBranches = new List<IGitRef>();
            var selectedRemoteBranches = new List<IGitRef>();
            var selectedRemotes = new List<string>();
            var selectedBranches = new List<IGitRef>();
            var selectedTags = new List<IGitRef>();
            var currentLocalBranches = new List<IGitRef>();
            var currentRemoteBranches = new List<IGitRef>();
            var currentRemote = string.Empty;
            var currentBranches = new List<IGitRef>();
            var currentTags = new List<IGitRef>();

            foreach (var option in ScriptOptions.All)
            {
                if (string.IsNullOrEmpty(argument))
                {
                    continue;
                }

                string regularOption = CreateOption(option, false);
                string quotedOption = CreateOption(option, true);

                if (!argument.Contains(regularOption) && (!argument.Contains(quotedOption)))
                {
                    continue;
                }

                if (option.StartsWith("c") && currentRevision == null)
                {
                    currentRevision = GetCurrentRevision(module, currentTags, currentLocalBranches, currentRemoteBranches, currentBranches, currentRevision);

                    if (currentLocalBranches.Count == 1)
                    {
                        currentRemote = module.GetSetting(string.Format(SettingKeyString.BranchRemote, currentLocalBranches[0].Name));
                    }
                    else
                    {
                        currentRemote = module.GetCurrentRemote();
                        if (string.IsNullOrEmpty(currentRemote))
                        {
                            currentRemote = module.GetSetting(string.Format(SettingKeyString.BranchRemote,
                                AskToSpecify(currentLocalBranches, _canGetQuickItemSelectorLocation)));
                        }
                    }
                }
                else if (option.StartsWith("s") && selectedRevision == null && _canGetSelectedRevisions != null)
                {
                    allSelectedRevisions = _canGetSelectedRevisions.GetSelectedRevisions();
                    selectedRevision = CalculateSelectedRevision(selectedRemoteBranches, selectedRemotes, selectedLocalBranches, selectedBranches, selectedTags);
                }

                argument = ParseScriptArguments(argument, option, _simpleDialog, module, allSelectedRevisions, selectedTags, selectedBranches, selectedLocalBranches, selectedRemoteBranches, selectedRemotes, selectedRevision, currentTags, currentBranches, currentLocalBranches, currentRemoteBranches, currentRevision, currentRemote, _canGetQuickItemSelectorLocation);
                if (argument == null)
                {
                    return (argument: null, abort: true);
                }
            }

            return (argument, abort: false);
        }

        private static string CreateOption(string option, bool quoted)
        {
            var result = "{" + option + "}";

            if (quoted)
            {
                result = "{" + result + "}";
            }

            return result;
        }

        private static string AskToSpecify(IEnumerable<IGitRef> options, ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation)
        {
            using (var f = new FormQuickGitRefSelector())
            {
                f.Location = GetQuickItemSelectorLocation(canGetQuickItemSelectorLocation);
                f.Init(FormQuickGitRefSelector.Action.Select, options.ToList());
                f.ShowDialog();
                return f.SelectedRef.Name;
            }
        }

        private static string AskToSpecify(IEnumerable<string> options, ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation)
        {
            using (var f = new FormQuickStringSelector())
            {
                f.Location = GetQuickItemSelectorLocation(canGetQuickItemSelectorLocation);
                f.Init(options.ToList());
                f.ShowDialog();
                return f.SelectedString;
            }
        }

        private static Point GetQuickItemSelectorLocation(ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation)
        {
            return canGetQuickItemSelectorLocation?.GetQuickItemSelectorLocation() ?? new Point();
        }

        private GitRevision CalculateSelectedRevision(List<IGitRef> selectedRemoteBranches,
            List<string> selectedRemotes, List<IGitRef> selectedLocalBranches,
            List<IGitRef> selectedBranches, List<IGitRef> selectedTags)
        {
            GitRevision selectedRevision = _canLatestSelectedRevision.LatestSelectedRevision;
            foreach (var head in selectedRevision.Refs)
            {
                if (head.IsTag)
                {
                    selectedTags.Add(head);
                }
                else if (head.IsHead || head.IsRemote)
                {
                    selectedBranches.Add(head);
                    if (head.IsRemote)
                    {
                        selectedRemoteBranches.Add(head);
                        if (!selectedRemotes.Contains(head.Remote))
                        {
                            selectedRemotes.Add(head.Remote);
                        }
                    }
                    else
                    {
                        selectedLocalBranches.Add(head);
                    }
                }
            }

            return selectedRevision;
        }

        [CanBeNull]
        private GitRevision GetCurrentRevision(
            IGitModule module, List<IGitRef> currentTags, List<IGitRef> currentLocalBranches,
            List<IGitRef> currentRemoteBranches, List<IGitRef> currentBranches, [CanBeNull] GitRevision currentRevision)
        {
            if (currentRevision == null)
            {
                IEnumerable<IGitRef> refs;

                if (_canGetCurrentRevision == null)
                {
                    var currentRevisionGuid = module.GetCurrentCheckout();
                    currentRevision = new GitRevision(currentRevisionGuid);
                    refs = module.GetRefs(true, true).Where(gitRef => gitRef.ObjectId == currentRevisionGuid).ToList();
                }
                else
                {
                    currentRevision = _canGetCurrentRevision.GetCurrentRevision();
                    refs = currentRevision.Refs;
                }

                foreach (var gitRef in refs)
                {
                    if (gitRef.IsTag)
                    {
                        currentTags.Add(gitRef);
                    }
                    else if (gitRef.IsHead || gitRef.IsRemote)
                    {
                        currentBranches.Add(gitRef);
                        if (gitRef.IsRemote)
                        {
                            currentRemoteBranches.Add(gitRef);
                        }
                        else
                        {
                            currentLocalBranches.Add(gitRef);
                        }
                    }
                }
            }

            return currentRevision;
        }

        private static string GetRemotePath(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
                Uri.TryCreate("ssh://" + url.Replace(":", "/"), UriKind.Absolute, out uri))
            {
                return uri.LocalPath.SubstringUntilLast('.');
            }

            return string.Empty;
        }

        private static string ParseScriptArguments(string argument, string option, ISimpleDialog simpleDialog, IGitModule module, IReadOnlyList<GitRevision> allSelectedRevisions, in IList<IGitRef> selectedTags, in IList<IGitRef> selectedBranches, in IList<IGitRef> selectedLocalBranches, in IList<IGitRef> selectedRemoteBranches, in IList<string> selectedRemotes, GitRevision selectedRevision, in IList<IGitRef> currentTags, in IList<IGitRef> currentBranches, in IList<IGitRef> currentLocalBranches, in IList<IGitRef> currentRemoteBranches, GitRevision currentRevision, string currentRemote, ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation)
        {
            string newString = null;
            string remote;
            string url;
            switch (option)
            {
                case ScriptOptions.SHashes:
                    newString = string.Join(" ", allSelectedRevisions.Select(revision => revision.Guid).ToArray());
                    break;

                case ScriptOptions.STag:
                    if (selectedTags.Count == 1)
                    {
                        newString = selectedTags[0].Name;
                    }
                    else if (selectedTags.Count != 0)
                    {
                        newString = AskToSpecify(selectedTags, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(selectedTags);
                    if (selectedTags.Count == 1)
                    {
                        newString = selectedTags[0].Name;
                    }
                    else if (selectedTags.Count != 0)
                    {
                        newString = AskToSpecify(selectedTags, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.SBranch:
                    if (selectedBranches.Count == 1)
                    {
                        newString = selectedBranches[0].Name;
                    }
                    else if (selectedBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(selectedBranches);
                    if (selectedBranches.Count == 1)
                    {
                        newString = selectedBranches[0].Name;
                    }
                    else if (selectedBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.SLocalBranch:
                    if (selectedLocalBranches.Count == 1)
                    {
                        newString = selectedLocalBranches[0].Name;
                    }
                    else if (selectedLocalBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedLocalBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(selectedLocalBranches);
                    if (selectedLocalBranches.Count == 1)
                    {
                        newString = selectedLocalBranches[0].Name;
                    }
                    else if (selectedLocalBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedLocalBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.SRemoteBranch:
                    if (selectedRemoteBranches.Count == 1)
                    {
                        newString = selectedRemoteBranches[0].Name;
                    }
                    else if (selectedRemoteBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedRemoteBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    newString = SelectOneRef(selectedRemoteBranches);
                    if (selectedRemoteBranches.Count == 1)
                    {
                        newString = selectedRemoteBranches[0].Name;
                    }
                    else if (selectedRemoteBranches.Count != 0)
                    {
                        newString = AskToSpecify(selectedRemoteBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    break;

                case "sRemoteBranchName":
                    newString = StripRemoteName(SelectOneRef(selectedRemoteBranches));
                    break;

                case ScriptOptions.SRemote:
                    if (selectedRemotes.Count == 0)
                    {
                        newString = "";
                    }
                    else
                    {
                        newString = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, revisionGrid);
                    }

                    newString = SelectOneString(selectedRemotes);
                    if (selectedRemotes.Count == 0)
                    {
                        newString = string.Empty;
                    }
                    else
                    {
                        newString = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, canGetQuickItemSelectorLocation);
                    }

                    break;

                case ScriptOptions.SRemoteUrl:
                    newString = SelectOneString(selectedRemotes);
                    if (!string.IsNullOrEmpty(newString))
                    {
                        newString = "";
                    }
                    else
                    {
                        remote = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, revisionGrid);
                        remote = newString;
                        newString = string.Empty;
                    }
                    else
                    {
                        remote = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, canGetQuickItemSelectorLocation);
                        newString = module.GetSetting(string.Format(SettingKeyString.RemoteUrl, remote));
                    }

                    break;

                case ScriptOptions.SRemotePathFromUrl:
                    newString = SelectOneString(selectedRemotes);
                    if (!string.IsNullOrEmpty(newString))
                    {
                        newString = "";
                    }
                    else
                    {
                        remote = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, revisionGrid);
                        remote = newString;
                        newString = string.Empty;
                    }
                    else
                    {
                        remote = selectedRemotes.Count == 1
                            ? selectedRemotes[0]
                            : AskToSpecify(selectedRemotes, canGetQuickItemSelectorLocation);
                        newString = module.GetSetting(string.Format(SettingKeyString.RemoteUrl, remote));
                        url = module.GetSetting(string.Format(SettingKeyString.RemoteUrl, remote));
                        newString = GetRemotePath(url);
                    }

                    break;

                case ScriptOptions.SHash:
                    newString = selectedRevision.Guid;
                    break;

                case ScriptOptions.SMessage:
                    newString = selectedRevision.Subject;
                    break;

                case ScriptOptions.SAuthor:
                    newString = selectedRevision.Author;
                    break;

                case ScriptOptions.SCommitter:
                    newString = selectedRevision.Committer;
                    break;

                case ScriptOptions.SAuthorDate:
                    newString = selectedRevision.AuthorDate.ToString();
                    break;

                case ScriptOptions.SCommitDate:
                    newString = selectedRevision.CommitDate.ToString();
                    break;

                case ScriptOptions.CTag:
                    if (currentTags.Count == 1)
                    {
                        newString = currentTags[0].Name;
                    }
                    else if (currentTags.Count != 0)
                    {
                        newString = AskToSpecify(currentTags, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(currentTags);
                    if (currentTags.Count == 1)
                    {
                        newString = currentTags[0].Name;
                    }
                    else if (currentTags.Count != 0)
                    {
                        newString = AskToSpecify(currentTags, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.CBranch:
                    if (currentBranches.Count == 1)
                    {
                        newString = currentBranches[0].Name;
                    }
                    else if (currentBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(currentBranches);
                    if (currentBranches.Count == 1)
                    {
                        newString = currentBranches[0].Name;
                    }
                    else if (currentBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.CLocalBranch:
                    if (currentLocalBranches.Count == 1)
                    {
                        newString = currentLocalBranches[0].Name;
                    }
                    else if (currentLocalBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentLocalBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }

                    newString = SelectOneRef(currentLocalBranches);
                    if (currentLocalBranches.Count == 1)
                    {
                        newString = currentLocalBranches[0].Name;
                    }
                    else if (currentLocalBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentLocalBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                    break;

                case ScriptOptions.CRemoteBranch:
                    if (currentRemoteBranches.Count == 1)
                    {
                        newString = currentRemoteBranches[0].Name;
                    }
                    else if (currentRemoteBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentRemoteBranches, canGetQuickItemSelectorLocation);
                    }
                    else
                    {
                        newString = "";
                    }
                    newString = SelectOneRef(currentRemoteBranches);
                    break;
                    if (currentRemoteBranches.Count == 1)
                    {
                        newString = currentRemoteBranches[0].Name;
                    }
                    else if (currentRemoteBranches.Count != 0)
                    {
                        newString = AskToSpecify(currentRemoteBranches, revisionGrid);
                    }
                    else
                    {
                        newString = string.Empty;
                    }

                case "cRemoteBranchName":
                    newString = StripRemoteName(SelectOneRef(currentRemoteBranches));
                    break;

                case ScriptOptions.CHash:
                    newString = currentRevision.Guid;
                    break;

                case ScriptOptions.CMessage:
                    newString = currentRevision.Subject;
                    break;

                case ScriptOptions.CAuthor:
                    newString = currentRevision.Author;
                    break;

                case ScriptOptions.CCommitter:
                    newString = currentRevision.Committer;
                    break;

                case ScriptOptions.CAuthorDate:
                    newString = currentRevision.AuthorDate.ToString();
                    break;

                case ScriptOptions.CCommitDate:
                    newString = currentRevision.CommitDate.ToString();
                    break;

                case ScriptOptions.CDefaultRemote:
                    if (string.IsNullOrEmpty(currentRemote))
                    {
                        newString = string.Empty;
                    }
                    else
                    {
                        newString = currentRemote;
                    }

                    break;

                case ScriptOptions.CDefaultRemoteUrl:
                    if (string.IsNullOrEmpty(currentRemote))
                    {
                        newString = string.Empty;
                    }
                    else
                    {
                        newString = module.GetSetting(string.Format(SettingKeyString.RemoteUrl, currentRemote));
                    }

                    break;

                case ScriptOptions.CDefaultRemotePathFromUrl:
                    if (string.IsNullOrEmpty(currentRemote))
                    {
                        newString = string.Empty;
                    }
                    else
                    {
                        url = module.GetSetting(string.Format(SettingKeyString.RemoteUrl, currentRemote));
                        newString = GetRemotePath(url);
                    }

                    break;

                case "RepoName":
                    newString = module == null ? string.Empty : new RepositoryDescriptionProvider(new GitDirectoryResolver()).Get(module.WorkingDir);
                    break;

                case ScriptOptions.UserInput:
                    using (var prompt = new SimplePrompt())
                    {
                        prompt.ShowDialog();
                        newString = prompt.UserInput;
                    }

                    break;

                case ScriptOptions.UserFiles:
                    var filePath = simpleDialog
                        .ShowFilePromptDialog();

                    if (filePath == null)
                    {
                        // abort parsing as the user chose to abort
                        return null;
                    }

                    newString = filePath;
                    break;

                case ScriptOptions.WorkingDir:
                    newString = module?.WorkingDir ?? string.Empty;
                    break;
            }

            if (newString != null)
            {
                string newStringQuoted = Regex.Replace(newString, @"(?<!\\)""", "\\\"");
                newStringQuoted = "\"" + newStringQuoted;
                if (newStringQuoted.EndsWith("\\"))
                {
                    newStringQuoted = newStringQuoted + "\\";
                }

                newStringQuoted = newStringQuoted + "\"";

                argument = argument.Replace(CreateOption(option, true), newStringQuoted);
                argument = argument.Replace(CreateOption(option, false), newString);
            }

            return argument;

            string SelectOneRef(IList<IGitRef> refs) => ScriptOptionsParser.SelectOne(refs, revisionGrid);
            string SelectOneString(IList<string> strings) => ScriptOptionsParser.SelectOne(strings, revisionGrid);
        }

        private static string SelectOne(IList<IGitRef> refs, RevisionGridControl revisionGrid)
        {
            switch (refs.Count)
            {
                case 0: return string.Empty;
                case 1: return refs[0].Name;
                default: return AskToSpecify(refs, revisionGrid);
            }
        }

        private static string SelectOne(IList<string> strings, RevisionGridControl revisionGrid)
        {
            switch (strings.Count)
            {
                case 0: return string.Empty;
                case 1: return strings[0];
                default: return AskToSpecify(strings, revisionGrid);
            }
        }

        private static string StripRemoteName(string remoteBranchName)
        {
            if (string.IsNullOrEmpty(remoteBranchName))
            {
                return string.Empty;
            }

            int firstSlashIndex = remoteBranchName.IndexOf('/');
            if (firstSlashIndex >= 0)
            {
                return remoteBranchName.Substring(firstSlashIndex + 1);
            }

            return remoteBranchName;
        }

        internal static TestAccessor GetTestAccessor() => new TestAccessor();

        public readonly struct TestAccessor
        {
            public string ParseScriptArguments(string argument, string option, ISimpleDialog simpleDialog, IGitModule module, IReadOnlyList<GitRevision> allSelectedRevisions, List<IGitRef> selectedTags, List<IGitRef> selectedBranches, List<IGitRef> selectedLocalBranches, List<IGitRef> selectedRemoteBranches, List<string> selectedRemotes, GitRevision selectedRevision, List<IGitRef> currentTags, List<IGitRef> currentBranches, List<IGitRef> currentLocalBranches, List<IGitRef> currentRemoteBranches, GitRevision currentRevision, string currentRemote, ICanGetQuickItemSelectorLocation canGetQuickItemSelectorLocation) =>
                ScriptOptionsParser.ParseScriptArguments(argument, option, simpleDialog, module, allSelectedRevisions, selectedTags, selectedBranches, selectedLocalBranches, selectedRemoteBranches, selectedRemotes, selectedRevision, currentTags, currentBranches, currentLocalBranches, currentRemoteBranches, currentRevision, currentRemote, canGetQuickItemSelectorLocation);
        }
    }
}