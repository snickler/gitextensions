using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using GitCommands.Logging;
using GitCommands.Repository;
using GitCommands.Settings;
using Microsoft.Win32;

namespace GitCommands
{
    public interface IAppSettings
    {
        RepoDistSettings SettingsContainer { get; }
        bool AutoNormaliseBranchName { get; set; }

        string AutoNormaliseSymbol
        {
            // when persisted "" is treated as null, so use "+" instead
            get;
            set;
        }

        int BranchDropDownMinWidth { get; }
        int BranchDropDownMaxWidth { get; }

        bool RememberAmendCommitState { get; set; }

        void UsingContainer(RepoDistSettings settingsContainer, Action action);

        bool CheckSettings { get; set; }
        string CascadeShellMenuItems { get; set; }
        string SshPath { get; set; }
        bool AlwaysShowAllCommands { get; set; }

        bool ShowCurrentBranchInVisualStudio
        {
            //This setting MUST be set to false by default, otherwise it will not work in Visual Studio without
            //other changes in the Visual Studio plugin itself.
            get;
            set;
        }

        BoolNullableSetting ShowConEmuTab { get; }
        StringSetting ConEmuStyle { get; }
        StringSetting ConEmuTerminal { get; }
        StringSetting ConEmuFontSize { get; }
        BoolNullableSetting ShowRevisionInfoNextToRevisionGrid { get; }

        string GitCommandValue { get; set; }
        string GitCommand { get; }
        int UserMenuLocationX { get; set; }
        int UserMenuLocationY { get; set; }
        bool StashKeepIndex { get; set; }
        bool StashConfirmDropShow { get; set; }
        bool ApplyPatchIgnoreWhitespace { get; set; }
        bool UsePatienceDiffAlgorithm { get; set; }
        bool ShowErrorsWhenStagingFiles { get; set; }
        bool AddNewlineToCommitMessageWhenMissing { get; set; }
        string LastCommitMessage { get; set; }
        int CommitDialogNumberOfPreviousMessages { get; set; }
        bool ShowCommitAndPush { get; set; }
        bool ShowResetUnstagedChanges { get; set; }
        bool ShowResetAllChanges { get; set; }
        bool ProvideAutocompletion { get; set; }
        string TruncatePathMethod { get; set; }
        bool ShowGitStatusInBrowseToolbar { get; set; }
        bool CommitInfoShowContainedInBranches { get; }
        bool CommitInfoShowContainedInBranchesLocal { get; set; }
        bool CheckForUncommittedChangesInCheckoutBranch { get; set; }
        bool AlwaysShowCheckoutBranchDlg { get; set; }
        bool CommitInfoShowContainedInBranchesRemote { get; set; }
        bool CommitInfoShowContainedInBranchesRemoteIfNoLocal { get; set; }
        bool CommitInfoShowContainedInTags { get; set; }
        string GravatarCachePath { get; }
        string Translation { get; set; }
        string CurrentTranslation { get; set; }
        string CurrentLanguageCode { get; }
        CultureInfo CurrentCultureInfo { get; }
        bool UserProfileHomeDir { get; set; }
        string CustomHomeDir { get; set; }
        bool EnableAutoScale { get; set; }
        string IconColor { get; set; }
        string IconStyle { get; set; }
        int AuthorImageSize { get; set; }
        int AuthorImageCacheDays { get; set; }
        bool ShowAuthorGravatar { get; set; }
        bool CloseCommitDialogAfterCommit { get; set; }
        bool CloseCommitDialogAfterLastCommit { get; set; }
        bool RefreshCommitDialogOnFormFocus { get; set; }
        bool StageInSuperprojectAfterCommit { get; set; }
        bool PlaySpecialStartupSound { get; set; }
        bool FollowRenamesInFileHistory { get; set; }
        bool FollowRenamesInFileHistoryExactOnly { get; set; }
        bool FullHistoryInFileHistory { get; set; }
        bool LoadFileHistoryOnShow { get; set; }
        bool LoadBlameOnShow { get; set; }
        bool OpenSubmoduleDiffInSeparateWindow { get; set; }
        bool RevisionGraphShowWorkingDirChanges { get; set; }
        bool RevisionGraphDrawNonRelativesGray { get; set; }
        bool RevisionGraphDrawNonRelativesTextGray { get; set; }
        IDictionary<string, Encoding> AvailableEncodings { get; }
        PullAction FormPullAction { get; set; }
        bool SetNextPullActionAsDefault { get; set; }
        string SmtpServer { get; set; }
        int SmtpPort { get; set; }
        bool SmtpUseSsl { get; set; }
        bool AutoStash { get; set; }
        bool RebaseAutoStash { get; set; }
        LocalChangesAction CheckoutBranchAction { get; set; }
        bool UseDefaultCheckoutBranchAction { get; set; }
        bool DontShowHelpImages { get; set; }
        bool GetHelpIsExpanded(string helpId, bool defaultValue);
        void SetHelpIsExpanded(string helpId, bool value);
        bool AlwaysShowAdvOpt { get; set; }
        bool DontConfirmAmend { get; set; }
        bool DontConfirmCommitIfNoBranch { get; set; }
        bool? AutoPopStashAfterPull { get; set; }
        bool? AutoPopStashAfterCheckoutBranch { get; set; }
        PullAction? AutoPullOnPushRejectedAction { get; set; }
        bool DontConfirmPushNewBranch { get; set; }
        bool DontConfirmAddTrackingRef { get; set; }
        bool DontConfirmCommitAfterConflictsResolved { get; set; }
        bool DontConfirmSecondAbortConfirmation { get; set; }
        bool DontConfirmResolveConflicts { get; set; }
        bool IncludeUntrackedFilesInAutoStash { get; set; }
        bool IncludeUntrackedFilesInManualStash { get; set; }
        bool OrderRevisionByDate { get; set; }
        bool ShowRemoteBranches { get; set; }
        bool ShowSuperprojectTags { get; set; }
        bool ShowSuperprojectBranches { get; set; }
        bool ShowSuperprojectRemoteBranches { get; set; }
        bool? UpdateSubmodulesOnCheckout { get; set; }
        string Dictionary { get; set; }
        bool ShowGitCommandLine { get; set; }
        bool ShowStashCount { get; set; }
        bool RelativeDate { get; set; }
        bool UseFastChecks { get; set; }
        bool ShowGitNotes { get; set; }
        bool ShowIndicatorForMultilineMessage { get; set; }
        bool ShowAnnotatedTagsMessages { get; set; }
        bool ShowMergeCommits { get; set; }
        bool ShowTags { get; set; }
        bool ShowIds { get; set; }
        int RevisionGraphLayout { get; set; }
        bool ShowAuthorDate { get; set; }
        bool CloseProcessDialog { get; set; }
        bool ShowCurrentBranchOnly { get; set; }
        bool ShowSimplifyByDecoration { get; set; }
        bool BranchFilterEnabled { get; set; }
        bool ShowFirstParent { get; set; }
        int CommitDialogDeviceDpi { get; set; }
        int CommitDialogSplitter { get; set; }
        int CommitDialogRightSplitter { get; set; }
        bool CommitDialogSelectionFilter { get; set; }
        string DefaultCloneDestinationPath { get; set; }
        int RevisionGridQuickSearchTimeout { get; set; }
        string GravatarFallbackService { get; set; }

        /// <summary>Gets or sets the path to the git application executable.</summary>
        string GitBinDir { get; set; }

        int MaxRevisionGraphCommits { get; set; }
        bool ShowDiffForAllParents { get; set; }
        string RecentWorkingDir { get; set; }
        bool StartWithRecentWorkingDir { get; set; }
        CommandLogger GitLog { get; }
        string Plink { get; set; }
        string Puttygen { get; set; }

        /// <summary>Gets the path to Pageant (SSH auth agent).</summary>
        string Pageant { get; set; }

