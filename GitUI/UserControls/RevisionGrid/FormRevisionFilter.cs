using System;
using GitCommands;
using GitExtUtils;

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

            _NO_TRANSLATE_Limit.Value = _filterInfo.CommitsLimit;
        }

        private void FormRevisionFilterLoad(object sender, EventArgs e)
        {
            EnableFilters();
        }

        private void SinceCheckCheckedChanged(object sender, EventArgs e)
        {
            EnableFilters();
        }

        private void OnBranchFilterCheckedChanged(object sender, EventArgs e)
        {
            // AppSettings.BranchFilterEnabled = BranchFilterCheck.Checked;
            _filterInfo.ByBranchFilter = BranchFilterCheck.Checked;
            EnableFilters();
        }

        private void OnShowCurrentBranchOnlyCheckedChanged(object sender, EventArgs e)
        {
            // AppSettings.ShowCurrentBranchOnly = CurrentBranchOnlyCheck.Checked;
            _filterInfo.ShowCurrentBranchOnly = CurrentBranchOnlyCheck.Checked;
            EnableFilters();
        }

        private void OnSimplifyByDecorationCheckedChanged(object sender, EventArgs e)
        {
            // AppSettings.ShowSimplifyByDecoration = SimplifyByDecorationCheck.Checked;
            _filterInfo.ShowSimplifyByDecoration = SimplifyByDecorationCheck.Checked;
            EnableFilters();
        }

        private void EnableFilters()
        {
            Since.Enabled = SinceCheck.Checked;
            Until.Enabled = CheckUntil.Checked;
            Author.Enabled = AuthorCheck.Checked;
            Committer.Enabled = CommitterCheck.Checked;
            Message.Enabled = MessageCheck.Checked;
            _NO_TRANSLATE_Limit.Enabled = LimitCheck.Checked;
            FileFilter.Enabled = FileFilterCheck.Checked;

            BranchFilterCheck.Checked = _filterInfo.ByBranchFilter; // AppSettings.BranchFilterEnabled;
            CurrentBranchOnlyCheck.Checked = _filterInfo.ShowCurrentBranchOnly; // AppSettings.ShowCurrentBranchOnly;
            SimplifyByDecorationCheck.Checked = _filterInfo.ShowSimplifyByDecoration; // AppSettings.ShowSimplifyByDecoration;

            CurrentBranchOnlyCheck.Enabled = BranchFilterCheck.Checked;
            SimplifyByDecorationCheck.Enabled = BranchFilterCheck.Checked;
            BranchFilter.Enabled = BranchFilterCheck.Checked &&
                                   !CurrentBranchOnlyCheck.Checked;

            FileFilter.Text = _filterInfo.FileFilter?.Trim();
            FileFilterCheck.Checked = !string.IsNullOrWhiteSpace(FileFilter.Text);

            BranchFilter.Text = _filterInfo.BranchFilter;
        }

        ////public bool FilterEnabled()
        ////{
        ////    return SinceCheck.Checked ||
        ////            CheckUntil.Checked ||
        ////            AuthorCheck.Checked ||
        ////            CommitterCheck.Checked ||
        ////            MessageCheck.Checked ||
        ////            FileFilterCheck.Checked ||
        ////            BranchFilterCheck.Checked;
        ////}

        ////public void DisableFilters()
        ////{
        ////    SinceCheck.Checked = false;
        ////    CheckUntil.Checked = false;
        ////    AuthorCheck.Checked = false;
        ////    CommitterCheck.Checked = false;
        ////    MessageCheck.Checked = false;
        ////    FileFilterCheck.Checked = false;
        ////    BranchFilterCheck.Checked = false;
        ////}

        ////public int GetMaxCount()
        ////{
        ////    return LimitCheck.Checked ? (int)_NO_TRANSLATE_Limit.Value : AppSettings.MaxRevisionGraphCommits;
        ////}

        ////public string GetPathFilter()
        ////{
        ////    return FileFilterCheck.Checked ? FileFilter.Text : "";
        ////}

        ////public bool GetIgnoreCase()
        ////{
        ////    return IgnoreCase.Checked;
        ////}

        ////public string GetBranchFilter()
        ////{
        ////    return (!AppSettings.BranchFilterEnabled || AppSettings.ShowCurrentBranchOnly) ? "" : BranchFilter.Text;
        ////}

        ////public bool SetBranchFilter(string? filter)
        ////{
        ////    string newFilter = filter?.Trim() ?? string.Empty;
        ////    if (string.Equals(newFilter, BranchFilter.Text, StringComparison.Ordinal))
        ////    {
        ////        // The filter hasn't changed
        ////        return false;
        ////    }

        ////    BranchFilter.Text = newFilter;
        ////    return true;
        ////}

        ////public void SetPathFilter(string filter)
        ////{
        ////    FileFilter.Text = filter?.Trim();
        ////    FileFilterCheck.Checked = !string.IsNullOrWhiteSpace(filter);
        ////}

        ////private void OkClick(object sender, EventArgs e)
        ////{
        ////    Close();
        ////}
    }

    public class AdvancedFilterInfo
    {
        public string? Author { get; set; }
        public bool ByAuthor { get; set; }
        public string? Committer { get; set; }
        public bool ByCommitter { get; set; }
        public string? Message { get; set; }
        public bool ByMessage { get; set; }
        public bool IgnoreCase { get; set; }
        public bool ByDateFrom { get; set; }
        public DateTime DateFrom { get; set; }
        public bool ByDateTo { get; set; }
        public DateTime DateTo { get; set; }
        public bool ByBranchFilter { get; set; }
        public string? BranchFilter { get; set; }
        public bool ByFileFilter { get; set; }
        public string? FileFilter { get; set; }
        public int MaxRevisionGraphCommits { get; set; }
        public bool ShowCurrentBranchOnly { get; set; }
        public bool ShowSimplifyByDecoration { get; set; }
        public bool HasCommitsLimit { get; set; }
        public int CommitsLimit { get; set; }

        public bool FilterEnabled()
        {
            return ByDateFrom ||
                   ByDateTo ||
                   ByAuthor ||
                   ByCommitter ||
                   ByMessage ||
                   ByFileFilter ||
                   ByBranchFilter;
        }

        public void DisableFilters()
        {
            ByDateFrom = false;
            ByDateTo = false;
            ByAuthor = false;
            ByCommitter = false;
            ByMessage = false;
            ByFileFilter = false;
            ByBranchFilter = false;
        }

        public string GetFileFilter()
        {
            return ByFileFilter ? FileFilter : "";
        }

        public string GetInMemAuthorFilter()
        {
            return (ByAuthor && !GitVersion.Current.IsRegExStringCmdPassable(Author)) ? Author : "";
        }

        public string GetInMemCommitterFilter()
        {
            return (ByCommitter && !GitVersion.Current.IsRegExStringCmdPassable(Committer)) ? Committer : "";
        }

        public string GetInMemMessageFilter()
        {
            return (ByMessage && !GitVersion.Current.IsRegExStringCmdPassable(Message)) ? Message : "";
        }

        public ArgumentString GetRevisionFilter()
        {
            ArgumentBuilder filter = new();

            if (ByAuthor && GitVersion.Current.IsRegExStringCmdPassable(Author))
            {
                filter.Add($"--author=\"{Author}\"");
            }

            if (ByCommitter && GitVersion.Current.IsRegExStringCmdPassable(Committer))
            {
                filter.Add($"--committer=\"{Committer}\"");
            }

            if (ByMessage && GitVersion.Current.IsRegExStringCmdPassable(Message))
            {
                filter.Add($"--grep=\"{Message}\"");
            }

            if (!filter.IsEmpty && IgnoreCase)
            {
                filter.Add("--regexp-ignore-case");
            }

            if (ByDateFrom)
            {
                filter.Add($"--since=\"{DateFrom:yyyy-MM-dd hh:mm:ss}\"");
            }

            if (ByDateTo)
            {
                filter.Add($"--until=\"{DateTo:yyyy-MM-dd hh:mm:ss}\"");
            }

            return filter;
        }
    }
}
