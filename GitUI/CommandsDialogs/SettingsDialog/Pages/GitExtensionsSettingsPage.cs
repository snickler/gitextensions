using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;

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
            chkCheckForUncommittedChangesInCheckoutBranch.Checked = AppSettings.Instance.CheckForUncommittedChangesInCheckoutBranch;
            chkStartWithRecentWorkingDir.Checked = AppSettings.Instance.StartWithRecentWorkingDir;
            chkPlaySpecialStartupSound.Checked = AppSettings.Instance.PlaySpecialStartupSound;
            chkUsePatienceDiffAlgorithm.Checked = AppSettings.Instance.UsePatienceDiffAlgorithm;
            RevisionGridQuickSearchTimeout.Value = AppSettings.Instance.RevisionGridQuickSearchTimeout;
            chkFollowRenamesInFileHistory.Checked = AppSettings.Instance.FollowRenamesInFileHistory;
            chkStashUntrackedFiles.Checked = AppSettings.Instance.IncludeUntrackedFilesInAutoStash;
            chkShowCurrentChangesInRevisionGraph.Checked = AppSettings.Instance.RevisionGraphShowWorkingDirChanges;
            chkShowStashCountInBrowseWindow.Checked = AppSettings.Instance.ShowStashCount;
            chkShowGitStatusInToolbar.Checked = AppSettings.Instance.ShowGitStatusInBrowseToolbar;
            SmtpServer.Text = AppSettings.Instance.SmtpServer;
            SmtpServerPort.Text = AppSettings.Instance.SmtpPort.ToString();
            chkUseSSL.Checked = AppSettings.Instance.SmtpUseSsl;
            _NO_TRANSLATE_MaxCommits.Value = AppSettings.Instance.MaxRevisionGraphCommits;
            chkCloseProcessDialog.Checked = AppSettings.Instance.CloseProcessDialog;
            chkShowGitCommandLine.Checked = AppSettings.Instance.ShowGitCommandLine;
            chkUseFastChecks.Checked = AppSettings.Instance.UseFastChecks;
            cbDefaultCloneDestination.Text = AppSettings.Instance.DefaultCloneDestinationPath;
            chkFollowRenamesInFileHistoryExact.Checked = AppSettings.Instance.FollowRenamesInFileHistoryExactOnly;
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.CheckForUncommittedChangesInCheckoutBranch = chkCheckForUncommittedChangesInCheckoutBranch.Checked;
            AppSettings.Instance.StartWithRecentWorkingDir = chkStartWithRecentWorkingDir.Checked;
            AppSettings.Instance.PlaySpecialStartupSound = chkPlaySpecialStartupSound.Checked;
            AppSettings.Instance.UsePatienceDiffAlgorithm = chkUsePatienceDiffAlgorithm.Checked;
            AppSettings.Instance.IncludeUntrackedFilesInAutoStash = chkStashUntrackedFiles.Checked;
            AppSettings.Instance.FollowRenamesInFileHistory = chkFollowRenamesInFileHistory.Checked;
            AppSettings.Instance.ShowGitStatusInBrowseToolbar = chkShowGitStatusInToolbar.Checked;
            AppSettings.Instance.SmtpServer = SmtpServer.Text;
            int port;
            if (int.TryParse(SmtpServerPort.Text, out port))
                AppSettings.Instance.SmtpPort = port;
            AppSettings.Instance.SmtpUseSsl = chkUseSSL.Checked;
            AppSettings.Instance.CloseProcessDialog = chkCloseProcessDialog.Checked;
            AppSettings.Instance.ShowGitCommandLine = chkShowGitCommandLine.Checked;
            AppSettings.Instance.UseFastChecks = chkUseFastChecks.Checked;
            AppSettings.Instance.MaxRevisionGraphCommits = (int)_NO_TRANSLATE_MaxCommits.Value;
            AppSettings.Instance.RevisionGridQuickSearchTimeout = (int)RevisionGridQuickSearchTimeout.Value;
            AppSettings.Instance.RevisionGraphShowWorkingDirChanges = chkShowCurrentChangesInRevisionGraph.Checked;
            AppSettings.Instance.ShowStashCount = chkShowStashCountInBrowseWindow.Checked;
            AppSettings.Instance.DefaultCloneDestinationPath = cbDefaultCloneDestination.Text;
            AppSettings.Instance.FollowRenamesInFileHistoryExactOnly = chkFollowRenamesInFileHistoryExact.Checked;
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
