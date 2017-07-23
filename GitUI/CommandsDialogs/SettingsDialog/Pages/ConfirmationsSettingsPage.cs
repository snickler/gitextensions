using System.Windows.Forms;
using GitCommands;
using GitCommands.Settings;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class ConfirmationsSettingsPage : SettingsPageWithHeader
    {
        public ConfirmationsSettingsPage()
        {
            InitializeComponent();
            Text = "Confirmations";
            Translate();
        }

        protected override void SettingsToPage()
        {
            chkAmend.Checked = AppSettings.Current.DontConfirmAmend;
            chkCommitIfNoBranch.Checked = AppSettings.Current.DontConfirmCommitIfNoBranch;
            chkAutoPopStashAfterPull.CheckState = AppSettings.Current.AutoPopStashAfterPull.ToCheckboxState();
            chkAutoPopStashAfterCheckout.CheckState = AppSettings.Current.AutoPopStashAfterCheckoutBranch.ToCheckboxState();
            chkPushNewBranch.Checked = AppSettings.Current.DontConfirmPushNewBranch;
            chkAddTrackingRef.Checked = AppSettings.Current.DontConfirmAddTrackingRef;
            chkUpdateModules.CheckState = AppSettings.Current.UpdateSubmodulesOnCheckout.ToCheckboxState();
            chkResolveConflicts.Checked = AppSettings.Current.DontConfirmResolveConflicts;
            chkCommitAfterConflictsResolved.Checked = AppSettings.Current.DontConfirmCommitAfterConflictsResolved;
            chkSecondAbortConfirmation.Checked = AppSettings.Current.DontConfirmSecondAbortConfirmation;
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.DontConfirmAmend = chkAmend.Checked;
            AppSettings.Current.DontConfirmCommitIfNoBranch = chkCommitIfNoBranch.Checked;
            AppSettings.Current.AutoPopStashAfterPull = chkAutoPopStashAfterPull.CheckState.ToBoolean();
            AppSettings.Current.AutoPopStashAfterCheckoutBranch = chkAutoPopStashAfterCheckout.CheckState.ToBoolean();
            AppSettings.Current.DontConfirmPushNewBranch = chkPushNewBranch.Checked;
            AppSettings.Current.DontConfirmAddTrackingRef = chkAddTrackingRef.Checked;
            AppSettings.Current.UpdateSubmodulesOnCheckout = chkUpdateModules.CheckState.ToBoolean();
            AppSettings.Current.DontConfirmResolveConflicts = chkResolveConflicts.Checked;
            AppSettings.Current.DontConfirmCommitAfterConflictsResolved = chkCommitAfterConflictsResolved.Checked;
            AppSettings.Current.DontConfirmSecondAbortConfirmation = chkSecondAbortConfirmation.Checked;
        }

        public static SettingsPageReference GetPageReference()
        {
            return new SettingsPageReferenceByType(typeof(ConfirmationsSettingsPage));
        }
    }

    public static class CheckboxExtension
    {
        public static CheckState ToCheckboxState(this bool booleanValue)
        {
            return booleanValue.ToCheckboxState();
        }

        public static CheckState ToCheckboxState(this bool? booleanValue)
        {
            if (!booleanValue.HasValue)
                return CheckState.Indeterminate;
            return booleanValue == true ? CheckState.Checked : CheckState.Unchecked;
        }

        public static bool? ToBoolean(this CheckState state)
        {
            if (state == CheckState.Indeterminate)
                return null;
            return state == CheckState.Checked;
        }
    }
}
