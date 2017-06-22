using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Utils;
using GitCommands.GitExtLinks;
using GitUI.Editor.RichTextBoxExtension;
using ResourceManager;
using GitUI.Editor;

namespace GitUI.CommitInfo
{
    public partial class CommitInfo : GitModuleControl
    {
        // ReSharper disable InconsistentNaming
        private readonly TranslationString containedInBranches = new TranslationString("Contained in branches:");
        private readonly TranslationString containedInNoBranch = new TranslationString("Contained in no branch");
        private readonly TranslationString containedInTags = new TranslationString("Contained in tags:");
        private readonly TranslationString containedInNoTag = new TranslationString("Contained in no tag");
        private readonly TranslationString trsLinksRelatedToRevision = new TranslationString("Related links:");
        // ReSharper restore InconsistentNaming

        private const int MaximumDisplayedRefs = 20;
        private GitRevision _revision;
        private List<string> _children;
        private string _revisionInfo;
        private string _linksInfo;
        private IDictionary<string, string> _annotatedTagsMessages;
        private string _annotatedTagsInfo;
        private List<string> _tags;
        private string _tagInfo;
        private List<string> _branches;
        private string _branchInfo;
        private IList<string> _sortedRefs;
        private readonly Control[] _pnlCommitInfoPanelControls, _pnlCommitInfoPanelDynamicControls;


        public event EventHandler<CommandEventArgs> CommandClick;


        public CommitInfo()
        {
            InitializeComponent();
            txtHash.BackColor =
                RevisionInfo.BackColor = tlpnlCommitInfoLeft.BackColor;
            Translate();
            GitUICommandsSourceSet += (a, uiCommandsSource) =>
            {
                _sortedRefs = null;
            };

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
                //c.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                c.Font = AppSettings.Font;
            });

