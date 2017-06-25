using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitUI.CommitInfo
{
    public partial class CommitBasicDetails : GitModuleControl
    {
        public CommitBasicDetails()
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
        }

        /// <summary>
        /// Shows the data about the commits parents, children, branches and tags, if any.
        /// </summary>
        /// <param name="revisionGuid">The revision unique identifier.</param>
        /// <param name="parentGuids">The parent guids.</param>
        /// <param name="childrenGuids">The children guids.</param>
        public void ShowDetails(string revisionGuid, IList<string> parentGuids, IList<string> childrenGuids)
        {
            //tableLayoutPanel1.SuspendLayout();

            //Reset();
            //if (string.IsNullOrWhiteSpace(revisionGuid))
            //{
            //    return;
            //}

            //tableLayoutPanel1.ResumeLayout(false);
            //tableLayoutPanel1.PerformLayout();
        }
    }
}
