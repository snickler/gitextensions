using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.CommitInfo
{
    public partial class CommitExtraDetails : GitModuleControl
    {
        private readonly object _syncRoot = new object();

        public CommitExtraDetails()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ContainerControl | ControlStyles.OptimizedDoubleBuffer, true);
            Translate();
        }


        /// <summary>
        /// Resets all rendered data.
        /// </summary>
        public void Reset()
        {
            RenderCommitBranches(null);
            RenderCommitChidren(null);
            RenderCommitParents(null);
            RenderCommitTags(null);
        }

        /// <summary>
        /// Shows the data about the commits parents, children, branches and tags, if any.
        /// </summary>
        /// <param name="revisionGuid">The revision unique identifier.</param>
        /// <param name="parentGuids">The parent guids.</param>
        /// <param name="childrenGuids">The children guids.</param>
        public void ShowDetails(string revisionGuid, IList<string> parentGuids, IList<string> childrenGuids)
        {
            tableLayoutPanel1.SuspendLayout();

            Reset();
            if (string.IsNullOrWhiteSpace(revisionGuid))
            {
                return;
            }

            RenderCommitParents(parentGuids);
            RenderCommitChidren(childrenGuids);

            if (AppSettings.CommitInfoShowContainedInBranches)
            {
                ThreadPool.QueueUserWorkItem(_ => LoadBranchInfo(revisionGuid));
            }

            if (AppSettings.CommitInfoShowContainedInTags)
            {
                ThreadPool.QueueUserWorkItem(_ => LoadTagInfo(revisionGuid));
            }

            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
        }


        private void LoadBranchInfo(string revision)
        {
            // Include local branches if explicitly requested or when needed to decide whether to show remotes
            bool getLocal = AppSettings.CommitInfoShowContainedInBranchesLocal ||
                            AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            // Include remote branches if requested
            bool getRemote = AppSettings.CommitInfoShowContainedInBranchesRemote ||
                             AppSettings.CommitInfoShowContainedInBranchesRemoteIfNoLocal;
            var branches = Module.GetAllBranchesWhichContainGivenCommit(revision, getLocal, getRemote).ToList();
            this.InvokeAsync(() =>
            {
                RenderCommitBranches(branches);
            });
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
            lock (_syncRoot)
            {
                if (branches == null || branches.Count < 1)
                {
                    elpnlBranches.Visible =
                        lblCommitBranches.Visible =
                            lblDividerBranches.Visible = false;
                }
                else
                {
                    elpnlBranches.AddRange(branches);
                    elpnlBranches.Visible =
                        lblCommitBranches.Visible =
                            lblDividerBranches.Visible = true;
                }
            }
        }

        private void RenderCommitChidren(IList<string> children)
        {
            lock (_syncRoot)
            {
                if (children == null || children.Count < 1)
                {
                    elpnlChildren.Visible =
                        lblCommitChildren.Visible =
                            lblDivider4.Visible = false;
                }
                else
                {
                    elpnlChildren.AddRange(children.Select(x => x.Substring(0, Math.Min(x.Length, 10))));
                    elpnlChildren.Visible =
                        lblCommitChildren.Visible =
                            lblDivider4.Visible = true;
                }
            }
        }

        private void RenderCommitParents(IList<string> parents)
        {
            lock (_syncRoot)
            {
                if (parents == null || parents.Count < 1)
                {
                    elpnlParents.Visible =
                        lblCommitParents.Visible =
                            lblDivider3.Visible = false;
                }
                else
                {
                    elpnlParents.AddRange(parents.Select(x => x.Substring(0, Math.Min(x.Length, 10))));
                    elpnlParents.Visible =
                        lblCommitParents.Visible =
                            lblDivider3.Visible = true;
                }
            }
        }

        private void RenderCommitTags(IList<string> tags)
        {
            lock (_syncRoot)
            {
                if (tags == null || tags.Count < 1)
                {
                    elpnlTags.Visible =
                        lblCommitTags.Visible =
                            label5.Visible = false;
                }
                else
                {
                    elpnlTags.AddRange(tags);
                    elpnlTags.Visible =
                        lblCommitTags.Visible =
                            label5.Visible = true;
                }
            }
        }
    }
}