        bool AutoStartPageant { get; set; }
        bool MarkIllFormedLinesInCommitMsg { get; set; }
        Color OtherTagColor { get; set; }
        Color TagColor { get; set; }
        Color GraphColor { get; set; }
        Color BranchColor { get; set; }
        Color RemoteBranchColor { get; set; }
        Color DiffSectionColor { get; set; }
        Color DiffRemovedColor { get; set; }
        Color DiffRemovedExtraColor { get; set; }
        Color DiffAddedColor { get; set; }
        Color DiffAddedExtraColor { get; set; }
        Color AuthoredRevisionsColor { get; set; }
        Font DiffFont { get; set; }
        Font CommitFont { get; set; }
        Font Font { get; set; }
        bool MulticolorBranches { get; set; }
        bool StripedBranchChange { get; set; }
        bool BranchBorders { get; set; }
        bool HighlightAuthoredRevisions { get; set; }
        string LastFormatPatchDir { get; set; }
        bool IgnoreWhitespaceChanges { get; set; }
        bool RememberIgnoreWhiteSpacePreference { get; set; }
        bool ShowNonPrintingChars { get; set; }
        bool RememberShowNonPrintingCharsPreference { get; set; }
        bool ShowEntireFile { get; set; }
        bool RememberShowEntireFilePreference { get; set; }
        int NumberOfContextLines { get; set; }
        bool RememberNumberOfContextLines { get; set; }
        bool DashboardShowCurrentBranch { get; set; }
        string ownScripts { get; set; }
        int RecursiveSubmodules { get; set; }
        string ShorteningRecentRepoPathStrategy { get; set; }
        int MaxMostRecentRepositories { get; set; }
        int RecentReposComboMinWidth { get; set; }
        string RemoteRepositoryHistory { get; set; }
        string Repositories { get; set; }
        string RepositoryHistory { get; set; }
        int RepositoryHistorySize { get; set; }
        string SerializedHotkeys { get; set; }
        bool SortMostRecentRepos { get; set; }
        bool SortLessRecentRepos { get; set; }
        bool DontCommitMerge { get; set; }
        int CommitValidationMaxCntCharsFirstLine { get; set; }
        int CommitValidationMaxCntCharsPerLine { get; set; }
        bool CommitValidationSecondLineMustBeEmpty { get; set; }
        bool CommitValidationIndentAfterFirstLine { get; set; }
        bool CommitValidationAutoWrap { get; set; }
        string CommitValidationRegEx { get; set; }
        string CommitTemplates { get; set; }
        bool CreateLocalBranchForRemote { get; set; }
        bool UseFormCommitMessage { get; set; }
        bool CommitAutomaticallyAfterCherryPick { get; set; }
        bool AddCommitReferenceToCherryPick { get; set; }
        DateTime LastUpdateCheck { get; set; }
        bool CheckForReleaseCandidates { get; set; }
        bool OmitUninterestingDiff { get; set; }
        bool UseConsoleEmulatorForCommands { get; set; }
        void SaveSettings();
        void LoadSettings();
        string PrefixedName(string prefix, string name);
    }

    public sealed class AppSettingsImplementations : IAppSettings
    {
        public readonly Lazy<string> ApplicationDataPath;
        //public static string SettingsFilePath { get { return Path.Combine(ApplicationDataPath.Value, SettingsFileName); } }

        //private  RepoDistSettings _SettingsContainer;
        //public  RepoDistSettings SettingsContainer { get { return _SettingsContainer; } }
        private readonly SettingsPath DetailedSettingsPath;// = new AppSettingsPath(this, "Detailed");

        public int BranchDropDownMinWidth => 300;
        public int BranchDropDownMaxWidth => 600;





        public RepoDistSettings SettingsContainer { get; private set; }

        public AppSettingsImplementations(IApplicationDataPathResolver applicationDataPathResolver,
            RepoDistSettings settings,
            ICommandLogger commandLogger)
        {
            ApplicationDataPath = new Lazy<string>(applicationDataPathResolver.Resolve);
            SettingsContainer = settings;

            DetailedSettingsPath = new AppSettingsPath(settings, "Detailed");
            ShowConEmuTab = new BoolNullableSetting("ShowConEmuTab", DetailedSettingsPath, true);
            ConEmuStyle = new StringSetting("ConEmuStyle", DetailedSettingsPath, "<Solarized Light>");
            ConEmuTerminal = new StringSetting("ConEmuTerminal", DetailedSettingsPath, "bash");
            ConEmuFontSize = new StringSetting("ConEmuFontSize", DetailedSettingsPath, "12");
            ShowRevisionInfoNextToRevisionGrid = new BoolNullableSetting("ShowRevisionInfoNextToRevisionGrid", DetailedSettingsPath, false);
        }

        public AppSettingsImplementations()
            : this(new ApplicationDataPathResolver(),
                new RepoDistSettings(null, GitExtSettingsCache.FromCache(new ApplicationDataPathResolver().Resolve() + AppSettings.SettingsFileName)),
                new CommandLogger())
        {
        }


        public BoolNullableSetting ShowConEmuTab { get; }
        public StringSetting ConEmuStyle { get; }
        public StringSetting ConEmuTerminal { get; }
        public StringSetting ConEmuFontSize { get; }
        public BoolNullableSetting ShowRevisionInfoNextToRevisionGrid { get; }

        // AppSettings()
        //{
        //    ApplicationDataPath = new Lazy<string>(() =>
        //    {
        //        if (IsPortable())
        //        {
        //            return GetGitExtensionsDirectory();
        //        }
        //        else
        //        {
        //            //Make applicationdatapath version independent
        //            return Application.UserAppDataPath.Replace(Application.ProductVersion, string.Empty);
        //        }
        //    }
        //    );

        //    _SettingsContainer = new RepoDistSettings(null, GitExtSettingsCache.FromCache(SettingsFilePath));

        //    GitLog = new CommandLogger();

        //    if (!File.Exists(SettingsFilePath))
        //    {
        //        ImportFromRegistry();
        //    }
        //}

        public bool AutoNormaliseBranchName
        {
            get { return SettingsContainer.GetBool("AutoNormaliseBranchName", true); }
            set { SettingsContainer.SetBool("AutoNormaliseBranchName", value); }
        }

        public string AutoNormaliseSymbol
        {
            // when persisted "" is treated as null, so use "+" instead
            get
            {
                var value = SettingsContainer.GetString("AutoNormaliseSymbol", "_");
                return (value == "+") ? "" : value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = "+";
                }
                SettingsContainer.SetString("AutoNormaliseSymbol", value);
            }
        }

        public bool RememberAmendCommitState
        {
            get { return SettingsContainer.GetBool("RememberAmendCommitState", true); }
            set { SettingsContainer.SetBool("RememberAmendCommitState", value); }
        }

        public void UsingContainer(RepoDistSettings settingsContainer, Action action)
        {
            SettingsContainer.LockedAction(() =>
                {
                    var oldSC = SettingsContainer;
                    try
                    {
                        SettingsContainer = settingsContainer;
                        action();
                    }
                    finally
                    {
                        SettingsContainer = oldSC;
                        //refresh settings if needed
                        SettingsContainer.GetString(string.Empty, null);
                    }
                }
             );
        }

        //public  string GetInstallDir()
        //{
        //    if (IsPortable())
        //        return GetGitExtensionsDirectory();

        //    string dir = ReadStringRegValue("InstallDir", string.Empty);
        //    if (String.IsNullOrEmpty(dir))
        //        return GetGitExtensionsDirectory();
        //    return dir;
        //}

        //        public  string GetResourceDir()
        //        {
        //#if DEBUG
        //            string gitExtDir = GetGitExtensionsDirectory().TrimEnd('\\').TrimEnd('/');
        //            string debugPath = @"GitExtensions\bin\Debug";
        //            int len = debugPath.Length;
        //            var path = gitExtDir.Substring(gitExtDir.Length - len);
        //            if (debugPath.ToPosixPath().Equals(path.ToPosixPath()))
        //            {
        //                string projectPath = gitExtDir.Substring(0, gitExtDir.Length - len);
        //                return Path.Combine(projectPath, "Bin");
        //            }
        //#endif
        //            return GetInstallDir();
        //        }

        ////for repair only
        //public  void SetInstallDir(string dir)
        //{
        //    WriteStringRegValue("InstallDir", dir);
        //}

