using System;
using System.Drawing;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Settings;
using GitUI.Editor;
using ResourceManager;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class ColorsSettingsPage : SettingsPageWithHeader
    {
        public ColorsSettingsPage()
        {
            InitializeComponent();
            Text = "Colors";
            Translate();
        }

        protected override string GetCommaSeparatedKeywordList()
        {
            return "color,graph,diff,icon";
        }

        private int GetIconStyleIndex(string text)
        {
            switch (text.ToLowerInvariant())
            {
                case "large":
                    return 1;
                case "small":
                    return 2;
                case "cow":
                    return 3;
                default:
                    return 0;
            }
        }

        private string GetIconStyleString(int index)
        {
            switch (index)
            {
                case 1:
                    return "large";
                case 2:
                    return "small";
                case 3:
                    return "cow";
                default:
                    return "default";
            }
        }

        protected override void SettingsToPage()
        {
            MulticolorBranches.Checked = AppSettings.Current.MulticolorBranches;
            MulticolorBranches_CheckedChanged(null, null);

            DrawNonRelativesGray.Checked = AppSettings.Current.RevisionGraphDrawNonRelativesGray;
            DrawNonRelativesTextGray.Checked = AppSettings.Current.RevisionGraphDrawNonRelativesTextGray;
            BranchBorders.Checked = AppSettings.Current.BranchBorders;
            StripedBanchChange.Checked = AppSettings.Current.StripedBranchChange;
            HighlightAuthoredRevisions.Checked = AppSettings.Current.HighlightAuthoredRevisions;

            _NO_TRANSLATE_ColorGraphLabel.BackColor = AppSettings.Current.GraphColor;
            _NO_TRANSLATE_ColorGraphLabel.Text = AppSettings.Current.GraphColor.Name;
            _NO_TRANSLATE_ColorGraphLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorGraphLabel.BackColor);
            _NO_TRANSLATE_ColorTagLabel.BackColor = AppSettings.Current.TagColor;
            _NO_TRANSLATE_ColorTagLabel.Text = AppSettings.Current.TagColor.Name;
            _NO_TRANSLATE_ColorTagLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorTagLabel.BackColor);
            _NO_TRANSLATE_ColorBranchLabel.BackColor = AppSettings.Current.BranchColor;
            _NO_TRANSLATE_ColorBranchLabel.Text = AppSettings.Current.BranchColor.Name;
            _NO_TRANSLATE_ColorBranchLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorBranchLabel.BackColor);
            _NO_TRANSLATE_ColorRemoteBranchLabel.BackColor = AppSettings.Current.RemoteBranchColor;
            _NO_TRANSLATE_ColorRemoteBranchLabel.Text = AppSettings.Current.RemoteBranchColor.Name;
            _NO_TRANSLATE_ColorRemoteBranchLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemoteBranchLabel.BackColor);
            _NO_TRANSLATE_ColorOtherLabel.BackColor = AppSettings.Current.OtherTagColor;
            _NO_TRANSLATE_ColorOtherLabel.Text = AppSettings.Current.OtherTagColor.Name;
            _NO_TRANSLATE_ColorOtherLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorOtherLabel.BackColor);

            _NO_TRANSLATE_ColorAddedLineLabel.BackColor = AppSettings.Current.DiffAddedColor;
            _NO_TRANSLATE_ColorAddedLineLabel.Text = AppSettings.Current.DiffAddedColor.Name;
            _NO_TRANSLATE_ColorAddedLineLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAddedLineLabel.BackColor);
            _NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor = AppSettings.Current.DiffAddedExtraColor;
            _NO_TRANSLATE_ColorAddedLineDiffLabel.Text = AppSettings.Current.DiffAddedExtraColor.Name;
            _NO_TRANSLATE_ColorAddedLineDiffLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor);

            _NO_TRANSLATE_ColorRemovedLine.BackColor = AppSettings.Current.DiffRemovedColor;
            _NO_TRANSLATE_ColorRemovedLine.Text = AppSettings.Current.DiffRemovedColor.Name;
            _NO_TRANSLATE_ColorRemovedLine.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemovedLine.BackColor);
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor = AppSettings.Current.DiffRemovedExtraColor;
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.Text = AppSettings.Current.DiffRemovedExtraColor.Name;
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor);
            _NO_TRANSLATE_ColorSectionLabel.BackColor = AppSettings.Current.DiffSectionColor;
            _NO_TRANSLATE_ColorSectionLabel.Text = AppSettings.Current.DiffSectionColor.Name;
            _NO_TRANSLATE_ColorSectionLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorSectionLabel.BackColor);

            _NO_TRANSLATE_ColorAuthoredRevisions.BackColor = AppSettings.Current.AuthoredRevisionsColor;
            _NO_TRANSLATE_ColorAuthoredRevisions.Text = AppSettings.Current.AuthoredRevisionsColor.Name;
            _NO_TRANSLATE_ColorAuthoredRevisions.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAuthoredRevisions.BackColor);

            string iconColor = AppSettings.Current.IconColor.ToLower();
            DefaultIcon.Checked = iconColor == "default";
            BlueIcon.Checked = iconColor == "blue";
            GreenIcon.Checked = iconColor == "green";
            PurpleIcon.Checked = iconColor == "purple";
            RedIcon.Checked = iconColor == "red";
            YellowIcon.Checked = iconColor == "yellow";
            RandomIcon.Checked = iconColor == "random";

            IconStyle.SelectedIndex = GetIconStyleIndex(AppSettings.Current.IconStyle);

            ShowIconPreview();
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.MulticolorBranches = MulticolorBranches.Checked;
            AppSettings.Current.RevisionGraphDrawNonRelativesGray = DrawNonRelativesGray.Checked;
            AppSettings.Current.RevisionGraphDrawNonRelativesTextGray = DrawNonRelativesTextGray.Checked;
            AppSettings.Current.BranchBorders = BranchBorders.Checked;
            AppSettings.Current.StripedBranchChange = StripedBanchChange.Checked;
            AppSettings.Current.HighlightAuthoredRevisions = HighlightAuthoredRevisions.Checked;

            AppSettings.Current.GraphColor = _NO_TRANSLATE_ColorGraphLabel.BackColor;
            AppSettings.Current.TagColor = _NO_TRANSLATE_ColorTagLabel.BackColor;
            AppSettings.Current.BranchColor = _NO_TRANSLATE_ColorBranchLabel.BackColor;
            AppSettings.Current.RemoteBranchColor = _NO_TRANSLATE_ColorRemoteBranchLabel.BackColor;
            AppSettings.Current.OtherTagColor = _NO_TRANSLATE_ColorOtherLabel.BackColor;
            AppSettings.Current.AuthoredRevisionsColor = _NO_TRANSLATE_ColorAuthoredRevisions.BackColor;

            AppSettings.Current.DiffAddedColor = _NO_TRANSLATE_ColorAddedLineLabel.BackColor;
            AppSettings.Current.DiffRemovedColor = _NO_TRANSLATE_ColorRemovedLine.BackColor;
            AppSettings.Current.DiffAddedExtraColor = _NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor;
            AppSettings.Current.DiffRemovedExtraColor = _NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor;
            AppSettings.Current.DiffSectionColor = _NO_TRANSLATE_ColorSectionLabel.BackColor;

            AppSettings.Current.IconColor = GetSelectedApplicationIconColor();
            AppSettings.Current.IconStyle = GetIconStyleString(IconStyle.SelectedIndex);
        }

        private string GetSelectedApplicationIconColor()
        {
            if (BlueIcon.Checked)
                return "blue";
            if (LightblueIcon.Checked)
                return "lightblue";
            if (GreenIcon.Checked)
                return "green";
            if (PurpleIcon.Checked)
                return "purple";
            if (RedIcon.Checked)
                return "red";
            if (YellowIcon.Checked)
                return "yellow";
            if (RandomIcon.Checked)
                return "random";
            return "default";
        }

        private void IconStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoadingSettings)
                return;

            ShowIconPreview();
        }

        private void IconColor_CheckedChanged(object sender, EventArgs e)
        {
            if (IsLoadingSettings)
                return;

            ShowIconPreview();
        }

        private void MulticolorBranches_CheckedChanged(object sender, EventArgs e)
        {
            if (MulticolorBranches.Checked)
            {
                _NO_TRANSLATE_ColorGraphLabel.Visible = false;
                StripedBanchChange.Enabled = true;
            }
            else
            {
                _NO_TRANSLATE_ColorGraphLabel.Visible = true;
                StripedBanchChange.Enabled = false;
            }
        }

        private void ShowIconPreview()
        {
            Icon icon;
            switch (IconStyle.SelectedIndex)
            {
                case 0:
                    IconPreview.Image = (new Icon(GitExtensionsForm.GetApplicationIcon("Large", GetSelectedApplicationIconColor()), 32, 32)).ToBitmap();
                    IconPreviewSmall.Image = (new Icon(GitExtensionsForm.GetApplicationIcon("Small", GetSelectedApplicationIconColor()), 16, 16)).ToBitmap();
                    break;
                case 1:
                    icon = GitExtensionsForm.GetApplicationIcon("Small", GetSelectedApplicationIconColor());
                    IconPreview.Image = (new Icon(icon, 32, 32)).ToBitmap();
                    IconPreviewSmall.Image = (new Icon(icon, 16, 16)).ToBitmap();
                    break;
                case 2:
                    icon = GitExtensionsForm.GetApplicationIcon("Large", GetSelectedApplicationIconColor());
                    IconPreview.Image = (new Icon(icon, 32, 32)).ToBitmap();
                    IconPreviewSmall.Image = (new Icon(icon, 16, 16)).ToBitmap();
                    break;
                case 3:
                    icon = GitExtensionsForm.GetApplicationIcon("Cow", GetSelectedApplicationIconColor());
                    IconPreview.Image = (new Icon(icon, 32, 32)).ToBitmap();
                    IconPreviewSmall.Image = (new Icon(icon, 16, 16)).ToBitmap();
                    break;
            }
        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {
            PickColor((Label) sender);
        }

        private void PickColor(Control targetColorControl)
        {
            using (var colorDialog = new ColorDialog {Color = targetColorControl.BackColor})
            {
                colorDialog.ShowDialog(this);
                targetColorControl.BackColor = colorDialog.Color;
                targetColorControl.Text = colorDialog.Color.Name;
            }

            targetColorControl.ForeColor =
                ColorHelper.GetForeColorForBackColor(targetColorControl.BackColor);
        }
    }
}
