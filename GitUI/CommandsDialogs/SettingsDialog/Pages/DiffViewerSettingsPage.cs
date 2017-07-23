using GitCommands;
using GitCommands.Settings;

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
            chkRememberIgnoreWhiteSpacePreference.Checked = AppSettings.Current.RememberIgnoreWhiteSpacePreference;
            chkOmitUninterestingDiff.Checked = AppSettings.Current.OmitUninterestingDiff;
            chkRememberShowEntireFilePreference.Checked = AppSettings.Current.RememberShowEntireFilePreference;
            chkRememberShowNonPrintingCharsPreference.Checked = AppSettings.Current.RememberShowNonPrintingCharsPreference;
            chkRememberNumberOfContextLines.Checked = AppSettings.Current.RememberNumberOfContextLines;
            chkOpenSubmoduleDiffInSeparateWindow.Checked = AppSettings.Current.OpenSubmoduleDiffInSeparateWindow;
            chkShowDiffForAllParents.Checked = AppSettings.Current.ShowDiffForAllParents;
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.RememberIgnoreWhiteSpacePreference = chkRememberIgnoreWhiteSpacePreference.Checked;
            AppSettings.Current.OmitUninterestingDiff = chkOmitUninterestingDiff.Checked;
            AppSettings.Current.RememberShowEntireFilePreference = chkRememberShowEntireFilePreference.Checked;
            AppSettings.Current.RememberShowNonPrintingCharsPreference = chkRememberShowNonPrintingCharsPreference.Checked;
            AppSettings.Current.RememberNumberOfContextLines = chkRememberNumberOfContextLines.Checked;
            AppSettings.Current.OpenSubmoduleDiffInSeparateWindow = chkOpenSubmoduleDiffInSeparateWindow.Checked;
            AppSettings.Current.ShowDiffForAllParents = chkShowDiffForAllParents.Checked;
        }

        public static SettingsPageReference GetPageReference()
        {
            return new SettingsPageReferenceByType(typeof(DiffViewerSettingsPage));
        }
    }
}
