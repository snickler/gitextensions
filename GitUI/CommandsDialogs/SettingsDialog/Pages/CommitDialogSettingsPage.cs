using GitCommands;
using GitCommands.Settings;

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
            chkShowErrorsWhenStagingFiles.Checked = AppSettings.Current.ShowErrorsWhenStagingFiles;
            chkAddNewlineToCommitMessageWhenMissing.Checked = AppSettings.Current.AddNewlineToCommitMessageWhenMissing;
            chkWriteCommitMessageInCommitWindow.Checked = AppSettings.Current.UseFormCommitMessage;
            _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value = AppSettings.Current.CommitDialogNumberOfPreviousMessages;
            chkShowCommitAndPush.Checked = AppSettings.Current.ShowCommitAndPush;
            chkShowResetUnstagedChanges.Checked = AppSettings.Current.ShowResetUnstagedChanges;
            chkShowResetAllChanges.Checked = AppSettings.Current.ShowResetAllChanges;
            chkAutocomplete.Checked = AppSettings.Current.ProvideAutocompletion;
            cbRememberAmendCommitState.Checked = AppSettings.Current.RememberAmendCommitState;
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.ShowErrorsWhenStagingFiles = chkShowErrorsWhenStagingFiles.Checked;
            AppSettings.Current.AddNewlineToCommitMessageWhenMissing = chkAddNewlineToCommitMessageWhenMissing.Checked;
            AppSettings.Current.UseFormCommitMessage = chkWriteCommitMessageInCommitWindow.Checked;
            AppSettings.Current.CommitDialogNumberOfPreviousMessages = (int) _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value;
            AppSettings.Current.ShowCommitAndPush = chkShowCommitAndPush.Checked;
            AppSettings.Current.ShowResetUnstagedChanges = chkShowResetUnstagedChanges.Checked;
            AppSettings.Current.ShowResetAllChanges = chkShowResetAllChanges.Checked;
            AppSettings.Current.ProvideAutocompletion = chkAutocomplete.Checked;
            AppSettings.Current.RememberAmendCommitState = cbRememberAmendCommitState.Checked;
        }
    }
}
