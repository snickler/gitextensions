namespace GitUI.CommitInfo
{
    partial class CommitExtraDetails
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elpnlTags = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.lblDividerTags = new System.Windows.Forms.Label();
            this.lblCommitTags = new System.Windows.Forms.Label();
            this.elpnlBranches = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.lblDividerBranches = new System.Windows.Forms.Label();
            this.lblCommitBranches = new System.Windows.Forms.Label();
            this.elpnlChildren = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.lblDividerChildren = new System.Windows.Forms.Label();
            this.lblCommitChildren = new System.Windows.Forms.Label();
            this.elpnlParents = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.lblDividerParents = new System.Windows.Forms.Label();
            this.lblCommitParents = new System.Windows.Forms.Label();
            this.lblCommitLinks = new System.Windows.Forms.Label();
            this.lblDividerLinks = new System.Windows.Forms.Label();
            this.elpnlCommitLinks = new GitUI.CommitInfo.ExpandableListPanel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.pbViewParents = new System.Windows.Forms.PictureBox();
            this.pbViewLinks = new System.Windows.Forms.PictureBox();
            this.pbViewTags = new System.Windows.Forms.PictureBox();
            this.pbViewChildren = new System.Windows.Forms.PictureBox();
            this.pbViewBranches = new System.Windows.Forms.PictureBox();
            this.commitInfoContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmnuShowContainedInBranches = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowContainedInBranchesRemote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowContainedInBranchesRemoteIfNoLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowContainedInTags = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessagesOfAnnotatedTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.elpnlTags.SuspendLayout();
            this.elpnlBranches.SuspendLayout();
            this.elpnlChildren.SuspendLayout();
            this.elpnlParents.SuspendLayout();
            this.elpnlCommitLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewParents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBranches)).BeginInit();
            this.commitInfoContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.elpnlTags, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblDividerTags, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitTags, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.elpnlBranches, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDividerBranches, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitBranches, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.elpnlChildren, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDividerChildren, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitChildren, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.elpnlParents, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDividerParents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitParents, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitLinks, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblDividerLinks, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.elpnlCommitLinks, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.pbViewParents, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbViewLinks, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.pbViewTags, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.pbViewChildren, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbViewBranches, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 292);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // elpnlTags
            // 
            this.elpnlTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlTags.AutoSize = true;
            this.elpnlTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.elpnlTags, 2);
            this.elpnlTags.Controls.Add(this.linkLabel10);
            this.elpnlTags.ItemsToShow = 2;
            this.elpnlTags.Location = new System.Drawing.Point(28, 193);
            this.elpnlTags.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlTags.Name = "elpnlTags";
            this.elpnlTags.Size = new System.Drawing.Size(253, 13);
            this.elpnlTags.TabIndex = 11;
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
            // lblDividerTags
            // 
            this.lblDividerTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerTags.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDividerTags, 2);
            this.lblDividerTags.Location = new System.Drawing.Point(11, 187);
            this.lblDividerTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerTags.Name = "lblDividerTags";
            this.lblDividerTags.Size = new System.Drawing.Size(270, 1);
            this.lblDividerTags.TabIndex = 10;
            this.lblDividerTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitTags
            // 
            this.lblCommitTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitTags.AutoSize = true;
            this.lblCommitTags.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitTags.Image = global::GitUI.Properties.Resources.Icon_33;
            this.lblCommitTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitTags.Location = new System.Drawing.Point(11, 172);
            this.lblCommitTags.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitTags.Name = "lblCommitTags";
            this.lblCommitTags.Size = new System.Drawing.Size(254, 13);
            this.lblCommitTags.TabIndex = 9;
            this.lblCommitTags.Text = "       Contained in tags:";
            this.lblCommitTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlBranches
            // 
            this.elpnlBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlBranches.AutoSize = true;
            this.elpnlBranches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.elpnlBranches, 2);
            this.elpnlBranches.Controls.Add(this.linkLabel7);
            this.elpnlBranches.ItemsToShow = 2;
            this.elpnlBranches.Location = new System.Drawing.Point(28, 140);
            this.elpnlBranches.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlBranches.Name = "elpnlBranches";
            this.elpnlBranches.Size = new System.Drawing.Size(253, 13);
            this.elpnlBranches.TabIndex = 8;
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
            // lblDividerBranches
            // 
            this.lblDividerBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerBranches.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDividerBranches, 2);
            this.lblDividerBranches.Location = new System.Drawing.Point(11, 134);
            this.lblDividerBranches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerBranches.Name = "lblDividerBranches";
            this.lblDividerBranches.Size = new System.Drawing.Size(270, 1);
            this.lblDividerBranches.TabIndex = 7;
            this.lblDividerBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitBranches
            // 
            this.lblCommitBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitBranches.AutoSize = true;
            this.lblCommitBranches.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitBranches.Image = global::GitUI.Properties.Resources.Icon_35;
            this.lblCommitBranches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitBranches.Location = new System.Drawing.Point(11, 119);
            this.lblCommitBranches.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitBranches.Name = "lblCommitBranches";
            this.lblCommitBranches.Size = new System.Drawing.Size(254, 13);
            this.lblCommitBranches.TabIndex = 6;
            this.lblCommitBranches.Text = "       Contained in branches:";
            this.lblCommitBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlChildren
            // 
            this.elpnlChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlChildren.AutoSize = true;
            this.elpnlChildren.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.elpnlChildren, 2);
            this.elpnlChildren.Controls.Add(this.linkLabel4);
            this.elpnlChildren.ItemsToShow = 2;
            this.elpnlChildren.Location = new System.Drawing.Point(28, 87);
            this.elpnlChildren.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlChildren.Name = "elpnlChildren";
            this.elpnlChildren.Size = new System.Drawing.Size(253, 13);
            this.elpnlChildren.TabIndex = 5;
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
            // lblDividerChildren
            // 
            this.lblDividerChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerChildren.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDividerChildren, 2);
            this.lblDividerChildren.Location = new System.Drawing.Point(11, 81);
            this.lblDividerChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerChildren.Name = "lblDividerChildren";
            this.lblDividerChildren.Size = new System.Drawing.Size(270, 1);
            this.lblDividerChildren.TabIndex = 4;
            this.lblDividerChildren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitChildren
            // 
            this.lblCommitChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitChildren.AutoSize = true;
            this.lblCommitChildren.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitChildren.Location = new System.Drawing.Point(11, 66);
            this.lblCommitChildren.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitChildren.Name = "lblCommitChildren";
            this.lblCommitChildren.Size = new System.Drawing.Size(254, 13);
            this.lblCommitChildren.TabIndex = 3;
            this.lblCommitChildren.Text = "Children:";
            // 
            // elpnlParents
            // 
            this.elpnlParents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlParents.AutoSize = true;
            this.elpnlParents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.elpnlParents, 2);
            this.elpnlParents.Controls.Add(this.linkLabel1);
            this.elpnlParents.Controls.Add(this.linkLabel2);
            this.elpnlParents.Controls.Add(this.linkLabel3);
            this.elpnlParents.ItemsToShow = 2;
            this.elpnlParents.Location = new System.Drawing.Point(28, 32);
            this.elpnlParents.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlParents.Name = "elpnlParents";
            this.elpnlParents.Size = new System.Drawing.Size(253, 15);
            this.elpnlParents.TabIndex = 2;
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
            // lblDividerParents
            // 
            this.lblDividerParents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerParents.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDividerParents, 2);
            this.lblDividerParents.Location = new System.Drawing.Point(11, 26);
            this.lblDividerParents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerParents.Name = "lblDividerParents";
            this.lblDividerParents.Size = new System.Drawing.Size(270, 1);
            this.lblDividerParents.TabIndex = 1;
            this.lblDividerParents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitParents
            // 
            this.lblCommitParents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitParents.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitParents.Location = new System.Drawing.Point(11, 8);
            this.lblCommitParents.Name = "lblCommitParents";
            this.lblCommitParents.Size = new System.Drawing.Size(254, 13);
            this.lblCommitParents.TabIndex = 0;
            this.lblCommitParents.Text = "Parent(s):";
            // 
            // lblCommitLinks
            // 
            this.lblCommitLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitLinks.AutoSize = true;
            this.lblCommitLinks.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitLinks.Image = global::GitUI.Properties.Resources.Icon_33;
            this.lblCommitLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitLinks.Location = new System.Drawing.Point(11, 225);
            this.lblCommitLinks.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitLinks.Name = "lblCommitLinks";
            this.lblCommitLinks.Size = new System.Drawing.Size(254, 13);
            this.lblCommitLinks.TabIndex = 12;
            this.lblCommitLinks.Text = "       Related Links:";
            this.lblCommitLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDividerLinks
            // 
            this.lblDividerLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDividerLinks.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDividerLinks, 2);
            this.lblDividerLinks.Location = new System.Drawing.Point(11, 240);
            this.lblDividerLinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDividerLinks.Name = "lblDividerLinks";
            this.lblDividerLinks.Size = new System.Drawing.Size(270, 1);
            this.lblDividerLinks.TabIndex = 13;
            this.lblDividerLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlCommitLinks
            // 
            this.elpnlCommitLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlCommitLinks.AutoSize = true;
            this.elpnlCommitLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.elpnlCommitLinks, 2);
            this.elpnlCommitLinks.Controls.Add(this.linkLabel13);
            this.elpnlCommitLinks.Controls.Add(this.linkLabel15);
            this.elpnlCommitLinks.ItemsToShow = 2;
            this.elpnlCommitLinks.Location = new System.Drawing.Point(28, 246);
            this.elpnlCommitLinks.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlCommitLinks.Name = "elpnlCommitLinks";
            this.elpnlCommitLinks.Size = new System.Drawing.Size(253, 13);
            this.elpnlCommitLinks.TabIndex = 14;
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Location = new System.Drawing.Point(3, 0);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(59, 13);
            this.linkLabel13.TabIndex = 0;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "linkLabel13";
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.Location = new System.Drawing.Point(68, 0);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(59, 13);
            this.linkLabel15.TabIndex = 2;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "linkLabel15";
            // 
            // pbViewParents
            // 
            this.pbViewParents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewParents.Image = global::GitUI.Properties.Resources.eye_closed;
            this.pbViewParents.Location = new System.Drawing.Point(268, 8);
            this.pbViewParents.Margin = new System.Windows.Forms.Padding(0);
            this.pbViewParents.Name = "pbViewParents";
            this.pbViewParents.Size = new System.Drawing.Size(16, 16);
            this.pbViewParents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewParents.TabIndex = 15;
            this.pbViewParents.TabStop = false;
            this.pbViewParents.Click += new System.EventHandler(this.pbViewFeature_Click);
            // 
            // pbViewLinks
            // 
            this.pbViewLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewLinks.Image = global::GitUI.Properties.Resources.eye_closed;
            this.pbViewLinks.Location = new System.Drawing.Point(268, 221);
            this.pbViewLinks.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pbViewLinks.Name = "pbViewLinks";
            this.pbViewLinks.Size = new System.Drawing.Size(16, 17);
            this.pbViewLinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewLinks.TabIndex = 16;
            this.pbViewLinks.TabStop = false;
            this.pbViewLinks.Click += new System.EventHandler(this.pbViewFeature_Click);
            // 
            // pbViewTags
            // 
            this.pbViewTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewTags.Image = global::GitUI.Properties.Resources.eye_opened;
            this.pbViewTags.Location = new System.Drawing.Point(268, 168);
            this.pbViewTags.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pbViewTags.Name = "pbViewTags";
            this.pbViewTags.Size = new System.Drawing.Size(16, 17);
            this.pbViewTags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewTags.TabIndex = 17;
            this.pbViewTags.TabStop = false;
            this.pbViewTags.Click += new System.EventHandler(this.pbViewFeature_Click);
            // 
            // pbViewChildren
            // 
            this.pbViewChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewChildren.Image = global::GitUI.Properties.Resources.eye_closed;
            this.pbViewChildren.Location = new System.Drawing.Point(268, 62);
            this.pbViewChildren.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pbViewChildren.Name = "pbViewChildren";
            this.pbViewChildren.Size = new System.Drawing.Size(16, 17);
            this.pbViewChildren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewChildren.TabIndex = 18;
            this.pbViewChildren.TabStop = false;
            this.pbViewChildren.Click += new System.EventHandler(this.pbViewFeature_Click);
            // 
            // pbViewBranches
            // 
            this.pbViewBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewBranches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewBranches.Image = global::GitUI.Properties.Resources.eye_opened;
            this.pbViewBranches.Location = new System.Drawing.Point(268, 115);
            this.pbViewBranches.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pbViewBranches.Name = "pbViewBranches";
            this.pbViewBranches.Size = new System.Drawing.Size(16, 17);
            this.pbViewBranches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewBranches.TabIndex = 19;
            this.pbViewBranches.TabStop = false;
            this.pbViewBranches.Click += new System.EventHandler(this.pbViewFeature_Click);
            // 
            // commitInfoContextMenuStrip
            // 
            this.commitInfoContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuShowContainedInBranches,
            this.tsmiShowContainedInBranchesRemote,
            this.tsmiShowContainedInBranchesRemoteIfNoLocal,
            this.tsmiShowContainedInTags,
            this.showMessagesOfAnnotatedTagsToolStripMenuItem});
            this.commitInfoContextMenuStrip.Name = "commitInfoContextMenuStrip";
            this.commitInfoContextMenuStrip.Size = new System.Drawing.Size(454, 136);
            // 
            // tsmnuShowContainedInBranches
            // 
            this.tsmnuShowContainedInBranches.Name = "tsmnuShowContainedInBranches";
            this.tsmnuShowContainedInBranches.Size = new System.Drawing.Size(453, 22);
            this.tsmnuShowContainedInBranches.Text = "Show local branches containing this commit";
            this.tsmnuShowContainedInBranches.Click += new System.EventHandler(this.tsmnuShowContainedInBranches_Click);
            // 
            // tsmiShowContainedInBranchesRemote
            // 
            this.tsmiShowContainedInBranchesRemote.Name = "tsmiShowContainedInBranchesRemote";
            this.tsmiShowContainedInBranchesRemote.Size = new System.Drawing.Size(453, 22);
            this.tsmiShowContainedInBranchesRemote.Text = "Show remote branches containing this commit";
            this.tsmiShowContainedInBranchesRemote.Click += new System.EventHandler(this.tsmiShowContainedInBranchesRemote_Click);
            // 
            // tsmiShowContainedInBranchesRemoteIfNoLocal
            // 
            this.tsmiShowContainedInBranchesRemoteIfNoLocal.Name = "tsmiShowContainedInBranchesRemoteIfNoLocal";
            this.tsmiShowContainedInBranchesRemoteIfNoLocal.Size = new System.Drawing.Size(453, 22);
            this.tsmiShowContainedInBranchesRemoteIfNoLocal.Text = "Show remote branches only when no local branch contains this commit";
            this.tsmiShowContainedInBranchesRemoteIfNoLocal.Click += new System.EventHandler(this.tsmiShowContainedInBranchesRemoteIfNoLocal_Click);
            // 
            // tsmiShowContainedInTags
            // 
            this.tsmiShowContainedInTags.Name = "tsmiShowContainedInTags";
            this.tsmiShowContainedInTags.Size = new System.Drawing.Size(453, 22);
            this.tsmiShowContainedInTags.Text = "Show tags containing this commit";
            this.tsmiShowContainedInTags.Click += new System.EventHandler(this.tsmiShowContainedInTags_Click);
            // 
            // showMessagesOfAnnotatedTagsToolStripMenuItem
            // 
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Name = "showMessagesOfAnnotatedTagsToolStripMenuItem";
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Text = "Show messages of annotated tags";
            // 
            // CommitExtraDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "CommitExtraDetails";
            this.Size = new System.Drawing.Size(292, 292);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.elpnlTags.ResumeLayout(false);
            this.elpnlTags.PerformLayout();
            this.elpnlBranches.ResumeLayout(false);
            this.elpnlBranches.PerformLayout();
            this.elpnlChildren.ResumeLayout(false);
            this.elpnlChildren.PerformLayout();
            this.elpnlParents.ResumeLayout(false);
            this.elpnlParents.PerformLayout();
            this.elpnlCommitLinks.ResumeLayout(false);
            this.elpnlCommitLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewParents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBranches)).EndInit();
            this.commitInfoContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCommitParents;
        private System.Windows.Forms.Label lblDividerParents;
        private ExpandableListPanel elpnlParents;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label lblCommitChildren;
        private System.Windows.Forms.Label lblDividerChildren;
        private ExpandableListPanel elpnlChildren;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label lblCommitBranches;
        private System.Windows.Forms.Label lblDividerBranches;
        private ExpandableListPanel elpnlBranches;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.Label lblCommitTags;
        private System.Windows.Forms.Label lblDividerTags;
        private ExpandableListPanel elpnlTags;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCommitLinks;
        private System.Windows.Forms.Label lblDividerLinks;
        private ExpandableListPanel elpnlCommitLinks;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.PictureBox pbViewParents;
        private System.Windows.Forms.PictureBox pbViewLinks;
        private System.Windows.Forms.PictureBox pbViewTags;
        private System.Windows.Forms.PictureBox pbViewChildren;
        private System.Windows.Forms.PictureBox pbViewBranches;
        private System.Windows.Forms.ContextMenuStrip commitInfoContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmnuShowContainedInBranches;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowContainedInBranchesRemote;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowContainedInBranchesRemoteIfNoLocal;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowContainedInTags;
        private System.Windows.Forms.ToolStripMenuItem showMessagesOfAnnotatedTagsToolStripMenuItem;
    }
}