            ResetTextAndImage();
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public GitRevision Revision
        {
            get
            {
                return _revision;
            }
            set
            {
                SetRevisionWithChildren(value, null);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string RevisionGuid
        {
            get
            {
                return _revision?.Guid ?? Guid.Empty.ToString("N");
            }
        }

        [DefaultValue(false)]
        public bool ShowBranchesAsLinks { get; set; }


        public void DisplayAvatarOnRight()
        {
            //tableLayout.SuspendLayout();
            //tableLayout.ColumnStyles.Clear();
            //tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            //tableLayout.ColumnStyles.Add(new ColumnStyle());
            //tableLayout.SetColumn(gravatar1, 1);
            //tableLayout.SetColumn(RevisionInfo, 0);
            //tableLayout.SetRowSpan(gravatar1, 1);
            //tableLayout.SetColumnSpan(RevisionInfo, 2);
            //tableLayout.ResumeLayout(true);

        }

        public void SetRevisionWithChildren(GitRevision revision, List<string> children)
        {
            _revision = revision;
            _children = children;
            ReloadCommitInfo();
        }


        private void ReloadCommitInfo()
        {
            showContainedInBranchesToolStripMenuItem.Checked = AppSettings.CommitInfoShowContainedInBranchesLocal;
            showContainedInBranchesRemoteToolStripMenuItem.Checked = AppSettings.CommitInfoShowContainedInBranchesRemote;
            showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Checked = AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            showContainedInTagsToolStripMenuItem.Checked = AppSettings.CommitInfoShowContainedInTags;
            showMessagesOfAnnotatedTagsToolStripMenuItem.Checked = AppSettings.ShowAnnotatedTagsMessages;

            ResetTextAndImage();
            commitDetails1.Reset();

            if (string.IsNullOrEmpty(_revision.Guid))
                return; //is it regular case or should throw an exception

            string error = "";
            CommitData data = CommitData.CreateFromRevision(_revision);
            if (_revision.Body == null)
            {
                CommitData.UpdateCommitMessage(data, Module, _revision.Guid, ref error);
                _revision.Body = data.Body;
            }

            ThreadPool.QueueUserWorkItem(_ => LoadLinksForRevision(_revision));

            if (_sortedRefs == null)
                ThreadPool.QueueUserWorkItem(_ => LoadSortedRefs());

            data.ChildrenGuids = _children;
            CommitInformation commitInformation = CommitInformation.GetCommitInfo(data, CommandClick != null, Module);

            llblAuthor.Text = data.Author; //$"{_revision.Author}\r\n{_revision.AuthorEmail}"; //
            llblCommitter.Text = data.Committer;
            lblAuthorDate.Text =
                LocalizationHelpers.GetRelativeDateString(DateTime.UtcNow, data.AuthorDate.UtcDateTime) +
                $@" ({LocalizationHelpers.GetFullDateString(data.AuthorDate)})";
            lblCommitterDate.Text =
                LocalizationHelpers.GetRelativeDateString(DateTime.UtcNow, data.CommitDate.UtcDateTime) +
                $@" ({LocalizationHelpers.GetFullDateString(data.CommitDate)})";

            txtHash.Text = (data.Guid ?? "").Substring(0, Math.Min(data.Guid.Length, 10)); //$"# {data.Guid}";

            commitDetails1.ShowDetails(_revision.Guid, data.ParentGuids, data.ChildrenGuids);
            ApplyCommitInfoPanelLayout();

            _revisionInfo = commitInformation.Body.Trim();
            UpdateText();
            LoadAuthorImage(data.Author ?? data.Committer);

            if (AppSettings.ShowAnnotatedTagsMessages)
                ThreadPool.QueueUserWorkItem(_ => LoadAnnotatedTagInfo(_revision));
        }



        private void LoadSortedRefs()
        {
            _sortedRefs = Module.GetSortedRefs();
            this.InvokeAsync(UpdateText);
        }

        private void LoadAnnotatedTagInfo(GitRevision revision)
        {
            _annotatedTagsMessages = GetAnnotatedTagsMessages(revision);
            this.InvokeAsync(UpdateText);
        }

        private IDictionary<string, string> GetAnnotatedTagsMessages(GitRevision revision)
        {
            if (revision == null)
                return null;

            IDictionary<string, string> result = new Dictionary<string, string>();

            foreach (var gitRef in revision.Refs)
            {
                #region Note on annotated tags
                // Notice that for the annotated tags, gitRef's come in pairs because they're produced
                // by the "show-ref --dereference" command. GitRef's in such pair have the same Name,
                // a bit different CompleteName's, and completely different checksums:
                //      GitRef_1:
                //      {
                //          Name: "some_tag"
                //          CompleteName: "refs/tags/some_tag"
                //          Guid: <some_tag_checksum>
                //      },
                //
                //      GitRef_2:
                //      {
                //          Name: "some_tag"
                //          CompleteName: "refs/tags/some_tag^{}"   <- by "^{}", IsDereference is true.
                //          Guid: <target_object_checksum>
                //      }
                //
                // The 2nd one is a dereference: a link between the tag and the object which it references.
                // GitRevions.Refs by design contains GitRef's where Guid's are equal to the GitRevision.Guid,
                // so this collection contains only derefencing GitRef's - just because GitRef_2 has the same
                // Guid as the GitRevision, while GitRef_1 doesn't. So annotated tag's GitRef would always be
                // of 2nd type in GitRevision.Refs collection, i.e. the one that has IsDereference==true.
                #endregion

                if (gitRef.IsTag && gitRef.IsDereference)
                {
                    string content = WebUtility.HtmlEncode(Module.GetTagMessage(gitRef.LocalName));

                    if (content != null)
                        result.Add(gitRef.LocalName, content);
                }
            }

            return result;
        }



        private void LoadLinksForRevision(GitRevision revision)
        {
            if (revision == null)
                return;

            _linksInfo = GetLinksForRevision(revision);
            this.InvokeAsync(UpdateText);
        }

        private void UpdateText()
        {
            Debug.WriteLine("Update text");
            if (_sortedRefs != null)
            {
                if (_annotatedTagsMessages != null &&
                    _annotatedTagsMessages.Any() &&
                    string.IsNullOrEmpty(_annotatedTagsInfo) &&
                    Revision != null)
                {
                    // having both lightweight & annotated tags in thisRevisionTagNames,
                    // but GetAnnotatedTagsInfo will process annotated only:
                    List<string> thisRevisionTagNames =
                        Revision
                        .Refs
                        .Where(r => r.IsTag)
                        .Select(r => r.LocalName)
                        .ToList();

                    thisRevisionTagNames.Sort(new ItemTpComparer(_sortedRefs, "refs/tags/"));
                    _annotatedTagsInfo = GetAnnotatedTagsInfo(thisRevisionTagNames, _annotatedTagsMessages);
                }
                if (_tags != null && string.IsNullOrEmpty(_tagInfo))
                {
                    _tags.Sort(new ItemTpComparer(_sortedRefs, "refs/tags/"));
                    if (_tags.Count > MaximumDisplayedRefs)
                    {
                        _tags[MaximumDisplayedRefs - 2] = "…";
                        _tags[MaximumDisplayedRefs - 1] = _tags[_tags.Count - 1];
                        _tags.RemoveRange(MaximumDisplayedRefs, _tags.Count - MaximumDisplayedRefs);
                    }
                    _tagInfo = GetTagsWhichContainsThisCommit(_tags, ShowBranchesAsLinks);
                }
                if (_branches != null && string.IsNullOrEmpty(_branchInfo))
                {
                    _branches.Sort(new ItemTpComparer(_sortedRefs, "refs/heads/"));
                    if (_branches.Count > MaximumDisplayedRefs)
                    {
                        _branches[MaximumDisplayedRefs - 2] = "…";
                        _branches[MaximumDisplayedRefs - 1] = _branches[_branches.Count - 1];
                        _branches.RemoveRange(MaximumDisplayedRefs, _branches.Count - MaximumDisplayedRefs);
                    }
                    _branchInfo = GetBranchesWhichContainsThisCommit(_branches, ShowBranchesAsLinks);
                }
            }
            RevisionInfo.SuspendLayout();
            RevisionInfo.SetXHTMLText(_revisionInfo + "\n" + _annotatedTagsInfo + _linksInfo + _branchInfo + _tagInfo);
            RevisionInfo.SelectionStart = 0; //scroll up
            RevisionInfo.ScrollToCaret();    //scroll up
            RevisionInfo.ResumeLayout(true);
        }

        private static string GetAnnotatedTagsInfo(IEnumerable<string> tagNames, IDictionary<string, string> annotatedTagsMessages)
        {
            string result = string.Empty;

            foreach (string tag in tagNames)
            {
                string annotatedContents;
                if (annotatedTagsMessages.TryGetValue(tag, out annotatedContents))
                    result += "<u>" + tag + "</u>: " + annotatedContents + Environment.NewLine;
            }

            if (result.IsNullOrEmpty())
                return string.Empty;

            return Environment.NewLine + result;
        }

        private void ResetTextAndImage()
        {
            commitDetails1.Reset();

            _pnlCommitInfoPanelDynamicControls.ForEach(c =>
            {
                c.Text = string.Empty;
            });

            _revisionInfo = string.Empty;
            _linksInfo = string.Empty;
            _branchInfo = string.Empty;
            _annotatedTagsInfo = string.Empty;
            _tagInfo = string.Empty;
            _branches = null;
            _annotatedTagsMessages = null;
            _tags = null;
            UpdateText();
            gravatar1.LoadImageForEmail("");
        }

        private void LoadAuthorImage(string author)
        {
            var matches = Regex.Matches(author, @"<([\w\-\.]+@[\w\-\.]+)>");

            if (matches.Count == 0)
                return;

            gravatar1.LoadImageForEmail(matches[0].Groups[1].Value);
        }

        private string GetBranchesWhichContainsThisCommit(IEnumerable<string> branches, bool showBranchesAsLinks)
        {
            const string remotesPrefix = "remotes/";
            // Include local branches if explicitly requested or when needed to decide whether to show remotes
            bool getLocal = AppSettings.CommitInfoShowContainedInBranchesLocal ||
                            AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            // Include remote branches if requested
            bool getRemote = AppSettings.CommitInfoShowContainedInBranchesRemote ||
                             AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            var links = new List<string>();
            bool allowLocal = AppSettings.CommitInfoShowContainedInBranchesLocal;
            bool allowRemote = getRemote;

            foreach (var branch in branches)
            {
                string noPrefixBranch = branch;
                bool branchIsLocal;
                if (getLocal && getRemote)
                {
                    // "git branch -a" prefixes remote branches with "remotes/"
                    // It is possible to create a local branch named "remotes/origin/something"
                    // so this check is not 100% reliable.
                    // This shouldn't be a big problem if we're only displaying information.
                    branchIsLocal = !branch.StartsWith(remotesPrefix);
                    if (!branchIsLocal)
                        noPrefixBranch = branch.Substring(remotesPrefix.Length);
                }
                else
                {
                    branchIsLocal = !getRemote;
                }

                if ((branchIsLocal && allowLocal) || (!branchIsLocal && allowRemote))
                {
                    string branchText;
                    if (showBranchesAsLinks)
                        branchText = LinkFactory.CreateBranchLink(noPrefixBranch);
                    else
                        branchText = WebUtility.HtmlEncode(noPrefixBranch);
                    links.Add(branchText);
                }

                if (branchIsLocal && AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal)
                    allowRemote = false;
            }
            if (links.Any())
                return Environment.NewLine + WebUtility.HtmlEncode(containedInBranches.Text) + " " + links.Join(", ");
            return Environment.NewLine + WebUtility.HtmlEncode(containedInNoBranch.Text);
        }

        private string GetTagsWhichContainsThisCommit(IEnumerable<string> tags, bool showBranchesAsLinks)
        {
            var tagString = tags
                .Select(s => showBranchesAsLinks ? LinkFactory.CreateTagLink(s) : WebUtility.HtmlEncode(s)).Join(", ");

            if (!String.IsNullOrEmpty(tagString))
                return Environment.NewLine + WebUtility.HtmlEncode(containedInTags.Text) + " " + tagString;
            return Environment.NewLine + WebUtility.HtmlEncode(containedInNoTag.Text);
        }

        private string GetLinksForRevision(GitRevision revision)
        {
            GitExtLinksParser parser = new GitExtLinksParser(Module.EffectiveSettings);
            var links = parser.Parse(revision).Distinct();
            var linksString = string.Empty;

            foreach (var link in links)
            {
                linksString = linksString.Combine(", ", LinkFactory.CreateLink(link.Caption, link.URI));
            }

            if (linksString.IsNullOrEmpty())
                return string.Empty;
            else
                return Environment.NewLine + WebUtility.HtmlEncode(trsLinksRelatedToRevision.Text) + " " + linksString;
        }


        private void showContainedInBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesLocal = !AppSettings.CommitInfoShowContainedInBranchesLocal;
            ReloadCommitInfo();
        }

        private void showContainedInTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInTags = !AppSettings.CommitInfoShowContainedInTags;
            ReloadCommitInfo();
        }

