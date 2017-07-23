using System.Windows.Forms;
using GitCommands;

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
            chkAmend.Checked = AppSettings.Instance.DontConfirmAmend;
            chkCommitIfNoBranch.Checked = AppSettings.Instance.DontConfirmCommitIfNoBranch;
            chkAutoPopStashAfterPull.CheckState = AppSettings.Instance.AutoPopStashAfterPull.ToCheckboxState();
            chkAutoPopStashAfterCheckout.CheckState = AppSettings.Instance.AutoPopStashAfterCheckoutBranch.ToCheckboxState();
            chkPushNewBranch.Checked = AppSettings.Instance.DontConfirmPushNewBranch;
            chkAddTrackingRef.Checked = AppSettings.Instance.DontConfirmAddTrackingRef;
            chkUpdateModules.CheckState = AppSettings.Instance.UpdateSubmodulesOnCheckout.ToCheckboxState();
            chkResolveConflicts.Checked = AppSettings.Instance.DontConfirmResolveConflicts;
            chkCommitAfterConflictsResolved.Checked = AppSettings.Instance.DontConfirmCommitAfterConflictsResolved;
            chkSecondAbortConfirmation.Checked = AppSettings.Instance.DontConfirmSecondAbortConfirmation;
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.DontConfirmAmend = chkAmend.Checked;
            AppSettings.Instance.DontConfirmCommitIfNoBranch = chkCommitIfNoBranch.Checked;
            AppSettings.Instance.AutoPopStashAfterPull = chkAutoPopStashAfterPull.CheckState.ToBoolean();
            AppSettings.Instance.AutoPopStashAfterCheckoutBranch = chkAutoPopStashAfterCheckout.CheckState.ToBoolean();
            AppSettings.Instance.DontConfirmPushNewBranch = chkPushNewBranch.Checked;
            AppSettings.Instance.DontConfirmAddTrackingRef = chkAddTrackingRef.Checked;
            AppSettings.Instance.UpdateSubmodulesOnCheckout = chkUpdateModules.CheckState.ToBoolean();
            AppSettings.Instance.DontConfirmResolveConflicts = chkResolveConflicts.Checked;
            AppSettings.Instance.DontConfirmCommitAfterConflictsResolved = chkCommitAfterConflictsResolved.Checked;
            AppSettings.Instance.DontConfirmSecondAbortConfirmation = chkSecondAbortConfirmation.Checked;
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
