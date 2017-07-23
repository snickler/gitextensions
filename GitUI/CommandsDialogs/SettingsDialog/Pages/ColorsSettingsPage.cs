using System;
using System.Drawing;
using System.Windows.Forms;
using GitCommands;
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
            MulticolorBranches.Checked = AppSettings.Instance.MulticolorBranches;
            MulticolorBranches_CheckedChanged(null, null);

            DrawNonRelativesGray.Checked = AppSettings.Instance.RevisionGraphDrawNonRelativesGray;
            DrawNonRelativesTextGray.Checked = AppSettings.Instance.RevisionGraphDrawNonRelativesTextGray;
            BranchBorders.Checked = AppSettings.Instance.BranchBorders;
            StripedBanchChange.Checked = AppSettings.Instance.StripedBranchChange;
            HighlightAuthoredRevisions.Checked = AppSettings.Instance.HighlightAuthoredRevisions;

            _NO_TRANSLATE_ColorGraphLabel.BackColor = AppSettings.Instance.GraphColor;
            _NO_TRANSLATE_ColorGraphLabel.Text = AppSettings.Instance.GraphColor.Name;
            _NO_TRANSLATE_ColorGraphLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorGraphLabel.BackColor);
            _NO_TRANSLATE_ColorTagLabel.BackColor = AppSettings.Instance.TagColor;
            _NO_TRANSLATE_ColorTagLabel.Text = AppSettings.Instance.TagColor.Name;
            _NO_TRANSLATE_ColorTagLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorTagLabel.BackColor);
            _NO_TRANSLATE_ColorBranchLabel.BackColor = AppSettings.Instance.BranchColor;
            _NO_TRANSLATE_ColorBranchLabel.Text = AppSettings.Instance.BranchColor.Name;
            _NO_TRANSLATE_ColorBranchLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorBranchLabel.BackColor);
            _NO_TRANSLATE_ColorRemoteBranchLabel.BackColor = AppSettings.Instance.RemoteBranchColor;
            _NO_TRANSLATE_ColorRemoteBranchLabel.Text = AppSettings.Instance.RemoteBranchColor.Name;
            _NO_TRANSLATE_ColorRemoteBranchLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemoteBranchLabel.BackColor);
            _NO_TRANSLATE_ColorOtherLabel.BackColor = AppSettings.Instance.OtherTagColor;
            _NO_TRANSLATE_ColorOtherLabel.Text = AppSettings.Instance.OtherTagColor.Name;
            _NO_TRANSLATE_ColorOtherLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorOtherLabel.BackColor);

            _NO_TRANSLATE_ColorAddedLineLabel.BackColor = AppSettings.Instance.DiffAddedColor;
            _NO_TRANSLATE_ColorAddedLineLabel.Text = AppSettings.Instance.DiffAddedColor.Name;
            _NO_TRANSLATE_ColorAddedLineLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAddedLineLabel.BackColor);
            _NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor = AppSettings.Instance.DiffAddedExtraColor;
            _NO_TRANSLATE_ColorAddedLineDiffLabel.Text = AppSettings.Instance.DiffAddedExtraColor.Name;
            _NO_TRANSLATE_ColorAddedLineDiffLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor);

            _NO_TRANSLATE_ColorRemovedLine.BackColor = AppSettings.Instance.DiffRemovedColor;
            _NO_TRANSLATE_ColorRemovedLine.Text = AppSettings.Instance.DiffRemovedColor.Name;
            _NO_TRANSLATE_ColorRemovedLine.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemovedLine.BackColor);
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor = AppSettings.Instance.DiffRemovedExtraColor;
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.Text = AppSettings.Instance.DiffRemovedExtraColor.Name;
            _NO_TRANSLATE_ColorRemovedLineDiffLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor);
            _NO_TRANSLATE_ColorSectionLabel.BackColor = AppSettings.Instance.DiffSectionColor;
            _NO_TRANSLATE_ColorSectionLabel.Text = AppSettings.Instance.DiffSectionColor.Name;
            _NO_TRANSLATE_ColorSectionLabel.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorSectionLabel.BackColor);

            _NO_TRANSLATE_ColorAuthoredRevisions.BackColor = AppSettings.Instance.AuthoredRevisionsColor;
            _NO_TRANSLATE_ColorAuthoredRevisions.Text = AppSettings.Instance.AuthoredRevisionsColor.Name;
            _NO_TRANSLATE_ColorAuthoredRevisions.ForeColor =
                ColorHelper.GetForeColorForBackColor(_NO_TRANSLATE_ColorAuthoredRevisions.BackColor);

            string iconColor = AppSettings.Instance.IconColor.ToLower();
            DefaultIcon.Checked = iconColor == "default";
            BlueIcon.Checked = iconColor == "blue";
            GreenIcon.Checked = iconColor == "green";
            PurpleIcon.Checked = iconColor == "purple";
            RedIcon.Checked = iconColor == "red";
            YellowIcon.Checked = iconColor == "yellow";
            RandomIcon.Checked = iconColor == "random";

            IconStyle.SelectedIndex = GetIconStyleIndex(AppSettings.Instance.IconStyle);

            ShowIconPreview();
        }

        protected override void PageToSettings()
        {
            AppSettings.Instance.MulticolorBranches = MulticolorBranches.Checked;
            AppSettings.Instance.RevisionGraphDrawNonRelativesGray = DrawNonRelativesGray.Checked;
            AppSettings.Instance.RevisionGraphDrawNonRelativesTextGray = DrawNonRelativesTextGray.Checked;
            AppSettings.Instance.BranchBorders = BranchBorders.Checked;
            AppSettings.Instance.StripedBranchChange = StripedBanchChange.Checked;
            AppSettings.Instance.HighlightAuthoredRevisions = HighlightAuthoredRevisions.Checked;

            AppSettings.Instance.GraphColor = _NO_TRANSLATE_ColorGraphLabel.BackColor;
            AppSettings.Instance.TagColor = _NO_TRANSLATE_ColorTagLabel.BackColor;
            AppSettings.Instance.BranchColor = _NO_TRANSLATE_ColorBranchLabel.BackColor;
            AppSettings.Instance.RemoteBranchColor = _NO_TRANSLATE_ColorRemoteBranchLabel.BackColor;
            AppSettings.Instance.OtherTagColor = _NO_TRANSLATE_ColorOtherLabel.BackColor;
            AppSettings.Instance.AuthoredRevisionsColor = _NO_TRANSLATE_ColorAuthoredRevisions.BackColor;

            AppSettings.Instance.DiffAddedColor = _NO_TRANSLATE_ColorAddedLineLabel.BackColor;
            AppSettings.Instance.DiffRemovedColor = _NO_TRANSLATE_ColorRemovedLine.BackColor;
            AppSettings.Instance.DiffAddedExtraColor = _NO_TRANSLATE_ColorAddedLineDiffLabel.BackColor;
            AppSettings.Instance.DiffRemovedExtraColor = _NO_TRANSLATE_ColorRemovedLineDiffLabel.BackColor;
            AppSettings.Instance.DiffSectionColor = _NO_TRANSLATE_ColorSectionLabel.BackColor;

            AppSettings.Instance.IconColor = GetSelectedApplicationIconColor();
            AppSettings.Instance.IconStyle = GetIconStyleString(IconStyle.SelectedIndex);
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