        private void copyCommitInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(string.Concat(_RevisionHeader.GetPlaintText(), Environment.NewLine, RevisionInfo.GetPlaintText()));
        }

        private void showContainedInBranchesRemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesRemote = !AppSettings.CommitInfoShowContainedInBranchesRemote;
            ReloadCommitInfo();
        }

        private void showContainedInBranchesRemoteIfNoLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal = !AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            ReloadCommitInfo();
        }

        private void HandleLink(string link, object sender)
        {
            try
            {
                var result = new Uri(link);
                if (result.Scheme == "gitext")
                {
                    if (CommandClick != null)
                    {
                        string path = result.AbsolutePath.TrimStart('/');
                        CommandClick(sender, new CommandEventArgs(result.Host, path));
                    }
                }
                else
                {
                    using (var process = new Process
                    {
                        EnableRaisingEvents = false,
                        StartInfo = { FileName = result.AbsoluteUri }
                    })
                    {
                        process.Start();
                    }
                }
            }
            catch (UriFormatException)
            {
            }
        }

        private void showMessagesOfAnnotatedTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.ShowAnnotatedTagsMessages = !AppSettings.ShowAnnotatedTagsMessages;
            ReloadCommitInfo();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module.EditNotes(_revision.Guid);
            ReloadCommitInfo();
        }

        private void RevisionInfoLinkClicked(object sender, LinkClickedEventArgs e)
        {
            string link = LinkFactory.ParseLink(e.LinkText);
            HandleLink(link, sender);
        }

        private void DoCommandClick(string command, string data)
        {
            CommandClick?.Invoke(this, new CommandEventArgs(command, data));
        }

        // TODO: should be on control level
        private void _RevisionHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.XButton1)
            {
                DoCommandClick("navigatebackward", null);
            }
            else if (e.Button == MouseButtons.XButton2)
            {
                DoCommandClick("navigateforward", null);
            }
        }

        private class ItemTpComparer : IComparer<string>
        {
            private readonly IList<string> _otherList;
            private readonly string _prefix;

            public ItemTpComparer(IList<string> otherList, string prefix)
            {
                _otherList = otherList;
                _prefix = prefix;
            }

            public int Compare(string a, string b)
            {
                if (a.StartsWith("remotes/"))
                    a = "refs/" + a;
                else
                    a = _prefix + a;
                if (b.StartsWith("remotes/"))
                    b = "refs/" + b;
                else
                    b = _prefix + b;
                int i = _otherList.IndexOf(a);
                int j = _otherList.IndexOf(b);
                return i - j;
            }
        }

        private void ResizeCommitInfoPanel()
        {
            // TODO: needed fo Mono?
            //tlpnlCommitInfoLeft.SuspendLayout();

            // TODO: can be optimised
            var widthHash = TextRenderer.MeasureText(new string('a', txtHash.Text.Length), txtHash.Font).Width;
            var widthSideColumns = tlpnlCommitInfoLeft.ColumnStyles[0].Width + tlpnlCommitInfoLeft.ColumnStyles[2].Width;
            var widthAvatarEx = AppSettings.AuthorImageSize + widthSideColumns;

            var tableWidth = Math.Max(tlpnlCommitInfoLeft.MinimumSize.Width,
                                      (int)(Math.Max(widthHash, widthAvatarEx) + tlpnlCommitInfoLeft.Padding.Left + tlpnlCommitInfoLeft.Padding.Right));
            tlpnlCommitInfoLeft.Width = tableWidth;
            var midColumnWidth = tableWidth - widthSideColumns - tlpnlCommitInfoLeft.Padding.Left - tlpnlCommitInfoLeft.Padding.Right;

            var avatarPadding = ((int)midColumnWidth - AppSettings.AuthorImageSize) / 2;
            gravatar1.Margin = new Padding(avatarPadding, 4, avatarPadding, 4);

            //tlpnlCommitInfoLeft.ResumeLayout(false);
            //tlpnlCommitInfoLeft.PerformLayout();
        }


        private void gravatar1_GravatarSizeChanged(object sender, EventArgs e)
        {
            ApplyCommitInfoPanelLayout();
        }

        private void ApplyCommitInfoPanelLayout()
        {
            try
            {
                // TODO: needed fo Mono?
                //_pnlCommitInfoPanelControls.ForEach(c =>
                //{
                //    c.Anchor = AnchorStyles.Left;
                //    c.Width = 100;
                //});

                ResizeCommitInfoPanel();

                //_pnlCommitInfoPanelControls.ForEach(c =>
                //{
                //    c.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                //});

            }
            finally
            {
                AutoScrollMinSize = new System.Drawing.Size(tlpnlCommitInfoLeft.Width,
                                                            lblCommitterDate.Top + lblCommitterDate.Height + tlpnlCommitInfoLeft.Margin.Bottom);
            }
        }

        private void CommitInfo_SizeChanged(object sender, EventArgs e)
        {
            splitter1.MinExtra = 500;
            splitter1.MinSize = 100;
        }

        private void RevisionInfo_VScroll(object sender, EventArgs e)
        {
            Console.WriteLine("RevisionInfo_VScroll");
        }
    }
}