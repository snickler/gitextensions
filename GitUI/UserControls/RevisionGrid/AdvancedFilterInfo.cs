using System;
using GitCommands;
using GitExtUtils;

namespace GitUI.UserControls.RevisionGrid
{
    public class AdvancedFilterInfo
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private string _author;
        private string _committer;
        private string _message;
        private string _fileFilter;
        private string _branchFilter;

        public bool ByDateFrom { get; set; }

        public DateTime DateFrom
        {
            get => ByDateFrom ? _dateFrom : DateTime.MinValue;
            set => _dateFrom = value;
        }

        public bool ByDateTo { get; set; }

        public DateTime DateTo
        {
            get => ByDateTo ? _dateTo : DateTime.MinValue;
            set => _dateTo = value;
        }

        public bool ByAuthor { get; set; }

        public string Author
        {
            get => ByAuthor ? _author : string.Empty;
            set => _author = value ?? string.Empty;
        }

        public bool ByCommitter { get; set; }

        public string Committer
        {
            get => ByCommitter ? _committer : string.Empty;
            set => _committer = value ?? string.Empty;
        }

        public bool ByMessage { get; set; }

        public string Message
        {
            get => ByMessage ? _message : string.Empty;
            set => _message = value ?? string.Empty;
        }

        public bool IgnoreCase { get; set; }

        public bool HasCommitsLimit { get; set; }

        public int CommitsLimit { get; set; }

        public bool ByFileFilter { get; set; }

        public string FileFilter
        {
            get => ByFileFilter ? _fileFilter : string.Empty;
            set => _fileFilter = value ?? string.Empty;
        }

        public bool ByBranchFilter { get; set; }

        public string BranchFilter
        {
            get => ByBranchFilter ? _branchFilter : string.Empty;
            set => _branchFilter = value ?? string.Empty;
        }

        public bool ShowCurrentBranchOnly { get; set; }

        public bool ShowSimplifyByDecoration { get; set; }

        public bool HasFilter
        {
            get => ByDateFrom ||
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
