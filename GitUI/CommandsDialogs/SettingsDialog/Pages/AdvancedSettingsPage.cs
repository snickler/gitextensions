using GitCommands;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class AdvancedSettingsPage : SettingsPageWithHeader
    {
        public AdvancedSettingsPage()
        {
            InitializeComponent();
            Text = "Advanced";
            Translate();

            var autoNormaliseSymbols = new[] {
                new { Key =  "_", Value = "_" },
                new { Key =  "-", Value = "-" },
                new { Key =  "(none)", Value = "" },
            };
            cboAutoNormaliseSymbol.DataSource = autoNormaliseSymbols;
            cboAutoNormaliseSymbol.SelectedIndex = 0;
        }

        protected override void SettingsToPage()
        {
            chkAlwaysShowCheckoutDlg.Checked = AppSettings.Instance.AlwaysShowCheckoutBranchDlg;
            chkUseLocalChangesAction.Checked = AppSettings.Instance.UseDefaultCheckoutBranchAction;
            chkDontSHowHelpImages.Checked = AppSettings.Instance.DontShowHelpImages;
            chkAlwaysShowAdvOpt.Checked = AppSettings.Instance.AlwaysShowAdvOpt;
            chkCheckForRCVersions.Checked = AppSettings.Instance.CheckForReleaseCandidates;
            chkConsoleEmulator.Checked = AppSettings.Instance.UseConsoleEmulatorForCommands;
            chkAutoNormaliseBranchName.Checked = AppSettings.Instance.AutoNormaliseBranchName;
            cboAutoNormaliseSymbol.Enabled = chkAutoNormaliseBranchName.Checked;
            cboAutoNormaliseSymbol.SelectedValue = AppSettings.Instance.AutoNormaliseSymbol;
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.AlwaysShowCheckoutBranchDlg = chkAlwaysShowCheckoutDlg.Checked;
            AppSettings.Instance.UseDefaultCheckoutBranchAction = chkUseLocalChangesAction.Checked;
            AppSettings.Instance.DontShowHelpImages = chkDontSHowHelpImages.Checked;
            AppSettings.Instance.AlwaysShowAdvOpt = chkAlwaysShowAdvOpt.Checked;
            AppSettings.Instance.CheckForReleaseCandidates = chkCheckForRCVersions.Checked;
            AppSettings.Instance.UseConsoleEmulatorForCommands = chkConsoleEmulator.Checked;
            AppSettings.Instance.AutoNormaliseBranchName = chkAutoNormaliseBranchName.Checked;
            AppSettings.Instance.AutoNormaliseSymbol = (string)cboAutoNormaliseSymbol.SelectedValue;
        }

        public static SettingsPageReference GetPageReference()
        {
            return new SettingsPageReferenceByType(typeof(AdvancedSettingsPage));
        }


        private void chkAutoNormaliseBranchName_CheckedChanged(object sender, System.EventArgs e)
        {
            cboAutoNormaliseSymbol.Enabled = chkAutoNormaliseBranchName.Checked;
        }
    }
}
