namespace GitUI.CommitInfo
{
    partial class ExpandableListPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemMore = new System.Windows.Forms.LinkLabel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemMore
            // 
            this.itemMore.AutoSize = true;
            this.itemMore.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.itemMore.Location = new System.Drawing.Point(0, 0);
            this.itemMore.Name = "itemMore";
            this.itemMore.Size = new System.Drawing.Size(100, 23);
            this.itemMore.TabIndex = 0;
            this.itemMore.TabStop = true;
            this.itemMore.Text = "[...]";
            this.itemMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemMore_LinkClicked);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Location = new System.Drawing.Point(11, 144);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(166, 13);
            this.lblHeading.TabIndex = 15;
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.Location = new System.Drawing.Point(11, 159);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(166, 1);
            this.lblDivider.TabIndex = 17;
            this.lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.LinkLabel itemMore;
    }
}
