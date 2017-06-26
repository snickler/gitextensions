using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GitCommands;
using ResourceManager;

namespace GitUI.CommitInfo
{
    public partial class CommitBasicDetails : GitModuleControl
    {
        private readonly Control[] _pnlCommitInfoPanelControls, _pnlCommitInfoPanelDynamicControls;


        public CommitBasicDetails()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ContainerControl | ControlStyles.OptimizedDoubleBuffer, true);
            Translate();

            txtHash.BackColor = tableLayoutPanel1.BackColor;

            _pnlCommitInfoPanelDynamicControls = new Control[]
            {
                txtHash, llblAuthor, llblCommitter, lblAuthorDate, lblCommitterDate
            };
            _pnlCommitInfoPanelControls = _pnlCommitInfoPanelDynamicControls.Union(new Control[]
            {
                lblCreatedBy, lblCommitter, lblSpacer1, lblSpacer2
            }).ToArray();
            _pnlCommitInfoPanelControls.ForEach(c =>
            {
                c.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                c.Font = AppSettings.Font;
            });
        }


        /// <summary>
        /// Resets all rendered data.
        /// </summary>
        public void Reset()
        {
            _pnlCommitInfoPanelDynamicControls.ForEach(c =>
            {
                c.Text = string.Empty;
            });
            gravatar1.LoadImageForEmail("");
        }

        /// <summary>
        /// Shows the data about the commit.
        /// </summary>
        public void ShowDetails(CommitData data)
        {
            //tableLayoutPanel1.SuspendLayout();

            Reset();
            if (data == null)
            {
                return;
            }

            llblAuthor.Text = data.Author; //$"{_revision.Author}\r\n{_revision.AuthorEmail}"; //
            llblCommitter.Text = data.Committer;
            lblAuthorDate.Text = LocalizationHelpers.GetRelativeDateString(DateTime.UtcNow, data.AuthorDate.UtcDateTime) + $@" ({LocalizationHelpers.GetFullDateString(data.AuthorDate)})";
            lblCommitterDate.Text = LocalizationHelpers.GetRelativeDateString(DateTime.UtcNow, data.CommitDate.UtcDateTime) + $@" ({LocalizationHelpers.GetFullDateString(data.CommitDate)})";

            txtHash.Text = (data.Guid ?? "").Substring(0, Math.Min(data.Guid.Length, 10)); //$"# {data.Guid}";

            LoadAuthorImage(data.Author ?? data.Committer);

            //tableLayoutPanel1.ResumeLayout(false);
            //tableLayoutPanel1.PerformLayout();
        }


        private void LoadAuthorImage(string author)
        {
            var matches = Regex.Matches(author, @"<([\w\-\.]+@[\w\-\.]+)>");
            if (matches.Count == 0)
            {
                return;
            }

            gravatar1.LoadImageForEmail(matches[0].Groups[1].Value);
        }

        private void ResizeCommitInfoPanel()
        {
            // TODO: needed fo Mono?
            //tableLayoutPanel1.SuspendLayout();

            // TODO: can be optimised
            var widthHash = TextRenderer.MeasureText(new string('a', txtHash.Text.Length), txtHash.Font).Width;
            var widthSideColumns = tableLayoutPanel1.ColumnStyles[0].Width + tableLayoutPanel1.ColumnStyles[2].Width;
            var widthAvatarEx = AppSettings.AuthorImageSize + widthSideColumns;

            var tableWidth = Math.Max(tableLayoutPanel1.MinimumSize.Width,
                (int)(Math.Max(widthHash, widthAvatarEx) + tableLayoutPanel1.Padding.Left + tableLayoutPanel1.Padding.Right));
            tableLayoutPanel1.Width = tableWidth;
            var midColumnWidth = tableWidth - widthSideColumns - tableLayoutPanel1.Padding.Left - tableLayoutPanel1.Padding.Right;

            var avatarPadding = ((int)midColumnWidth - AppSettings.AuthorImageSize) / 2;
            gravatar1.Margin = new Padding(avatarPadding, 4, avatarPadding, 4);

            //tableLayoutPanel1.ResumeLayout(false);
            //tableLayoutPanel1.PerformLayout();
        }
    }
}
