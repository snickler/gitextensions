using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.CommitInfo
{
    public partial class CommitDetails : GitModuleControl
    {
        private readonly object _syncRoot = new object();

        public CommitDetails()
        {
            InitializeComponent();
        }


        public void Reset()
        {
            RenderCommitBranches(null);
            RenderCommitChidren(null);
            RenderCommitParents(null);
            RenderCommitTags(null);
        }

        public void ShowDetails(string revisionGuid, IList<string> parentGuids, IList<string> childrenGuids)
        {
            Reset();
            if (string.IsNullOrWhiteSpace(revisionGuid))
            {
                return;
            }

            flpnlCommitInfoRight.SuspendLayout();
            RenderCommitParents(parentGuids);
            RenderCommitChidren(childrenGuids);

            flpnlCommitInfoRight.Controls[0].Width = flpnlCommitInfoRight.Width - 22;
            flpnlCommitInfoRight.ResumeLayout(false);
            flpnlCommitInfoRight.PerformLayout();

            if (AppSettings.CommitInfoShowContainedInBranches)
                ThreadPool.QueueUserWorkItem(_ => LoadBranchInfo(revisionGuid));

            if (AppSettings.CommitInfoShowContainedInTags)
                ThreadPool.QueueUserWorkItem(_ => LoadTagInfo(revisionGuid));
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
