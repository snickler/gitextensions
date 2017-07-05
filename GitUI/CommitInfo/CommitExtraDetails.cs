using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using GitCommands;
using GitCommands.GitExtLinks;
using GitUI.Properties;
using ResourceManager;

namespace GitUI.CommitInfo
{
    public partial class CommitExtraDetails : GitModuleControl
    {
        private GitExtLinksParser _linksParser;
        private GitRevision _revision;


        // TODO: inject interface
        public CommitExtraDetails(GitExtLinksParser linksParser)
        {
            _linksParser = linksParser;

            InitializeComponent();
            SetStyle(ControlStyles.ContainerControl | ControlStyles.OptimizedDoubleBuffer, true);
            Translate();
        }

        public CommitExtraDetails()
            : this(null)
        {
        }


        /// <summary>
        /// Resets all rendered data.
        /// </summary>
        public void Reset()
        {
            _revision = null;
            RenderCommitBranches(null);
            RenderCommitChidren(null);
            RenderCommitLinks(null);
            RenderCommitParents(null);
            RenderCommitTags(null);
        }

        /// <summary>
        /// Shows the data about the commits parents, children, branches and tags, if any.
        /// </summary>
        /// <param name="revision">The revision.</param>
        /// <param name="childrenGuids">The revision's children guids.</param>
        public void ShowDetails(GitRevision revision, IList<string> childrenGuids)
        {

            //tableLayoutPanel1.SuspendLayout();

            pbViewParents.Visible = pbViewChildren.Visible = false;
            pbViewLinks.Image = AppSettings.CommitInfoShowLinks ? Resources.eye_opened : Resources.eye_closed;
            pbViewBranches.Image = AppSettings.CommitInfoShowContainedInBranches ? Resources.eye_opened : Resources.eye_closed;
            pbViewTags.Image = AppSettings.CommitInfoShowContainedInTags ? Resources.eye_opened : Resources.eye_closed;

            Reset();
            if (string.IsNullOrWhiteSpace(revision?.Guid))
            {
                return;
            }

            _revision = revision;
            RenderCommitParents(revision.ParentGuids);
            RenderCommitChidren(childrenGuids);

            ThreadPool.QueueUserWorkItem(_ =>
            {
                _linksParser = _linksParser ?? new GitExtLinksParser(Module.EffectiveSettings);
                var links = _linksParser.Parse(revision).Distinct();

                // TODO:
                //var relatedLinks = links.Select(link => LinkFactory.CreateLink(link.Caption, link.URI)).ToList();
                var relatedLinks = links.Select(link => link.Caption).ToList();
                this.InvokeAsync(() =>
                {
                    RenderCommitLinks(relatedLinks);
                });
            });

            LoadBranchInfo();

            if (AppSettings.CommitInfoShowContainedInTags)
            {
                ThreadPool.QueueUserWorkItem(_ => LoadTagInfo(revision.Guid));
            }

            //tableLayoutPanel1.ResumeLayout(false);
            //tableLayoutPanel1.PerformLayout();
        }


        private void LoadBranchInfo()
        {
            if (AppSettings.CommitInfoShowContainedInBranches)
            {
                ThreadPool.QueueUserWorkItem(_ =>
                {
                    // Include local branches if explicitly requested or when needed to decide whether to show remotes
                    bool getLocal = AppSettings.CommitInfoShowContainedInBranchesLocal ||
                                    AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
                    // Include remote branches if requested
                    bool getRemote = AppSettings.CommitInfoShowContainedInBranchesRemote ||
                                     AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
                    var branches = Module.GetAllBranchesWhichContainGivenCommit(_revision.Guid, getLocal, getRemote).ToList();
                    this.InvokeAsync(() =>
                    {
                        RenderCommitBranches(branches);
                    });
                });
            }
            else
            {
                RenderCommitBranches(null);
            }
        }

        private void LoadTagInfo(string revision)
        {
            var tags = Module.GetAllTagsWhichContainGivenCommit(revision).ToList();
            this.InvokeAsync(() =>
            {
                RenderCommitTags(tags);
            });
        }

        private void RenderCommitBranches(IList<string> branches)
        {
            if (branches == null || branches.Count < 1)
            {
                elpnlBranches.Visible = false;
                //lblCommitBranches.Visible =
                //    lblDividerBranches.Visible = false;
            }
            else
            {
                elpnlBranches.AddRange(branches);
                elpnlBranches.Visible = true;
                //lblCommitBranches.Visible =
                //    lblDividerBranches.Visible = true;
            }
        }

        private void RenderCommitChidren(IList<string> children)
        {
            if (children == null || children.Count < 1)
            {
                elpnlChildren.Visible = false;
                //lblCommitChildren.Visible =
                //    lblDividerChildren.Visible = false;
            }
            else
            {
                elpnlChildren.AddRange(children.Select(x => x.Substring(0, Math.Min(x.Length, 10))));
                elpnlChildren.Visible = true;
                //lblCommitChildren.Visible =
                //    lblDividerChildren.Visible = true;
            }
        }

        private void RenderCommitLinks(IList<string> links)
        {
            if (links == null || links.Count < 1)
            {
                elpnlCommitLinks.Visible = false;
                //lblCommitLinks.Visible =
                //    lblDividerLinks.Visible = false;
            }
            else
            {
                elpnlCommitLinks.AddRange(links);
                elpnlCommitLinks.Visible = true;
                //lblCommitLinks.Visible =
                //    lblDividerLinks.Visible = true;
            }
        }

        private void RenderCommitParents(IList<string> parents)
        {
            if (parents == null || parents.Count < 1)
            {
                elpnlParents.Visible = false;
                //lblCommitParents.Visible =
                //    lblDividerParents.Visible = false;
            }
            else
            {
                elpnlParents.AddRange(parents.Select(x => x.Substring(0, Math.Min(x.Length, 10))));
                elpnlParents.Visible = true;
                //lblCommitParents.Visible =
                //    lblDividerParents.Visible = true;
            }
        }

        private void RenderCommitTags(IList<string> tags)
        {
            if (tags == null || tags.Count < 1)
            {
                elpnlTags.Visible = false;
                //lblCommitTags.Visible =
                //    lblDividerTags.Visible = false;
            }
            else
            {
                elpnlTags.AddRange(tags);
                elpnlTags.Visible = true;
                //lblCommitTags.Visible =
                //    lblDividerTags.Visible = true;
            }
        }


        private void pbViewFeature_Click(object sender, EventArgs e)
        {
            if (sender == pbViewBranches)
            {
                AppSettings.CommitInfoShowContainedInBranchesLocal = !AppSettings.CommitInfoShowContainedInBranchesLocal;
                LoadBranchInfo();
            }
            else if (sender == pbViewTags)
            {
                AppSettings.CommitInfoShowContainedInTags = !AppSettings.CommitInfoShowContainedInTags;
                //LoadTagInfo();
            }
        }

        private void tsmnuShowContainedInBranches_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesLocal = !AppSettings.CommitInfoShowContainedInBranchesLocal;
            LoadBranchInfo();
        }

        private void tsmiShowContainedInBranchesRemote_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesRemote = !AppSettings.CommitInfoShowContainedInBranchesRemote;
            LoadBranchInfo();
        }

        private void tsmiShowContainedInBranchesRemoteIfNoLocal_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal = !AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            LoadBranchInfo();
        }

        private void tsmiShowContainedInTags_Click(object sender, EventArgs e)
        {
            AppSettings.CommitInfoShowContainedInTags = !AppSettings.CommitInfoShowContainedInTags;
        }
    }
}
