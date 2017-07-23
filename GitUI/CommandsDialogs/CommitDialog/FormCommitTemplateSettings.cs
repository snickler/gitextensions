using System;
using GitCommands;
using ResourceManager;

namespace GitUI.CommandsDialogs.CommitDialog
{
    public partial class FormCommitTemplateSettings : GitExtensionsForm
    {
        private readonly TranslationString _emptyTemplate =
            new TranslationString("empty");

        private CommitTemplateItem[] _commitTemplates;

        private const int _maxCommitTemplates = 5;
        private const int _maxShownCharsForName = 15;
        private const int _maxUsedCharsForName = 80;

        public FormCommitTemplateSettings()
        {
            InitializeComponent();
            Translate();

            _NO_TRANSLATE_textBoxCommitTemplateName.MaxLength = _maxUsedCharsForName;

            LoadSettings();
        }

        private void LoadSettings()
        {
            _NO_TRANSLATE_numericMaxFirstLineLength.Value = AppSettings.Instance.CommitValidationMaxCntCharsFirstLine;
            _NO_TRANSLATE_numericMaxLineLength.Value = AppSettings.Instance.CommitValidationMaxCntCharsPerLine;
            checkBoxSecondLineEmpty.Checked = AppSettings.Instance.CommitValidationSecondLineMustBeEmpty;
            checkBoxUseIndent.Checked = AppSettings.Instance.CommitValidationIndentAfterFirstLine;
            _NO_TRANSLATE_textBoxCommitValidationRegex.Text = AppSettings.Instance.CommitValidationRegEx;

            _commitTemplates = CommitTemplateItem.LoadFromSettings();

            if (null == _commitTemplates)
            {
                _commitTemplates = new CommitTemplateItem[_maxCommitTemplates];
                for (int i = 0; i < _commitTemplates.Length; i++)
                    _commitTemplates[i] = new CommitTemplateItem();
            }

            _NO_TRANSLATE_comboBoxCommitTemplates.Items.Clear();

            for (int i = 0; i < _commitTemplates.Length; i++)
            {           
                _NO_TRANSLATE_comboBoxCommitTemplates.Items.Add(String.Empty);
                RefreshLineInListBox(i);
            }

            _NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex = 0;
            checkBoxAutoWrap.Checked = AppSettings.Instance.CommitValidationAutoWrap;

        }

        private void SaveSettings()
        {
            AppSettings.Instance.CommitValidationMaxCntCharsFirstLine = Convert.ToInt32(_NO_TRANSLATE_numericMaxFirstLineLength.Value);
            AppSettings.Instance.CommitValidationMaxCntCharsPerLine = Convert.ToInt32(_NO_TRANSLATE_numericMaxLineLength.Value);
            AppSettings.Instance.CommitValidationSecondLineMustBeEmpty = checkBoxSecondLineEmpty.Checked;
            AppSettings.Instance.CommitValidationIndentAfterFirstLine = checkBoxUseIndent.Checked;
            AppSettings.Instance.CommitValidationRegEx = _NO_TRANSLATE_textBoxCommitValidationRegex.Text;

            CommitTemplateItem.SaveToSettings(_commitTemplates);
            AppSettings.Instance.CommitValidationAutoWrap = checkBoxAutoWrap.Checked;
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textCommitTemplateText_TextChanged(object sender, EventArgs e)
        {
            _commitTemplates[_NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex].Text = _NO_TRANSLATE_textCommitTemplateText.Text;
        }

        private void textBoxCommitTemplateName_TextChanged(object sender, EventArgs e)
        {
            _commitTemplates[_NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex].Name = _NO_TRANSLATE_textBoxCommitTemplateName.Text;
            RefreshLineInListBox(_NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex);
        }

        private void comboBoxCommitTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            _NO_TRANSLATE_textCommitTemplateText.Text = _commitTemplates[_NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex].Text;
            _NO_TRANSLATE_textBoxCommitTemplateName.Text = _commitTemplates[_NO_TRANSLATE_comboBoxCommitTemplates.SelectedIndex].Name;
        }

        private void RefreshLineInListBox(int line)
        {
            string comboBoxText;

            if (!_commitTemplates[line].Name.IsNullOrEmpty())
            {
                comboBoxText = _commitTemplates[line].Name.Substring(0, _commitTemplates[line].Name.Length > _maxShownCharsForName ? (_maxShownCharsForName - 3) : _commitTemplates[line].Name.Length);
                comboBoxText += _commitTemplates[line].Name.Length > _maxShownCharsForName ? "..." : "";
            }
            else
                comboBoxText = "<" + _emptyTemplate.Text + ">";

            _NO_TRANSLATE_comboBoxCommitTemplates.Items[line] = String.Format("{0} : {1}", (line + 1), comboBoxText);
        }
    }
}
