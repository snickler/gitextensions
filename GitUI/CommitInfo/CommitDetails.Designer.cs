namespace GitUI.CommitInfo
{
    partial class CommitDetails
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
            this.flpnlCommitInfoRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCommitParents = new System.Windows.Forms.Label();
            this.lblDivider3 = new System.Windows.Forms.Label();
            this.elpnlParents = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.lblCommitChildren = new System.Windows.Forms.Label();
            this.lblDivider4 = new System.Windows.Forms.Label();
            this.elpnlChildren = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.lblCommitBranches = new System.Windows.Forms.Label();
            this.lblDividerBranches = new System.Windows.Forms.Label();
            this.elpnlBranches = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.lblCommitTags = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.elpnlTags = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.flpnlCommitInfoRight.SuspendLayout();
            this.elpnlParents.SuspendLayout();
            this.elpnlChildren.SuspendLayout();
            this.elpnlBranches.SuspendLayout();
            this.elpnlTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnlCommitInfoRight
            // 
            this.flpnlCommitInfoRight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitParents);
            this.flpnlCommitInfoRight.Controls.Add(this.lblDivider3);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlParents);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitChildren);
            this.flpnlCommitInfoRight.Controls.Add(this.lblDivider4);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlChildren);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitBranches);
            this.flpnlCommitInfoRight.Controls.Add(this.lblDividerBranches);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlBranches);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitTags);
            this.flpnlCommitInfoRight.Controls.Add(this.label5);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlTags);
            this.flpnlCommitInfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlCommitInfoRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlCommitInfoRight.Location = new System.Drawing.Point(8, 8);
            this.flpnlCommitInfoRight.Name = "flpnlCommitInfoRight";
            this.flpnlCommitInfoRight.Padding = new System.Windows.Forms.Padding(8);
            this.flpnlCommitInfoRight.Size = new System.Drawing.Size(287, 477);
            this.flpnlCommitInfoRight.TabIndex = 14;
            this.flpnlCommitInfoRight.WrapContents = false;
            // 
            // lblCommitParents
            // 
            this.lblCommitParents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitParents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommitParents.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitParents.Location = new System.Drawing.Point(11, 8);
            this.lblCommitParents.Name = "lblCommitParents";
            this.lblCommitParents.Size = new System.Drawing.Size(241, 13);
            this.lblCommitParents.TabIndex = 1;
            this.lblCommitParents.Text = "Parent(s):";
            // 
            // lblDivider3
            // 
            this.lblDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider3.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider3.Location = new System.Drawing.Point(11, 23);
            this.lblDivider3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider3.Name = "lblDivider3";
            this.lblDivider3.Size = new System.Drawing.Size(241, 1);
            this.lblDivider3.TabIndex = 14;
            this.lblDivider3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlParents
            // 
            this.elpnlParents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlParents.AutoSize = true;
            this.elpnlParents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlParents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elpnlParents.Controls.Add(this.linkLabel1);
            this.elpnlParents.Controls.Add(this.linkLabel2);
            this.elpnlParents.Controls.Add(this.linkLabel3);
            this.elpnlParents.ItemsToShow = 2;
            this.elpnlParents.Location = new System.Drawing.Point(28, 29);
            this.elpnlParents.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlParents.Name = "elpnlParents";
            this.elpnlParents.Size = new System.Drawing.Size(224, 17);
            this.elpnlParents.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "5cae7ce332";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(76, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 15);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "9bdd791675";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(152, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(67, 15);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "5cae7ce332";
            // 
            // lblCommitChildren
            // 
            this.lblCommitChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitChildren.AutoSize = true;
            this.lblCommitChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommitChildren.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitChildren.Location = new System.Drawing.Point(11, 65);
            this.lblCommitChildren.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitChildren.Name = "lblCommitChildren";
            this.lblCommitChildren.Size = new System.Drawing.Size(241, 15);
            this.lblCommitChildren.TabIndex = 2;
            this.lblCommitChildren.Text = "Children:";
            // 
            // lblDivider4
            // 
            this.lblDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider4.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider4.Location = new System.Drawing.Point(11, 82);
            this.lblDivider4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider4.Name = "lblDivider4";
            this.lblDivider4.Size = new System.Drawing.Size(241, 1);
            this.lblDivider4.TabIndex = 13;
            this.lblDivider4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlChildren
            // 
            this.elpnlChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlChildren.AutoSize = true;
            this.elpnlChildren.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elpnlChildren.Controls.Add(this.linkLabel4);
            this.elpnlChildren.Controls.Add(this.linkLabel5);
            this.elpnlChildren.Controls.Add(this.linkLabel6);
            this.elpnlChildren.ItemsToShow = 2;
            this.elpnlChildren.Location = new System.Drawing.Point(28, 88);
            this.elpnlChildren.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlChildren.Name = "elpnlChildren";
            this.elpnlChildren.Size = new System.Drawing.Size(224, 15);
            this.elpnlChildren.TabIndex = 3;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(3, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(53, 13);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(62, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(53, 13);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel5";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(121, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(53, 13);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "linkLabel6";
            // 
            // lblCommitBranches
            // 
            this.lblCommitBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitBranches.AutoSize = true;
            this.lblCommitBranches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommitBranches.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitBranches.Image = global::GitUI.Properties.Resources.Icon_35;
            this.lblCommitBranches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitBranches.Location = new System.Drawing.Point(11, 122);
            this.lblCommitBranches.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitBranches.Name = "lblCommitBranches";
            this.lblCommitBranches.Size = new System.Drawing.Size(241, 15);
            this.lblCommitBranches.TabIndex = 15;
            this.lblCommitBranches.Text = "       Contained in branches:";
            this.lblCommitBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDividerBranches
            // 
            this.lblDividerBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerBranches.BackColor = System.Drawing.SystemColors.Control;
            this.lblDividerBranches.Location = new System.Drawing.Point(11, 139);
            this.lblDividerBranches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerBranches.Name = "lblDividerBranches";
            this.lblDividerBranches.Size = new System.Drawing.Size(241, 1);
            this.lblDividerBranches.TabIndex = 17;
            this.lblDividerBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlBranches
            // 
            this.elpnlBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlBranches.AutoSize = true;
            this.elpnlBranches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlBranches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elpnlBranches.Controls.Add(this.linkLabel7);
            this.elpnlBranches.Controls.Add(this.linkLabel8);
            this.elpnlBranches.Controls.Add(this.linkLabel9);
            this.elpnlBranches.ItemsToShow = 2;
            this.elpnlBranches.Location = new System.Drawing.Point(28, 145);
            this.elpnlBranches.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlBranches.Name = "elpnlBranches";
            this.elpnlBranches.Size = new System.Drawing.Size(224, 15);
            this.elpnlBranches.TabIndex = 16;
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(3, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(53, 13);
            this.linkLabel7.TabIndex = 0;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "linkLabel7";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(62, 0);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(53, 13);
            this.linkLabel8.TabIndex = 1;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "linkLabel8";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(121, 0);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(53, 13);
            this.linkLabel9.TabIndex = 2;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "linkLabel9";
            // 
            // lblCommitTags
            // 
            this.lblCommitTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitTags.AutoSize = true;
            this.lblCommitTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommitTags.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitTags.Image = global::GitUI.Properties.Resources.Icon_33;
            this.lblCommitTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitTags.Location = new System.Drawing.Point(11, 179);
            this.lblCommitTags.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitTags.Name = "lblCommitTags";
            this.lblCommitTags.Size = new System.Drawing.Size(241, 15);
            this.lblCommitTags.TabIndex = 18;
            this.lblCommitTags.Text = "       Contained in tags:";
            this.lblCommitTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 1);
            this.label5.TabIndex = 20;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlTags
            // 
            this.elpnlTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlTags.AutoSize = true;
            this.elpnlTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elpnlTags.Controls.Add(this.linkLabel10);
            this.elpnlTags.Controls.Add(this.linkLabel11);
            this.elpnlTags.Controls.Add(this.linkLabel12);
            this.elpnlTags.ItemsToShow = 2;
            this.elpnlTags.Location = new System.Drawing.Point(28, 202);
            this.elpnlTags.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlTags.Name = "elpnlTags";
            this.elpnlTags.Size = new System.Drawing.Size(224, 15);
            this.elpnlTags.TabIndex = 19;
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(3, 0);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(59, 13);
            this.linkLabel10.TabIndex = 0;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "linkLabel10";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(68, 0);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(59, 13);
            this.linkLabel11.TabIndex = 1;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "linkLabel11";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(133, 0);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(59, 13);
            this.linkLabel12.TabIndex = 2;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "linkLabel12";
            // 
            // CommitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flpnlCommitInfoRight);
            this.Name = "CommitDetails";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(303, 493);
            this.flpnlCommitInfoRight.ResumeLayout(false);
            this.flpnlCommitInfoRight.PerformLayout();
            this.elpnlParents.ResumeLayout(false);
            this.elpnlParents.PerformLayout();
            this.elpnlChildren.ResumeLayout(false);
            this.elpnlChildren.PerformLayout();
            this.elpnlBranches.ResumeLayout(false);
            this.elpnlBranches.PerformLayout();
            this.elpnlTags.ResumeLayout(false);
            this.elpnlTags.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlCommitInfoRight;
        private System.Windows.Forms.Label lblCommitParents;
        private System.Windows.Forms.Label lblDivider3;
        private ExpandableListPanel elpnlParents;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label lblCommitChildren;
        private System.Windows.Forms.Label lblDivider4;
        private ExpandableListPanel elpnlChildren;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label lblCommitBranches;
        private System.Windows.Forms.Label lblDividerBranches;
        private ExpandableListPanel elpnlBranches;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.Label lblCommitTags;
        private System.Windows.Forms.Label label5;
        private ExpandableListPanel elpnlTags;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel12;
    }
}
