using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Settings;
using Gravatar;
using ResourceManager;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class AppearanceSettingsPage : SettingsPageWithHeader
    {
        private readonly IGitExtensionsPathProvider _gitExtensionsPathProvider = new GitExtensionsPathProvider();
        private readonly TranslationString _noDictFile =
            new TranslationString("None");
        private readonly TranslationString _noDictFilesFound =
            new TranslationString("No dictionary files found in: {0}");

        private Font _diffFont;
        private Font _applicationFont;
        private Font commitFont;

        public AppearanceSettingsPage()
        {
            InitializeComponent();
            Text = "Appearance";
            Translate();

            NoImageService.Items.AddRange(GravatarService.DynamicServices.Cast<object>().ToArray());
        }

        protected override string GetCommaSeparatedKeywordList()
        {
            return "graph,visual studio,author,image,font,lang,language,spell,spelling";
        }

        private int GetTruncatePathMethodIndex(string text)
        {
            switch (text.ToLowerInvariant())
            {
                case "compact":
                    return 1;
                case "trimstart":
                    return 2;
                case "filenameonly":
                    return 3;
                default:
                    return 0;
            }
        }

        private string GetTruncatePathMethodString(int index)
        {
            switch (index)
            {
                case 1:
                    return "compact";
                case 2:
                    return "trimstart";
                case 3:
                    return "fileNameOnly";
                default:
                    return "none";
            }
        }

        protected override void SettingsToPage()
        {
            chkEnableAutoScale.Checked = AppSettings.Current.EnableAutoScale;

            chkShowCurrentBranchInVisualStudio.Checked = AppSettings.Current.ShowCurrentBranchInVisualStudio;
            _NO_TRANSLATE_DaysToCacheImages.Value = AppSettings.Current.AuthorImageCacheDays;
            if (AppSettings.Current.AuthorImageSize <= 120)
                AuthorImageSize.SelectedIndex = 0;
            else if (AppSettings.Current.AuthorImageSize <= 200)
                AuthorImageSize.SelectedIndex = 1;
            else if (AppSettings.Current.AuthorImageSize <= 280)
                AuthorImageSize.SelectedIndex = 2;
            else
                AuthorImageSize.SelectedIndex = 3;
            ShowAuthorGravatar.Checked = AppSettings.Current.ShowAuthorGravatar;
            NoImageService.Text = AppSettings.Current.GravatarFallbackService;

            Language.Items.Clear();
            Language.Items.Add("English");
            Language.Items.AddRange(Translator.GetAllTranslations());
            Language.Text = AppSettings.Current.Translation;

            truncatePathMethod.SelectedIndex = GetTruncatePathMethodIndex(AppSettings.Current.TruncatePathMethod);

            Dictionary.Items.Clear();
            Dictionary.Items.Add(_noDictFile.Text);
            if (AppSettings.Current.Dictionary.Equals("none", StringComparison.InvariantCultureIgnoreCase))
                Dictionary.SelectedIndex = 0;
            else
                Dictionary.Text = AppSettings.Current.Dictionary;

            chkShowRelativeDate.Checked = AppSettings.Current.RelativeDate;

            SetCurrentApplicationFont(AppSettings.Current.Font);
            SetCurrentDiffFont(AppSettings.Current.DiffFont);
            SetCurrentCommitFont(AppSettings.Current.CommitFont);
        }

        protected override void PageToSettings()
        {
            AppSettings.Current.EnableAutoScale = chkEnableAutoScale.Checked;
            AppSettings.Current.TruncatePathMethod = GetTruncatePathMethodString(truncatePathMethod.SelectedIndex);
            AppSettings.Current.ShowCurrentBranchInVisualStudio = chkShowCurrentBranchInVisualStudio.Checked;

            int authorImageSize;
            switch (AuthorImageSize.SelectedIndex)
            {
                case 1:
                    authorImageSize = 160;
                    break;
                case 2:
                    authorImageSize = 240;
                    break;
                case 3:
                    authorImageSize = 320;
                    break;
                default:
                    authorImageSize = 80;
                    break;
            }
            if (authorImageSize != AppSettings.Current.AuthorImageSize)
            {
                AppSettings.Current.AuthorImageSize = authorImageSize;
                GravatarService.ClearImageCache();
            }

            AppSettings.Current.Translation = Language.Text;
            Strings.Reinit();

            AppSettings.Current.AuthorImageCacheDays = (int)_NO_TRANSLATE_DaysToCacheImages.Value;

            AppSettings.Current.ShowAuthorGravatar = ShowAuthorGravatar.Checked;
            AppSettings.Current.GravatarFallbackService = NoImageService.Text;

            AppSettings.Current.RelativeDate = chkShowRelativeDate.Checked;

            AppSettings.Current.Dictionary = Dictionary.SelectedIndex == 0 ? "none" : Dictionary.Text;

            AppSettings.Current.DiffFont = _diffFont;
            AppSettings.Current.Font = _applicationFont;
            AppSettings.Current.CommitFont = commitFont;
        }

        private void Dictionary_DropDown(object sender, EventArgs e)
        {
            try
            {
                Dictionary.Items.Clear();
                Dictionary.Items.Add(_noDictFile.Text);
                foreach (
                    string fileName in
                        Directory.GetFiles(_gitExtensionsPathProvider.GetDictionaryDir(), "*.dic", SearchOption.TopDirectoryOnly))
                {
                    var file = new FileInfo(fileName);
                    Dictionary.Items.Add(file.Name.Replace(".dic", ""));
                }
            }
            catch
            {
                MessageBox.Show(this, String.Format(_noDictFilesFound.Text, _gitExtensionsPathProvider.GetDictionaryDir()));
            }
        }

        private void diffFontChangeButton_Click(object sender, EventArgs e)
        {
            diffFontDialog.Font = _diffFont;
            DialogResult result = diffFontDialog.ShowDialog(this);

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                SetCurrentDiffFont(diffFontDialog.Font);
            }
        }

        private void applicationFontChangeButton_Click(object sender, EventArgs e)
        {
            applicationDialog.Font = _applicationFont;
            DialogResult result = applicationDialog.ShowDialog(this);

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                SetCurrentApplicationFont(applicationDialog.Font);
            }
        }

        private void commitFontChangeButton_Click(object sender, EventArgs e)
        {
            commitFontDialog.Font = commitFont;
            DialogResult result = commitFontDialog.ShowDialog(this);

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                SetCurrentCommitFont(commitFontDialog.Font);
            }
        }

        private void SetCurrentDiffFont(Font newFont)
        {
            this._diffFont = newFont;
            SetFontButtonText(newFont, diffFontChangeButton);
        }

        private void SetCurrentApplicationFont(Font newFont)
        {
            this._applicationFont = newFont;
            SetFontButtonText(newFont, applicationFontChangeButton);
        }

        private void SetCurrentCommitFont(Font newFont)
        {
            this.commitFont = newFont;
            SetFontButtonText(newFont, commitFontChangeButton);
        }

        private void SetFontButtonText(Font font, Button button)
        {
            button.Text = string.Format("{0}, {1}", font.FontFamily.Name, (int)(font.Size + 0.5f));
        }

        private void ClearImageCache_Click(object sender, EventArgs e)
        {
            GravatarService.ClearImageCache();
        }

        private void helpTranslate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TranslationApp.exe"));
        }

        private void downloadDictionary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/gitextensions/gitextensions/wiki/Spelling");
        }
    }
}
