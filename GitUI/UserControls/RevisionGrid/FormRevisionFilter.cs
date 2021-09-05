using System;

namespace GitUI.UserControls.RevisionGrid
{
    public partial class FormRevisionFilter : GitExtensionsDialog
    {
        private AdvancedFilterInfo _filterInfo;

        [Obsolete("For VS designer and translation test only. Do not remove.")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private FormRevisionFilter()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        public FormRevisionFilter(GitUICommands commands)
            : base(commands, enablePositionRestore: false)
        {
            InitializeComponent();
            InitializeComplete();

            // work-around the designer bug that can't add controls to FlowLayoutPanel
            ControlsPanel.Controls.Add(Ok);
            AcceptButton = Ok;
        }

        public void Bind(AdvancedFilterInfo filterInfo)
        {
            _filterInfo = filterInfo;

            SinceCheck.Checked = _filterInfo.ByDateFrom;
            Since.Value = _filterInfo.DateFrom;
            CheckUntil.Checked = _filterInfo.ByDateTo;
            Until.Value = _filterInfo.DateTo = Until.Value;
            AuthorCheck.Checked = _filterInfo.ByAuthor;
            Author.Text = _filterInfo.Author;
            CommitterCheck.Checked = _filterInfo.ByCommitter;
            Committer.Text = _filterInfo.Committer;
            CommitterCheck.Checked = _filterInfo.ByCommitter;
            Committer.Text = _filterInfo.Committer;
            MessageCheck.Checked = _filterInfo.ByMessage;
            Message.Text = _filterInfo.Message;
            IgnoreCase.Checked = _filterInfo.IgnoreCase;
            LimitCheck.Checked = _filterInfo.HasCommitsLimit;
            _NO_TRANSLATE_Limit.Value = _filterInfo.CommitsLimit;
            FileFilterCheck.Checked = _filterInfo.ByFileFilter;
            FileFilter.Text = _filterInfo.FileFilter;
            BranchFilterCheck.Checked = _filterInfo.ByBranchFilter;
            BranchFilter.Text = _filterInfo.BranchFilter;
            CurrentBranchOnlyCheck.Checked = _filterInfo.ShowCurrentBranchOnly;
            SimplifyByDecorationCheck.Checked = _filterInfo.ShowSimplifyByDecoration;

            UpdateFilters();
        }

        private void option_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void UpdateFilters()
        {
            Since.Enabled = SinceCheck.Checked;
            Until.Enabled = CheckUntil.Checked;
            Author.Enabled = AuthorCheck.Checked;
            Committer.Enabled = CommitterCheck.Checked;
            Message.Enabled = MessageCheck.Checked;
            _NO_TRANSLATE_Limit.Enabled = LimitCheck.Checked;
            FileFilter.Enabled = FileFilterCheck.Checked;

            CurrentBranchOnlyCheck.Enabled = BranchFilterCheck.Checked;
            SimplifyByDecorationCheck.Enabled = BranchFilterCheck.Checked;
            BranchFilter.Enabled = BranchFilterCheck.Checked &&
                                   !CurrentBranchOnlyCheck.Checked;
        }

        private void OkClick(object sender, EventArgs e)
        {
            _filterInfo.ByDateFrom = SinceCheck.Checked;
            _filterInfo.DateFrom = Since.Value;
            _filterInfo.ByDateTo = CheckUntil.Checked;
            _filterInfo.DateTo = Until.Value;
            _filterInfo.ByAuthor = AuthorCheck.Checked;
            _filterInfo.Author = Author.Text;
            _filterInfo.ByCommitter = CommitterCheck.Checked;
            _filterInfo.Committer = Committer.Text;
            _filterInfo.ByCommitter = CommitterCheck.Checked;
            _filterInfo.Committer = Committer.Text;
            _filterInfo.ByMessage = MessageCheck.Checked;
            _filterInfo.Message = Message.Text;
            _filterInfo.IgnoreCase = IgnoreCase.Checked;
            _filterInfo.HasCommitsLimit = LimitCheck.Checked;
            _filterInfo.CommitsLimit = (int)_NO_TRANSLATE_Limit.Value;
            _filterInfo.ByFileFilter = FileFilterCheck.Checked;
            _filterInfo.FileFilter = FileFilter.Text;
            _filterInfo.ByBranchFilter = BranchFilterCheck.Checked;
            _filterInfo.BranchFilter = BranchFilter.Enabled ? BranchFilter.Text : string.Empty;
            _filterInfo.ShowCurrentBranchOnly = CurrentBranchOnlyCheck.Checked;
            _filterInfo.ShowSimplifyByDecoration = SimplifyByDecorationCheck.Checked;
        }
    }
}
