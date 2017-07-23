using GitCommands;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class DiffViewerSettingsPage : SettingsPageWithHeader
    {
        public DiffViewerSettingsPage()
        {
            InitializeComponent();
            Text = "Diff Viewer";
            Translate();
        }

        protected override void SettingsToPage()
        {
            chkRememberIgnoreWhiteSpacePreference.Checked = AppSettings.Instance.RememberIgnoreWhiteSpacePreference;
            chkOmitUninterestingDiff.Checked = AppSettings.Instance.OmitUninterestingDiff;
            chkRememberShowEntireFilePreference.Checked = AppSettings.Instance.RememberShowEntireFilePreference;
            chkRememberShowNonPrintingCharsPreference.Checked = AppSettings.Instance.RememberShowNonPrintingCharsPreference;
            chkRememberNumberOfContextLines.Checked = AppSettings.Instance.RememberNumberOfContextLines;
            chkOpenSubmoduleDiffInSeparateWindow.Checked = AppSettings.Instance.OpenSubmoduleDiffInSeparateWindow;
            chkShowDiffForAllParents.Checked = AppSettings.Instance.ShowDiffForAllParents;
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.RememberIgnoreWhiteSpacePreference = chkRememberIgnoreWhiteSpacePreference.Checked;
            AppSettings.Instance.OmitUninterestingDiff = chkOmitUninterestingDiff.Checked;
            AppSettings.Instance.RememberShowEntireFilePreference = chkRememberShowEntireFilePreference.Checked;
            AppSettings.Instance.RememberShowNonPrintingCharsPreference = chkRememberShowNonPrintingCharsPreference.Checked;
            AppSettings.Instance.RememberNumberOfContextLines = chkRememberNumberOfContextLines.Checked;
            AppSettings.Instance.OpenSubmoduleDiffInSeparateWindow = chkOpenSubmoduleDiffInSeparateWindow.Checked;
            AppSettings.Instance.ShowDiffForAllParents = chkShowDiffForAllParents.Checked;
        }

        public static SettingsPageReference GetPageReference()
        {
            return new SettingsPageReferenceByType(typeof(DiffViewerSettingsPage));
        }
    }
}
