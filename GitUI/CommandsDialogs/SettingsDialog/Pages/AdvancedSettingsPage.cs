using GitCommands;
using GitCommands.Settings;

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
            chkAlwaysShowCheckoutDlg.Checked = AppSettings.Current.AlwaysShowCheckoutBranchDlg;
            chkUseLocalChangesAction.Checked = AppSettings.Current.UseDefaultCheckoutBranchAction;
            chkDontSHowHelpImages.Checked = AppSettings.Current.DontShowHelpImages;
            chkAlwaysShowAdvOpt.Checked = AppSettings.Current.AlwaysShowAdvOpt;
            chkCheckForRCVersions.Checked = AppSettings.Current.CheckForReleaseCandidates;
            chkConsoleEmulator.Checked = AppSettings.Current.UseConsoleEmulatorForCommands;
            chkAutoNormaliseBranchName.Checked = AppSettings.Current.AutoNormaliseBranchName;
            cboAutoNormaliseSymbol.Enabled = chkAutoNormaliseBranchName.Checked;
            cboAutoNormaliseSymbol.SelectedValue = AppSettings.Current.AutoNormaliseSymbol;
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.AlwaysShowCheckoutBranchDlg = chkAlwaysShowCheckoutDlg.Checked;
            AppSettings.Current.UseDefaultCheckoutBranchAction = chkUseLocalChangesAction.Checked;
            AppSettings.Current.DontShowHelpImages = chkDontSHowHelpImages.Checked;
            AppSettings.Current.AlwaysShowAdvOpt = chkAlwaysShowAdvOpt.Checked;
            AppSettings.Current.CheckForReleaseCandidates = chkCheckForRCVersions.Checked;
            AppSettings.Current.UseConsoleEmulatorForCommands = chkConsoleEmulator.Checked;
            AppSettings.Current.AutoNormaliseBranchName = chkAutoNormaliseBranchName.Checked;
            AppSettings.Current.AutoNormaliseSymbol = (string)cboAutoNormaliseSymbol.SelectedValue;
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
