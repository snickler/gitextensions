using GitCommands;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class CommitDialogSettingsPage : SettingsPageWithHeader
    {
        public CommitDialogSettingsPage()
        {
            InitializeComponent();
            Text = "Commit dialog";
            Translate();
        }

        protected override void SettingsToPage()
        {
            chkShowErrorsWhenStagingFiles.Checked = AppSettings.Instance.ShowErrorsWhenStagingFiles;
            chkAddNewlineToCommitMessageWhenMissing.Checked = AppSettings.Instance.AddNewlineToCommitMessageWhenMissing;
            chkWriteCommitMessageInCommitWindow.Checked = AppSettings.Instance.UseFormCommitMessage;
            _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value = AppSettings.Instance.CommitDialogNumberOfPreviousMessages;
            chkShowCommitAndPush.Checked = AppSettings.Instance.ShowCommitAndPush;
            chkShowResetUnstagedChanges.Checked = AppSettings.Instance.ShowResetUnstagedChanges;
            chkShowResetAllChanges.Checked = AppSettings.Instance.ShowResetAllChanges;
            chkAutocomplete.Checked = AppSettings.Instance.ProvideAutocompletion;
            cbRememberAmendCommitState.Checked = AppSettings.Instance.RememberAmendCommitState;
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.ShowErrorsWhenStagingFiles = chkShowErrorsWhenStagingFiles.Checked;
            AppSettings.Instance.AddNewlineToCommitMessageWhenMissing = chkAddNewlineToCommitMessageWhenMissing.Checked;
            AppSettings.Instance.UseFormCommitMessage = chkWriteCommitMessageInCommitWindow.Checked;
            AppSettings.Instance.CommitDialogNumberOfPreviousMessages = (int) _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value;
            AppSettings.Instance.ShowCommitAndPush = chkShowCommitAndPush.Checked;
            AppSettings.Instance.ShowResetUnstagedChanges = chkShowResetUnstagedChanges.Checked;
            AppSettings.Instance.ShowResetAllChanges = chkShowResetAllChanges.Checked;
            AppSettings.Instance.ProvideAutocompletion = chkAutocomplete.Checked;
            AppSettings.Instance.RememberAmendCommitState = cbRememberAmendCommitState.Checked;
        }
    }
}
