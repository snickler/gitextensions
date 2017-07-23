using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;
using GitCommands.Settings;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class GitExtensionsSettingsPage : SettingsPageWithHeader
    {
        public GitExtensionsSettingsPage()
        {
            InitializeComponent();
            Text = "Git Extensions";
            Translate();
        }

        bool loadedDefaultClone = false;
        private void defaultCloneDropDown(object sender, EventArgs e)
        {
            if (!loadedDefaultClone)
            {
                FillDefaultCloneDestinationDropDown();
                loadedDefaultClone = true;
            }
        }

        protected override void SettingsToPage()
        {
            chkCheckForUncommittedChangesInCheckoutBranch.Checked = AppSettings.Current.CheckForUncommittedChangesInCheckoutBranch;
            chkStartWithRecentWorkingDir.Checked = AppSettings.Current.StartWithRecentWorkingDir;
            chkPlaySpecialStartupSound.Checked = AppSettings.Current.PlaySpecialStartupSound;
            chkUsePatienceDiffAlgorithm.Checked = AppSettings.Current.UsePatienceDiffAlgorithm;
            RevisionGridQuickSearchTimeout.Value = AppSettings.Current.RevisionGridQuickSearchTimeout;
            chkFollowRenamesInFileHistory.Checked = AppSettings.Current.FollowRenamesInFileHistory;
            chkStashUntrackedFiles.Checked = AppSettings.Current.IncludeUntrackedFilesInAutoStash;
            chkShowCurrentChangesInRevisionGraph.Checked = AppSettings.Current.RevisionGraphShowWorkingDirChanges;
            chkShowStashCountInBrowseWindow.Checked = AppSettings.Current.ShowStashCount;
            chkShowGitStatusInToolbar.Checked = AppSettings.Current.ShowGitStatusInBrowseToolbar;
            SmtpServer.Text = AppSettings.Current.SmtpServer;
            SmtpServerPort.Text = AppSettings.Current.SmtpPort.ToString();
            chkUseSSL.Checked = AppSettings.Current.SmtpUseSsl;
            _NO_TRANSLATE_MaxCommits.Value = AppSettings.Current.MaxRevisionGraphCommits;
            chkCloseProcessDialog.Checked = AppSettings.Current.CloseProcessDialog;
            chkShowGitCommandLine.Checked = AppSettings.Current.ShowGitCommandLine;
            chkUseFastChecks.Checked = AppSettings.Current.UseFastChecks;
            cbDefaultCloneDestination.Text = AppSettings.Current.DefaultCloneDestinationPath;
            chkFollowRenamesInFileHistoryExact.Checked = AppSettings.Current.FollowRenamesInFileHistoryExactOnly;
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.CheckForUncommittedChangesInCheckoutBranch = chkCheckForUncommittedChangesInCheckoutBranch.Checked;
            AppSettings.Current.StartWithRecentWorkingDir = chkStartWithRecentWorkingDir.Checked;
            AppSettings.Current.PlaySpecialStartupSound = chkPlaySpecialStartupSound.Checked;
            AppSettings.Current.UsePatienceDiffAlgorithm = chkUsePatienceDiffAlgorithm.Checked;
            AppSettings.Current.IncludeUntrackedFilesInAutoStash = chkStashUntrackedFiles.Checked;
            AppSettings.Current.FollowRenamesInFileHistory = chkFollowRenamesInFileHistory.Checked;
            AppSettings.Current.ShowGitStatusInBrowseToolbar = chkShowGitStatusInToolbar.Checked;
            AppSettings.Current.SmtpServer = SmtpServer.Text;
            int port;
            if (int.TryParse(SmtpServerPort.Text, out port))
                AppSettings.Current.SmtpPort = port;
            AppSettings.Current.SmtpUseSsl = chkUseSSL.Checked;
            AppSettings.Current.CloseProcessDialog = chkCloseProcessDialog.Checked;
            AppSettings.Current.ShowGitCommandLine = chkShowGitCommandLine.Checked;
            AppSettings.Current.UseFastChecks = chkUseFastChecks.Checked;
            AppSettings.Current.MaxRevisionGraphCommits = (int)_NO_TRANSLATE_MaxCommits.Value;
            AppSettings.Current.RevisionGridQuickSearchTimeout = (int)RevisionGridQuickSearchTimeout.Value;
            AppSettings.Current.RevisionGraphShowWorkingDirChanges = chkShowCurrentChangesInRevisionGraph.Checked;
            AppSettings.Current.ShowStashCount = chkShowStashCountInBrowseWindow.Checked;
            AppSettings.Current.DefaultCloneDestinationPath = cbDefaultCloneDestination.Text;
            AppSettings.Current.FollowRenamesInFileHistoryExactOnly = chkFollowRenamesInFileHistoryExact.Checked;
        }

        private void chkUseSSL_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!chkUseSSL.Checked)
            {
                if (SmtpServerPort.Text == "587")
                    SmtpServerPort.Text = "465";
            }
            else
            {
                if (SmtpServerPort.Text == "465")
                    SmtpServerPort.Text = "587";
            }
        }

        private void FillDefaultCloneDestinationDropDown()
        {
            var historicPaths = Repositories.RepositoryHistory.Repositories
                                           .Select(GetParentPath())
                                           .Where(x => !string.IsNullOrEmpty(x))
                                           .Distinct(StringComparer.CurrentCultureIgnoreCase)
                                           .ToArray();

            cbDefaultCloneDestination.Items.AddRange(historicPaths);
        }

        private static Func<Repository, string> GetParentPath()
        {
            return x =>
            {
                if (x.Path.StartsWith(@"\\") || !Directory.Exists(x.Path))
                {
                    return string.Empty;
                }

                var dir = new DirectoryInfo(x.Path);
                if (dir.Parent == null)
                {
                    return x.Path;
                }
                return dir.Parent.FullName;
            };
        }

        private void DefaultCloneDestinationBrowseClick(object sender, EventArgs e)
        {
            var userSelectedPath = OsShellUtil.PickFolder(this, cbDefaultCloneDestination.Text);

            if (userSelectedPath != null)
            {
                cbDefaultCloneDestination.Text = userSelectedPath;
            }
        }
    }
}