        private bool ReadBoolRegKey(string key, bool defaultValue)
        {
            object obj = VersionIndependentRegKey.GetValue(key);
            if (!(obj is string))
                obj = null;
            if (obj == null)
                return defaultValue;
            return ((string)obj).Equals("true", StringComparison.CurrentCultureIgnoreCase);
        }

        private void WriteBoolRegKey(string key, bool value)
        {
            VersionIndependentRegKey.SetValue(key, value ? "true" : "false");
        }

        private string ReadStringRegValue(string key, string defaultValue)
        {
            return (string)VersionIndependentRegKey.GetValue(key, defaultValue);
        }

        private void WriteStringRegValue(string key, string value)
        {
            VersionIndependentRegKey.SetValue(key, value);
        }

        public bool CheckSettings
        {
            get { return ReadBoolRegKey("CheckSettings", true); }
            set { WriteBoolRegKey("CheckSettings", value); }
        }

        public string CascadeShellMenuItems
        {
            get { return ReadStringRegValue("CascadeShellMenuItems", "110111000111111111"); }
            set { WriteStringRegValue("CascadeShellMenuItems", value); }
        }

        public string SshPath
        {
            get { return ReadStringRegValue("gitssh", null); }
            set { WriteStringRegValue("gitssh", value); }
        }

        public bool AlwaysShowAllCommands
        {
            get { return ReadBoolRegKey("AlwaysShowAllCommands", false); }
            set { WriteBoolRegKey("AlwaysShowAllCommands", value); }
        }

        public bool ShowCurrentBranchInVisualStudio
        {
            //This setting MUST be set to false by default, otherwise it will not work in Visual Studio without
            //other changes in the Visual Studio plugin itself.
            get { return ReadBoolRegKey("ShowCurrentBranchInVS", true); }
            set { WriteBoolRegKey("ShowCurrentBranchInVS", value); }
        }

        public string GitCommandValue
        {
            get
            {
                if (AppSettings.IsPortable())
                    return SettingsContainer.GetString("gitcommand", "");
                else
                    return ReadStringRegValue("gitcommand", "");
            }
            set
            {
                if (AppSettings.IsPortable())
                    SettingsContainer.SetString("gitcommand", value);
                else
                    WriteStringRegValue("gitcommand", value);
            }
        }

        public string GitCommand
        {
            get
            {
                if (String.IsNullOrEmpty(GitCommandValue))
                    return "git";
                return GitCommandValue;
            }
        }

        public int UserMenuLocationX
        {
            get { return SettingsContainer.GetInt("usermenulocationx", -1); }
            set { SettingsContainer.SetInt("usermenulocationx", value); }
        }

        public int UserMenuLocationY
        {
            get { return SettingsContainer.GetInt("usermenulocationy", -1); }
            set { SettingsContainer.SetInt("usermenulocationy", value); }
        }

        public bool StashKeepIndex
        {
            get { return SettingsContainer.GetBool("stashkeepindex", false); }
            set { SettingsContainer.SetBool("stashkeepindex", value); }
        }

        public bool StashConfirmDropShow
        {
            get { return SettingsContainer.GetBool("stashconfirmdropshow", true); }
            set { SettingsContainer.SetBool("stashconfirmdropshow", value); }
        }

        public bool ApplyPatchIgnoreWhitespace
        {
            get { return SettingsContainer.GetBool("applypatchignorewhitespace", false); }
            set { SettingsContainer.SetBool("applypatchignorewhitespace", value); }
        }

        public bool UsePatienceDiffAlgorithm
        {
            get { return SettingsContainer.GetBool("usepatiencediffalgorithm", false); }
            set { SettingsContainer.SetBool("usepatiencediffalgorithm", value); }
        }

        public bool ShowErrorsWhenStagingFiles
        {
            get { return SettingsContainer.GetBool("showerrorswhenstagingfiles", true); }
            set { SettingsContainer.SetBool("showerrorswhenstagingfiles", value); }
        }

        public bool AddNewlineToCommitMessageWhenMissing
        {
            get { return SettingsContainer.GetBool("addnewlinetocommitmessagewhenmissing", true); }
            set { SettingsContainer.SetBool("addnewlinetocommitmessagewhenmissing", value); }
        }

        public string LastCommitMessage
        {
            get { return SettingsContainer.GetString("lastCommitMessage", ""); }
            set { SettingsContainer.SetString("lastCommitMessage", value); }
        }

        public int CommitDialogNumberOfPreviousMessages
        {
            get { return SettingsContainer.GetInt("commitDialogNumberOfPreviousMessages", 4); }
            set { SettingsContainer.SetInt("commitDialogNumberOfPreviousMessages", value); }
        }

        public bool ShowCommitAndPush
        {
            get { return SettingsContainer.GetBool("showcommitandpush", true); }
            set { SettingsContainer.SetBool("showcommitandpush", value); }
        }

        public bool ShowResetUnstagedChanges
        {
            get { return SettingsContainer.GetBool("showresetunstagedchanges", true); }
            set { SettingsContainer.SetBool("showresetunstagedchanges", value); }
        }

        public bool ShowResetAllChanges
        {
            get { return SettingsContainer.GetBool("showresetallchanges", true); }
            set { SettingsContainer.SetBool("showresetallchanges", value); }
        }


        public bool ProvideAutocompletion
        {
            get { return SettingsContainer.GetBool("provideautocompletion", true); }
            set { SettingsContainer.SetBool("provideautocompletion", value); }
        }

        public string TruncatePathMethod
        {
            get { return SettingsContainer.GetString("truncatepathmethod", "none"); }
            set { SettingsContainer.SetString("truncatepathmethod", value); }
        }

        public bool ShowGitStatusInBrowseToolbar
        {
            get { return SettingsContainer.GetBool("showgitstatusinbrowsetoolbar", true); }
            set { SettingsContainer.SetBool("showgitstatusinbrowsetoolbar", value); }
        }

        public bool CommitInfoShowContainedInBranches
        {
            get
            {
                return CommitInfoShowContainedInBranchesLocal ||
                       CommitInfoShowContainedInBranchesRemote ||
                       CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            }
        }

        public bool CommitInfoShowContainedInBranchesLocal
        {
            get { return SettingsContainer.GetBool("commitinfoshowcontainedinbrancheslocal", true); }
            set { SettingsContainer.SetBool("commitinfoshowcontainedinbrancheslocal", value); }
        }

        public bool CheckForUncommittedChangesInCheckoutBranch
        {
            get { return SettingsContainer.GetBool("checkforuncommittedchangesincheckoutbranch", true); }
            set { SettingsContainer.SetBool("checkforuncommittedchangesincheckoutbranch", value); }
        }

        public bool AlwaysShowCheckoutBranchDlg
        {
            get { return SettingsContainer.GetBool("AlwaysShowCheckoutBranchDlg", false); }
            set { SettingsContainer.SetBool("AlwaysShowCheckoutBranchDlg", value); }
        }

        public bool CommitInfoShowContainedInBranchesRemote
        {
            get { return SettingsContainer.GetBool("commitinfoshowcontainedinbranchesremote", false); }
            set { SettingsContainer.SetBool("commitinfoshowcontainedinbranchesremote", value); }
        }

        public bool CommitInfoShowContainedInBranchesRemoteIfNoLocal
        {
            get { return SettingsContainer.GetBool("commitinfoshowcontainedinbranchesremoteifnolocal", false); }
            set { SettingsContainer.SetBool("commitinfoshowcontainedinbranchesremoteifnolocal", value); }
        }

        public bool CommitInfoShowContainedInTags
        {
            get { return SettingsContainer.GetBool("commitinfoshowcontainedintags", true); }
            set { SettingsContainer.SetBool("commitinfoshowcontainedintags", value); }
        }

        public string GravatarCachePath
        {
            get { return Path.Combine(ApplicationDataPath.Value, "Images\\"); }
        }

        public string Translation
        {
            get { return SettingsContainer.GetString("translation", ""); }
            set { SettingsContainer.SetString("translation", value); }
        }

        private string _currentTranslation;
        public string CurrentTranslation
        {
            get { return _currentTranslation ?? Translation; }
            set { _currentTranslation = value; }
        }


        private readonly Dictionary<string, string> _languageCodes =
            new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"Czech", "cs"},
                {"Dutch", "nl"},
                {"English", "en"},
                {"French", "fr"},
                {"German", "de"},
                {"Indonesian", "id"},
                {"Italian", "it"},
                {"Japanese", "ja"},
                {"Korean", "ko"},
                {"Polish", "pl"},
                {"Portuguese (Brazil)", "pt-BR"},
                {"Portuguese (Portugal)", "pt-PT"},
                {"Romanian", "ro"},
                {"Russian", "ru"},
                {"Simplified Chinese", "zh-CN"},
                {"Spanish", "es"},
                {"Traditional Chinese", "zh-TW"}
            };

        public string CurrentLanguageCode
        {
            get
            {
                string code;
                if (_languageCodes.TryGetValue(CurrentTranslation, out code))
                    return code;
                return "en";
            }
        }

        public CultureInfo CurrentCultureInfo
        {
            get
            {
                try
                {
                    return CultureInfo.GetCultureInfo(CurrentLanguageCode);

                }
                catch (System.Globalization.CultureNotFoundException)
                {
                    Debug.WriteLine("Culture {0} not found", CurrentLanguageCode);
                    return CultureInfo.GetCultureInfo("en");
                }
            }
        }

        public bool UserProfileHomeDir
        {
            get { return SettingsContainer.GetBool("userprofilehomedir", false); }
            set { SettingsContainer.SetBool("userprofilehomedir", value); }
        }

        public string CustomHomeDir
        {
            get { return SettingsContainer.GetString("customhomedir", ""); }
            set { SettingsContainer.SetString("customhomedir", value); }
        }

        public bool EnableAutoScale
        {
            get { return SettingsContainer.GetBool("enableautoscale", true); }
            set { SettingsContainer.SetBool("enableautoscale", value); }
        }

        public string IconColor
        {
            get { return SettingsContainer.GetString("iconcolor", "default"); }
            set { SettingsContainer.SetString("iconcolor", value); }
        }

        public string IconStyle
        {
            get { return SettingsContainer.GetString("iconstyle", "default"); }
            set { SettingsContainer.SetString("iconstyle", value); }
        }

        public int AuthorImageSize
        {
            get { return SettingsContainer.GetInt("authorimagesize", 80); }
            set { SettingsContainer.SetInt("authorimagesize", value); }
        }

        public int AuthorImageCacheDays
        {
            get { return SettingsContainer.GetInt("authorimagecachedays", 5); }
            set { SettingsContainer.SetInt("authorimagecachedays", value); }
        }

        public bool ShowAuthorGravatar
        {
            get { return SettingsContainer.GetBool("showauthorgravatar", true); }
            set { SettingsContainer.SetBool("showauthorgravatar", value); }
        }

        public bool CloseCommitDialogAfterCommit
        {
            get { return SettingsContainer.GetBool("closecommitdialogaftercommit", true); }
            set { SettingsContainer.SetBool("closecommitdialogaftercommit", value); }
        }

        public bool CloseCommitDialogAfterLastCommit
        {
            get { return SettingsContainer.GetBool("closecommitdialogafterlastcommit", true); }
            set { SettingsContainer.SetBool("closecommitdialogafterlastcommit", value); }
        }

        public bool RefreshCommitDialogOnFormFocus
        {
            get { return SettingsContainer.GetBool("refreshcommitdialogonformfocus", false); }
            set { SettingsContainer.SetBool("refreshcommitdialogonformfocus", value); }
        }

        public bool StageInSuperprojectAfterCommit
        {
            get { return SettingsContainer.GetBool("stageinsuperprojectaftercommit", true); }
            set { SettingsContainer.SetBool("stageinsuperprojectaftercommit", value); }
        }

        public bool PlaySpecialStartupSound
        {
            get { return SettingsContainer.GetBool("PlaySpecialStartupSound", false); }
            set { SettingsContainer.SetBool("PlaySpecialStartupSound", value); }
        }

        public bool FollowRenamesInFileHistory
        {
            get { return SettingsContainer.GetBool("followrenamesinfilehistory", true); }
            set { SettingsContainer.SetBool("followrenamesinfilehistory", value); }
        }

        public bool FollowRenamesInFileHistoryExactOnly
        {
            get { return SettingsContainer.GetBool("followrenamesinfilehistoryexactonly", false); }
            set { SettingsContainer.SetBool("followrenamesinfilehistoryexactonly", value); }
        }

        public bool FullHistoryInFileHistory
        {
            get { return SettingsContainer.GetBool("fullhistoryinfilehistory", false); }
            set { SettingsContainer.SetBool("fullhistoryinfilehistory", value); }
        }

        public bool LoadFileHistoryOnShow
        {
            get { return SettingsContainer.GetBool("LoadFileHistoryOnShow", true); }
            set { SettingsContainer.SetBool("LoadFileHistoryOnShow", value); }
        }

        public bool LoadBlameOnShow
        {
            get { return SettingsContainer.GetBool("LoadBlameOnShow", true); }
            set { SettingsContainer.SetBool("LoadBlameOnShow", value); }
        }

        public bool OpenSubmoduleDiffInSeparateWindow
        {
            get { return SettingsContainer.GetBool("opensubmodulediffinseparatewindow", false); }
            set { SettingsContainer.SetBool("opensubmodulediffinseparatewindow", value); }
        }

        public bool RevisionGraphShowWorkingDirChanges
        {
            get { return SettingsContainer.GetBool("revisiongraphshowworkingdirchanges", false); }
            set { SettingsContainer.SetBool("revisiongraphshowworkingdirchanges", value); }
        }

        public bool RevisionGraphDrawNonRelativesGray
        {
            get { return SettingsContainer.GetBool("revisiongraphdrawnonrelativesgray", true); }
            set { SettingsContainer.SetBool("revisiongraphdrawnonrelativesgray", value); }
        }

        public bool RevisionGraphDrawNonRelativesTextGray
        {
            get { return SettingsContainer.GetBool("revisiongraphdrawnonrelativestextgray", false); }
            set { SettingsContainer.SetBool("revisiongraphdrawnonrelativestextgray", value); }
        }

        public IDictionary<string, Encoding> AvailableEncodings { get; } = new Dictionary<string, Encoding>();

        public PullAction FormPullAction
        {
            get { return SettingsContainer.GetEnum("FormPullAction", PullAction.Merge); }
            set { SettingsContainer.SetEnum("FormPullAction", value); }
        }

        public bool SetNextPullActionAsDefault
        {
            get { return !SettingsContainer.GetBool("DonSetAsLastPullAction", true); }
            set { SettingsContainer.SetBool("DonSetAsLastPullAction", !value); }
        }

        public string SmtpServer
        {
            get { return SettingsContainer.GetString("SmtpServer", "smtp.gmail.com"); }
            set { SettingsContainer.SetString("SmtpServer", value); }
        }

        public int SmtpPort
        {
            get { return SettingsContainer.GetInt("SmtpPort", 465); }
            set { SettingsContainer.SetInt("SmtpPort", value); }
        }

        public bool SmtpUseSsl
        {
            get { return SettingsContainer.GetBool("SmtpUseSsl", true); }
            set { SettingsContainer.SetBool("SmtpUseSsl", value); }
        }

        public bool AutoStash
        {
            get { return SettingsContainer.GetBool("autostash", false); }
            set { SettingsContainer.SetBool("autostash", value); }
        }

        public bool RebaseAutoStash
        {
            get { return SettingsContainer.GetBool("RebaseAutostash", false); }
            set { SettingsContainer.SetBool("RebaseAutostash", value); }
        }

        public LocalChangesAction CheckoutBranchAction
        {
            get { return SettingsContainer.GetEnum("checkoutbranchaction", LocalChangesAction.DontChange); }
            set { SettingsContainer.SetEnum("checkoutbranchaction", value); }
        }

        public bool UseDefaultCheckoutBranchAction
        {
            get { return SettingsContainer.GetBool("UseDefaultCheckoutBranchAction", false); }
            set { SettingsContainer.SetBool("UseDefaultCheckoutBranchAction", value); }
        }

        public bool DontShowHelpImages
        {
            get { return SettingsContainer.GetBool("DontShowHelpImages", false); }
            set { SettingsContainer.SetBool("DontShowHelpImages", value); }
        }

        public bool GetHelpIsExpanded(string helpId, bool defaultValue)
        {
            return SettingsContainer.GetBool($"HelpIsExpanded{helpId}", defaultValue);
        }

        public void SetHelpIsExpanded(string helpId, bool value)
        {
            SettingsContainer.SetBool($"HelpIsExpanded{helpId}", value); 
        }
        
        public bool AlwaysShowAdvOpt
        {
            get { return SettingsContainer.GetBool("AlwaysShowAdvOpt", false); }
            set { SettingsContainer.SetBool("AlwaysShowAdvOpt", value); }
        }

        public bool DontConfirmAmend
        {
            get { return SettingsContainer.GetBool("DontConfirmAmend", false); }
            set { SettingsContainer.SetBool("DontConfirmAmend", value); }
        }

        public bool DontConfirmCommitIfNoBranch
        {
            get { return SettingsContainer.GetBool("DontConfirmCommitIfNoBranch", false); }
            set { SettingsContainer.SetBool("DontConfirmCommitIfNoBranch", value); }
        }

        public bool? AutoPopStashAfterPull
        {
            get { return SettingsContainer.GetBool("AutoPopStashAfterPull"); }
            set { SettingsContainer.SetBool("AutoPopStashAfterPull", value); }
        }

        public bool? AutoPopStashAfterCheckoutBranch
        {
            get { return SettingsContainer.GetBool("AutoPopStashAfterCheckoutBranch"); }
            set { SettingsContainer.SetBool("AutoPopStashAfterCheckoutBranch", value); }
        }

        public PullAction? AutoPullOnPushRejectedAction
        {
            get { return SettingsContainer.GetNullableEnum<PullAction>("AutoPullOnPushRejectedAction"); }
            set { SettingsContainer.SetNullableEnum<PullAction>("AutoPullOnPushRejectedAction", value); }
        }

        public bool DontConfirmPushNewBranch
        {
            get { return SettingsContainer.GetBool("DontConfirmPushNewBranch", false); }
            set { SettingsContainer.SetBool("DontConfirmPushNewBranch", value); }
        }

        public bool DontConfirmAddTrackingRef
        {
            get { return SettingsContainer.GetBool("DontConfirmAddTrackingRef", false); }
            set { SettingsContainer.SetBool("DontConfirmAddTrackingRef", value); }
        }

        public bool DontConfirmCommitAfterConflictsResolved
        {
            get { return SettingsContainer.GetBool("DontConfirmCommitAfterConflictsResolved", false); }
            set { SettingsContainer.SetBool("DontConfirmCommitAfterConflictsResolved", value); }
        }

        public bool DontConfirmSecondAbortConfirmation
        {
            get { return SettingsContainer.GetBool("DontConfirmSecondAbortConfirmation", false); }
            set { SettingsContainer.SetBool("DontConfirmSecondAbortConfirmation", value); }
        }

        public bool DontConfirmResolveConflicts
        {
            get { return SettingsContainer.GetBool("DontConfirmResolveConflicts", false); }
            set { SettingsContainer.SetBool("DontConfirmResolveConflicts", value); }
        }

        public bool IncludeUntrackedFilesInAutoStash
        {
            get { return SettingsContainer.GetBool("includeUntrackedFilesInAutoStash", false); }
            set { SettingsContainer.SetBool("includeUntrackedFilesInAutoStash", value); }
        }

        public bool IncludeUntrackedFilesInManualStash
        {
            get { return SettingsContainer.GetBool("includeUntrackedFilesInManualStash", false); }
            set { SettingsContainer.SetBool("includeUntrackedFilesInManualStash", value); }
        }

        public bool OrderRevisionByDate
        {
            get { return SettingsContainer.GetBool("orderrevisionbydate", true); }
            set { SettingsContainer.SetBool("orderrevisionbydate", value); }
        }

        public bool ShowRemoteBranches
        {
            get { return SettingsContainer.GetBool("showRemoteBranches", true); }
            set { SettingsContainer.SetBool("showRemoteBranches", value); }
        }

        public bool ShowSuperprojectTags
        {
            get { return SettingsContainer.GetBool("showSuperprojectTags", false); }
            set { SettingsContainer.SetBool("showSuperprojectTags", value); }
        }

        public bool ShowSuperprojectBranches
        {
            get { return SettingsContainer.GetBool("showSuperprojectBranches", true); }
            set { SettingsContainer.SetBool("showSuperprojectBranches", value); }
        }

        public bool ShowSuperprojectRemoteBranches
        {
            get { return SettingsContainer.GetBool("showSuperprojectRemoteBranches", false); }
            set { SettingsContainer.SetBool("showSuperprojectRemoteBranches", value); }
        }

        public bool? UpdateSubmodulesOnCheckout
        {
            get { return SettingsContainer.GetBool("updateSubmodulesOnCheckout"); }
            set { SettingsContainer.SetBool("updateSubmodulesOnCheckout", value); }
        }

        public string Dictionary
        {
            get { return SettingsContainer.Dictionary; }
            set { SettingsContainer.Dictionary = value; }
        }

        public bool ShowGitCommandLine
        {
            get { return SettingsContainer.GetBool("showgitcommandline", false); }
            set { SettingsContainer.SetBool("showgitcommandline", value); }
        }

        public bool ShowStashCount
        {
            get { return SettingsContainer.GetBool("showstashcount", false); }
            set { SettingsContainer.SetBool("showstashcount", value); }
        }

        public bool RelativeDate
        {
            get { return SettingsContainer.GetBool("relativedate", true); }
            set { SettingsContainer.SetBool("relativedate", value); }
        }

        public bool UseFastChecks
        {
            get { return SettingsContainer.GetBool("usefastchecks", false); }
            set { SettingsContainer.SetBool("usefastchecks", value); }
        }

        public bool ShowGitNotes
        {
            get { return SettingsContainer.GetBool("showgitnotes", false); }
            set { SettingsContainer.SetBool("showgitnotes", value); }
        }

        public bool ShowIndicatorForMultilineMessage
        {
            get { return SettingsContainer.GetBool("showindicatorformultilinemessage", false); }
            set { SettingsContainer.SetBool("showindicatorformultilinemessage", value); }
        }

        public bool ShowAnnotatedTagsMessages
        {
            get { return SettingsContainer.GetBool("showannotatedtagsmessages", true); }
            set { SettingsContainer.SetBool("showannotatedtagsmessages", value); }
        }

        public bool ShowMergeCommits
        {
            get { return SettingsContainer.GetBool("showmergecommits", true); }
            set { SettingsContainer.SetBool("showmergecommits", value); }
        }

        public bool ShowTags
        {
            get { return SettingsContainer.GetBool("showtags", true); }
            set { SettingsContainer.SetBool("showtags", value); }
        }

        public bool ShowIds
        {
            get { return SettingsContainer.GetBool("showids", false); }
            set { SettingsContainer.SetBool("showids", value); }
        }

        public int RevisionGraphLayout
        {
            get { return SettingsContainer.GetInt("revisiongraphlayout", 2); }
            set { SettingsContainer.SetInt("revisiongraphlayout", value); }
        }

        public bool ShowAuthorDate
        {
            get { return SettingsContainer.GetBool("showauthordate", true); }
            set { SettingsContainer.SetBool("showauthordate", value); }
        }

        public bool CloseProcessDialog
        {
            get { return SettingsContainer.GetBool("closeprocessdialog", false); }
            set { SettingsContainer.SetBool("closeprocessdialog", value); }
        }

        public bool ShowCurrentBranchOnly
        {
            get { return SettingsContainer.GetBool("showcurrentbranchonly", false); }
            set { SettingsContainer.SetBool("showcurrentbranchonly", value); }
        }

        public bool ShowSimplifyByDecoration
        {
            get { return SettingsContainer.GetBool("showsimplifybydecoration", false); }
            set { SettingsContainer.SetBool("showsimplifybydecoration", value); }
        }

        public bool BranchFilterEnabled
        {
            get { return SettingsContainer.GetBool("branchfilterenabled", false); }
            set { SettingsContainer.SetBool("branchfilterenabled", value); }
        }

        public bool ShowFirstParent
        {
            get { return SettingsContainer.GetBool("showfirstparent", false); }
            set { SettingsContainer.SetBool("showfirstparent", value); }
        }

        public int CommitDialogDeviceDpi
        {
            get { return SettingsContainer.GetInt("commitdialogdevicedpi", 96); }
            set { SettingsContainer.SetInt("commitdialogdevicedpi", value); }
        }

        public int CommitDialogSplitter
        {
            get { return SettingsContainer.GetInt("commitdialogsplitter", -1); }
            set { SettingsContainer.SetInt("commitdialogsplitter", value); }
        }

        public int CommitDialogRightSplitter
        {
            get { return SettingsContainer.GetInt("commitdialogrightsplitter", -1); }
            set { SettingsContainer.SetInt("commitdialogrightsplitter", value); }
        }

        public bool CommitDialogSelectionFilter
        {
            get { return SettingsContainer.GetBool("commitdialogselectionfilter", false); }
            set { SettingsContainer.SetBool("commitdialogselectionfilter", value); }
        }

        public string DefaultCloneDestinationPath
        {
            get { return SettingsContainer.GetString("defaultclonedestinationpath", string.Empty); }
            set { SettingsContainer.SetString("defaultclonedestinationpath", value); }
        }

        public int RevisionGridQuickSearchTimeout
        {
            get { return SettingsContainer.GetInt("revisiongridquicksearchtimeout", 750); }
            set { SettingsContainer.SetInt("revisiongridquicksearchtimeout", value); }
        }

        public string GravatarFallbackService
        {
            get { return SettingsContainer.GetString("gravatarfallbackservice", "Identicon"); }
            set { SettingsContainer.SetString("gravatarfallbackservice", value); }
        }

        /// <summary>Gets or sets the path to the git application executable.</summary>
        public string GitBinDir
        {
            get { return SettingsContainer.GetString("gitbindir", ""); }
            set
            {
                var temp = value.EnsureTrailingPathSeparator();
                SettingsContainer.SetString("gitbindir", temp);

                //if (string.IsNullOrEmpty(_gitBinDir))
                //    return;

                //var path =
                //    Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.Process) + ";" +
                //    _gitBinDir;
                //Environment.SetEnvironmentVariable("path", path, EnvironmentVariableTarget.Process);
            }
        }

        public int MaxRevisionGraphCommits
        {
            get { return SettingsContainer.GetInt("maxrevisiongraphcommits", 100000); }
            set { SettingsContainer.SetInt("maxrevisiongraphcommits", value); }
        }

        public bool ShowDiffForAllParents
        {
            get { return SettingsContainer.GetBool("showdiffforallparents", true); }
            set { SettingsContainer.SetBool("showdiffforallparents", value); }
        }

        public string RecentWorkingDir
        {
            get { return SettingsContainer.GetString("RecentWorkingDir", null); }
            set { SettingsContainer.SetString("RecentWorkingDir", value); }
        }

        public bool StartWithRecentWorkingDir
        {
            get { return SettingsContainer.GetBool("StartWithRecentWorkingDir", false); }
            set { SettingsContainer.SetBool("StartWithRecentWorkingDir", value); }
        }

        public CommandLogger GitLog { get; private set; }

        public string Plink
        {
            get { return SettingsContainer.GetString("plink", Environment.GetEnvironmentVariable("GITEXT_PLINK") ?? ReadStringRegValue("plink", "")); }
            set { if (value != Environment.GetEnvironmentVariable("GITEXT_PLINK")) SettingsContainer.SetString("plink", value); }
        }
        public string Puttygen
        {
            get { return SettingsContainer.GetString("puttygen", Environment.GetEnvironmentVariable("GITEXT_PUTTYGEN") ?? ReadStringRegValue("puttygen", "")); }
            set { if (value != Environment.GetEnvironmentVariable("GITEXT_PUTTYGEN")) SettingsContainer.SetString("puttygen", value); }
        }

        /// <summary>Gets the path to Pageant (SSH auth agent).</summary>
        public string Pageant
        {
            get { return SettingsContainer.GetString("pageant", Environment.GetEnvironmentVariable("GITEXT_PAGEANT") ?? ReadStringRegValue("pageant", "")); }
            set { if (value != Environment.GetEnvironmentVariable("GITEXT_PAGEANT")) SettingsContainer.SetString("pageant", value); }
        }

        public bool AutoStartPageant
        {
            get { return SettingsContainer.GetBool("autostartpageant", true); }
            set { SettingsContainer.SetBool("autostartpageant", value); }
        }

        public bool MarkIllFormedLinesInCommitMsg
        {
            get { return SettingsContainer.GetBool("markillformedlinesincommitmsg", false); }
            set { SettingsContainer.SetBool("markillformedlinesincommitmsg", value); }
        }

        #region Colors

        public Color OtherTagColor
        {
            get { return SettingsContainer.GetColor("othertagcolor", Color.Gray); }
            set { SettingsContainer.SetColor("othertagcolor", value); }
        }

        public Color TagColor
        {
            get { return SettingsContainer.GetColor("tagcolor", Color.DarkBlue); }
            set { SettingsContainer.SetColor("tagcolor", value); }
        }

        public Color GraphColor
        {
            get { return SettingsContainer.GetColor("graphcolor", Color.DarkRed); }
            set { SettingsContainer.SetColor("graphcolor", value); }
        }

        public Color BranchColor
        {
            get { return SettingsContainer.GetColor("branchcolor", Color.DarkRed); }
            set { SettingsContainer.SetColor("branchcolor", value); }
        }

        public Color RemoteBranchColor
        {
            get { return SettingsContainer.GetColor("remotebranchcolor", Color.Green); }
            set { SettingsContainer.SetColor("remotebranchcolor", value); }
        }

        public Color DiffSectionColor
        {
            get { return SettingsContainer.GetColor("diffsectioncolor", Color.FromArgb(230, 230, 230)); }
            set { SettingsContainer.SetColor("diffsectioncolor", value); }
        }

        public Color DiffRemovedColor
        {
            get { return SettingsContainer.GetColor("diffremovedcolor", Color.FromArgb(255, 200, 200)); }
            set { SettingsContainer.SetColor("diffremovedcolor", value); }
        }

        public Color DiffRemovedExtraColor
        {
            get { return SettingsContainer.GetColor("diffremovedextracolor", Color.FromArgb(255, 150, 150)); }
            set { SettingsContainer.SetColor("diffremovedextracolor", value); }
        }

        public Color DiffAddedColor
        {
            get { return SettingsContainer.GetColor("diffaddedcolor", Color.FromArgb(200, 255, 200)); }
            set { SettingsContainer.SetColor("diffaddedcolor", value); }
        }

        public Color DiffAddedExtraColor
        {
            get { return SettingsContainer.GetColor("diffaddedextracolor", Color.FromArgb(135, 255, 135)); }
            set { SettingsContainer.SetColor("diffaddedextracolor", value); }
        }

        public Color AuthoredRevisionsColor
        {
            get { return SettingsContainer.GetColor("authoredrevisionscolor", Color.LightYellow); }
            set { SettingsContainer.SetColor("authoredrevisionscolor", value); }
        }

        public Font DiffFont
        {
            get { return SettingsContainer.GetFont("difffont", new Font("Courier New", 10)); }
            set { SettingsContainer.SetFont("difffont", value); }
        }

        public Font CommitFont
        {
            get { return SettingsContainer.GetFont("commitfont", new Font(SystemFonts.DialogFont.Name, SystemFonts.MessageBoxFont.Size)); }
            set { SettingsContainer.SetFont("commitfont", value); }
        }

        public Font Font
        {
            get { return SettingsContainer.GetFont("font", new Font(SystemFonts.DialogFont.Name, SystemFonts.DefaultFont.Size)); }
            set { SettingsContainer.SetFont("font", value); }
        }

        #endregion

        public bool MulticolorBranches
        {
            get { return SettingsContainer.GetBool("multicolorbranches", true); }
            set { SettingsContainer.SetBool("multicolorbranches", value); }
        }

        public bool StripedBranchChange
        {
            get { return SettingsContainer.GetBool("stripedbranchchange", true); }
            set { SettingsContainer.SetBool("stripedbranchchange", value); }
        }

        public bool BranchBorders
        {
            get { return SettingsContainer.GetBool("branchborders", true); }
            set { SettingsContainer.SetBool("branchborders", value); }
        }

        public bool HighlightAuthoredRevisions
        {
            get { return SettingsContainer.GetBool("highlightauthoredrevisions", true); }
            set { SettingsContainer.SetBool("highlightauthoredrevisions", value); }
        }

        public string LastFormatPatchDir
        {
            get { return SettingsContainer.GetString("lastformatpatchdir", ""); }
            set { SettingsContainer.SetString("lastformatpatchdir", value); }
        }

        public bool IgnoreWhitespaceChanges
        {
            get
            {
                return RememberIgnoreWhiteSpacePreference && SettingsContainer.GetBool("IgnoreWhitespaceChanges", false);
            }
            set
            {
                if (RememberIgnoreWhiteSpacePreference)
                {
                    SettingsContainer.SetBool("IgnoreWhitespaceChanges", value);
                }
            }
        }

        public bool RememberIgnoreWhiteSpacePreference
        {
            get { return SettingsContainer.GetBool("rememberIgnoreWhiteSpacePreference", true); }
            set { SettingsContainer.SetBool("rememberIgnoreWhiteSpacePreference", value); }
        }

        public bool ShowNonPrintingChars
        {
            get
            {
                return RememberShowNonPrintingCharsPreference && SettingsContainer.GetBool("ShowNonPrintingChars", false);
            }
            set
            {
                if (RememberShowNonPrintingCharsPreference)
                {
                    SettingsContainer.SetBool("ShowNonPrintingChars", value);
                }
            }
        }

        public bool RememberShowNonPrintingCharsPreference
        {
            get { return SettingsContainer.GetBool("RememberShowNonPrintableCharsPreference", false); }
            set { SettingsContainer.SetBool("RememberShowNonPrintableCharsPreference", value); }
        }

        public bool ShowEntireFile
        {
            get
            {
                return RememberShowEntireFilePreference && SettingsContainer.GetBool("ShowEntireFile", false);
            }
            set
            {
                if (RememberShowEntireFilePreference)
                {
                    SettingsContainer.SetBool("ShowEntireFile", value);
                }
            }
        }

        public bool RememberShowEntireFilePreference
        {
            get { return SettingsContainer.GetBool("RememberShowEntireFilePreference", false); }
            set { SettingsContainer.SetBool("RememberShowEntireFilePreference", value); }
        }

        public int NumberOfContextLines
        {
            get
            {
                const int defaultValue = 3;
                return RememberNumberOfContextLines ? SettingsContainer.GetInt("NumberOfContextLines", defaultValue) : defaultValue;
            }
            set
            {
                if (RememberNumberOfContextLines)
                {
                    SettingsContainer.SetInt("NumberOfContextLines", value);
                }
            }
        }

        public bool RememberNumberOfContextLines
        {
            get { return SettingsContainer.GetBool("RememberNumberOfContextLines", false); }
            set { SettingsContainer.SetBool("RememberNumberOfContextLines", value); }
        }

        //public  string GetDictionaryDir()
        //{
        //    return Path.Combine(GetResourceDir(), "Dictionaries");
        //}

        public void SaveSettings()
        {
            SaveEncodings();
            try
            {
                SettingsContainer.LockedAction(() =>
                {
                    SshPath = GitCommandHelpers.GetSsh();
                    GitCommands.Repository.Repositories.SaveSettings();

                    SettingsContainer.Save();
                });
            }
            catch
            { }
        }

        public void LoadSettings()
        {
            LoadEncodings();

            try
            {
                GitCommandHelpers.SetSsh(SshPath);
            }
            catch
            { }
        }

        public bool DashboardShowCurrentBranch
        {
            get { return SettingsContainer.GetBool("dashboardshowcurrentbranch", true); }
            set { SettingsContainer.SetBool("dashboardshowcurrentbranch", value); }
        }

        public string ownScripts
        {
            get { return SettingsContainer.GetString("ownScripts", ""); }
            set { SettingsContainer.SetString("ownScripts", value); }
        }

        public int RecursiveSubmodules
        {
            get { return SettingsContainer.GetInt("RecursiveSubmodules", 1); }
            set { SettingsContainer.SetInt("RecursiveSubmodules", value); }
        }

        public string ShorteningRecentRepoPathStrategy
        {
            get { return SettingsContainer.GetString("ShorteningRecentRepoPathStrategy", ""); }
            set { SettingsContainer.SetString("ShorteningRecentRepoPathStrategy", value); }
        }

        public int MaxMostRecentRepositories
        {
            get { return SettingsContainer.GetInt("MaxMostRecentRepositories", 0); }
            set { SettingsContainer.SetInt("MaxMostRecentRepositories", value); }
        }

        public int RecentReposComboMinWidth
        {
            get { return SettingsContainer.GetInt("RecentReposComboMinWidth", 0); }
            set { SettingsContainer.SetInt("RecentReposComboMinWidth", value); }
        }

        public string RemoteRepositoryHistory
        {
            get { return SettingsContainer.GetString("history remote", null); }
            set { SettingsContainer.GetString("history remote", value); }
        }

        public string Repositories
        {
            get { return SettingsContainer.GetString("repositories", null); }
            set { SettingsContainer.GetString("repositories", value); }
        }

        public string RepositoryHistory
        {
            get { return SettingsContainer.GetString("history", null); }
            set { SettingsContainer.GetString("history", value); }
        }

        public int RepositoryHistorySize
        {
            get { return SettingsContainer.GetInt("history size", AppSettings.DefaultRepositoriesCount); }
            set { SettingsContainer.SetInt("history size", value); }
        }

        public string SerializedHotkeys
        {
            get { return SettingsContainer.GetString("SerializedHotkeys", null); }
            set { SettingsContainer.SetString("SerializedHotkeys", value); }
        }

        public bool SortMostRecentRepos
        {
            get { return SettingsContainer.GetBool("SortMostRecentRepos", false); }
            set { SettingsContainer.SetBool("SortMostRecentRepos", value); }
        }

        public bool SortLessRecentRepos
        {
            get { return SettingsContainer.GetBool("SortLessRecentRepos", false); }
            set { SettingsContainer.SetBool("SortLessRecentRepos", value); }
        }

        public bool DontCommitMerge
        {
            get { return SettingsContainer.GetBool("DontCommitMerge", false); }
            set { SettingsContainer.SetBool("DontCommitMerge", value); }
        }

        public int CommitValidationMaxCntCharsFirstLine
        {
            get { return SettingsContainer.GetInt("CommitValidationMaxCntCharsFirstLine", 0); }
            set { SettingsContainer.SetInt("CommitValidationMaxCntCharsFirstLine", value); }
        }

        public int CommitValidationMaxCntCharsPerLine
        {
            get { return SettingsContainer.GetInt("CommitValidationMaxCntCharsPerLine", 0); }
            set { SettingsContainer.SetInt("CommitValidationMaxCntCharsPerLine", value); }
        }

        public bool CommitValidationSecondLineMustBeEmpty
        {
            get { return SettingsContainer.GetBool("CommitValidationSecondLineMustBeEmpty", false); }
            set { SettingsContainer.SetBool("CommitValidationSecondLineMustBeEmpty", value); }
        }

        public bool CommitValidationIndentAfterFirstLine
        {
            get { return SettingsContainer.GetBool("CommitValidationIndentAfterFirstLine", true); }
            set { SettingsContainer.SetBool("CommitValidationIndentAfterFirstLine", value); }
        }

        public bool CommitValidationAutoWrap
        {
            get { return SettingsContainer.GetBool("CommitValidationAutoWrap", true); }
            set { SettingsContainer.SetBool("CommitValidationAutoWrap", value); }
        }

        public string CommitValidationRegEx
        {
            get { return SettingsContainer.GetString("CommitValidationRegEx", String.Empty); }
            set { SettingsContainer.SetString("CommitValidationRegEx", value); }
        }

        public string CommitTemplates
        {
            get { return SettingsContainer.GetString("CommitTemplates", String.Empty); }
            set { SettingsContainer.SetString("CommitTemplates", value); }
        }

        public bool CreateLocalBranchForRemote
        {
            get { return SettingsContainer.GetBool("CreateLocalBranchForRemote", false); }
            set { SettingsContainer.SetBool("CreateLocalBranchForRemote", value); }
        }

        public bool UseFormCommitMessage
        {
            get { return SettingsContainer.GetBool("UseFormCommitMessage", true); }
            set { SettingsContainer.SetBool("UseFormCommitMessage", value); }
        }

        public bool CommitAutomaticallyAfterCherryPick
        {
            get { return SettingsContainer.GetBool("CommitAutomaticallyAfterCherryPick", false); }
            set { SettingsContainer.SetBool("CommitAutomaticallyAfterCherryPick", value); }
        }

        public bool AddCommitReferenceToCherryPick
        {
            get { return SettingsContainer.GetBool("AddCommitReferenceToCherryPick", false); }
            set { SettingsContainer.SetBool("AddCommitReferenceToCherryPick", value); }
        }

        public DateTime LastUpdateCheck
        {
            get { return SettingsContainer.GetDate("LastUpdateCheck", default(DateTime)); }
            set { SettingsContainer.SetDate("LastUpdateCheck", value); }
        }

        public bool CheckForReleaseCandidates
        {
            get { return SettingsContainer.GetBool("CheckForReleaseCandidates", false); }
            set { SettingsContainer.SetBool("CheckForReleaseCandidates", value); }
        }

        public bool OmitUninterestingDiff
        {
            get { return SettingsContainer.GetBool("OmitUninterestingDiff", false); }
            set { SettingsContainer.SetBool("OmitUninterestingDiff", value); }
        }

        public bool UseConsoleEmulatorForCommands
        {
            get { return SettingsContainer.GetBool("UseConsoleEmulatorForCommands", true); }
            set { SettingsContainer.SetBool("UseConsoleEmulatorForCommands", value); }
        }


        private RegistryKey _VersionIndependentRegKey;

        private RegistryKey VersionIndependentRegKey
        {
            get
            {
                if (_VersionIndependentRegKey == null)
                    _VersionIndependentRegKey = Registry.CurrentUser.CreateSubKey("Software\\GitExtensions", RegistryKeyPermissionCheck.ReadWriteSubTree);
                return _VersionIndependentRegKey;
            }
        }


        private IEnumerable<Tuple<string, string>> GetSettingsFromRegistry()
        {
            RegistryKey oldSettings = VersionIndependentRegKey.OpenSubKey("GitExtensions");
            if (oldSettings == null)
                yield break;

            foreach (String name in oldSettings.GetValueNames())
            {
                object value = oldSettings.GetValue(name, null);
                if (value != null)
                    yield return new Tuple<string, string>(name, value.ToString());
            }
        }

        //private  void ImportFromRegistry()
        //{
        //    SettingsContainer.SettingsCache.Import(GetSettingsFromRegistry());
        //}

        public string PrefixedName(string prefix, string name)
        {
            return prefix == null ? name : prefix + '_' + name;
        }

        //public  bool? SettingsContainer.GetBool(string name)
        //{
        //    return SettingsContainer.GetBool(name);
        //}

        //public  bool SettingsContainer.GetBool(string name, bool defaultValue)
        //{
        //    return SettingsContainer.GetBool(name, defaultValue);
        //}

        //public  void SettingsContainer.SetBool(string name, bool? value)
        //{
        //    SettingsContainer.SetBool(name, value);
        //}

        //public  void SettingsContainer.SetInt(string name, int? value)
        //{
        //    SettingsContainer.SetInt(name, value);
        //}

        //public  int? SettingsContainer.GetInt(string name)
        //{
        //    return SettingsContainer.GetInt(name);
        //}

        //public  DateTime GetDate(string name, DateTime defaultValue)
        //{
        //    return SettingsContainer.GetDate(name, defaultValue);
        //}

        //public  void SetDate(string name, DateTime? value)
        //{
        //    SettingsContainer.SetDate(name, value);
        //}

        //public  DateTime? GetDate(string name)
        //{
        //    return SettingsContainer.GetDate(name);
        //}

        //public  int SettingsContainer.GetInt(string name, int defaultValue)
        //{
        //    return SettingsContainer.GetInt(name, defaultValue);
        //}

        //public  void SettingsContainer.SetFont(string name, Font value)
        //{
        //    SettingsContainer.SetFont(name, value);
        //}

        //public  Font SettingsContainer.GetFont(string name, Font defaultValue)
        //{
        //    return SettingsContainer.GetFont(name, defaultValue);
        //}

        //public  void SettingsContainer.SetColor(string name, Color? value)
        //{
        //    SettingsContainer.SetColor(name, value);
        //}

        //public  Color? SettingsContainer.GetColor(string name)
        //{
        //    return SettingsContainer.GetColor(name);
        //}

        //public  Color SettingsContainer.GetColor(string name, Color defaultValue)
        //{
        //    return SettingsContainer.GetColor(name, defaultValue);
        //}

        //public  void SetEnum<T>(string name, T value)
        //{
        //    SettingsContainer.SetEnum(name, value);
        //}

        //public  T GetEnum<T>(string name, T defaultValue) where T : struct
        //{
        //    return SettingsContainer.GetEnum(name, defaultValue);
        //}

        //public  void SetNullableEnum<T>(string name, T? value) where T : struct
        //{
        //    SettingsContainer.SetNullableEnum(name, value);
        //}

        //public  T? SettingsContainer.GetNullableEnum<T>(string name) where T : struct
        //{
        //    return SettingsContainer.GetNullableEnum<T>(name);
        //}

        //public  void SettingsContainer.SetString(string name, string value)
        //{
        //    SettingsContainer.SetString(name, value);
        //}

        //public  string GetString(string name, string defaultValue)
        //{
        //    return SettingsContainer.GetString(name, defaultValue);
        //}

        private void LoadEncodings()
        {
            Action<Encoding> addEncoding = delegate (Encoding e) { AvailableEncodings[e.HeaderName] = e; };
            Action<string> addEncodingByName = delegate (string s) { try { addEncoding(Encoding.GetEncoding(s)); } catch { } };

            string availableEncodings = SettingsContainer.GetString("AvailableEncodings", "");
            if (string.IsNullOrWhiteSpace(availableEncodings))
            {
                // Default encoding set
                addEncoding(Encoding.Default);
                addEncoding(new ASCIIEncoding());
                addEncoding(new UnicodeEncoding());
                addEncoding(new UTF7Encoding());
                addEncoding(new UTF8Encoding(false));
                try
                {
                    addEncoding(Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage));
                }
                catch
                {
                    //there are CultureInfos without a code page
                }
            }
            else
            {
                var utf8 = new UTF8Encoding(false);
                foreach (var encodingName in availableEncodings.Split(';'))
                {
                    // create utf-8 without BOM
                    if (encodingName == utf8.HeaderName)
                        addEncoding(utf8);
                    // default encoding
                    else if (encodingName == "Default")
                        addEncoding(Encoding.Default);
                    // add encoding by name
                    else
                        addEncodingByName(encodingName);
                }
            }
        }

        private void SaveEncodings()
        {
            string availableEncodings = AvailableEncodings.Values.Select(e => e.HeaderName).Join(";");
            availableEncodings = availableEncodings.Replace(Encoding.Default.HeaderName, "Default");
            SettingsContainer.SetString("AvailableEncodings", availableEncodings);
        }

    }
}