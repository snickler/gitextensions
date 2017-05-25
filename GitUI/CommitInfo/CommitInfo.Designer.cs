namespace GitUI.CommitInfo
{
    partial class CommitInfo
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
            this.RevisionInfo = new System.Windows.Forms.RichTextBox();
            this.commitInfoContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommitInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showContainedInBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInBranchesRemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessagesOfAnnotatedTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravatar1 = new GitUI.GravatarControl();
            this.tlpnlCommitInfoLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblCommitterDate = new System.Windows.Forms.Label();
            this.llblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblAuthorDate = new System.Windows.Forms.Label();
            this.llblCommitter = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblSpacer1 = new System.Windows.Forms.Label();
            this.lblCommitter = new System.Windows.Forms.Label();
            this.lblSpacer2 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.flpnlCommitInfoRight = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commitInfoContextMenuStrip.SuspendLayout();
            this.tlpnlCommitInfoLeft.SuspendLayout();
            this.flpnlCommitInfoRight.SuspendLayout();
            this.elpnlParents.SuspendLayout();
            this.elpnlChildren.SuspendLayout();
            this.elpnlBranches.SuspendLayout();
            this.elpnlTags.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RevisionInfo
            // 
            this.RevisionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RevisionInfo.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this.RevisionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionInfo.Location = new System.Drawing.Point(8, 8);
            this.RevisionInfo.Name = "RevisionInfo";
            this.RevisionInfo.ReadOnly = true;
            this.RevisionInfo.Size = new System.Drawing.Size(413, 370);
            this.RevisionInfo.TabIndex = 0;
            this.RevisionInfo.Text = "";
            this.RevisionInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RevisionInfoLinkClicked);
            this.RevisionInfo.VScroll += new System.EventHandler(this.RevisionInfo_VScroll);
            this.RevisionInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RevisionHeader_MouseDown);
            // 
            // commitInfoContextMenuStrip
            // 
            this.commitInfoContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommitInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.showContainedInBranchesToolStripMenuItem,
            this.showContainedInBranchesRemoteToolStripMenuItem,
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem,
            this.showContainedInTagsToolStripMenuItem,
            this.showMessagesOfAnnotatedTagsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNoteToolStripMenuItem});
            this.commitInfoContextMenuStrip.Name = "commitInfoContextMenuStrip";
            this.commitInfoContextMenuStrip.Size = new System.Drawing.Size(454, 170);
            // 
            // copyCommitInfoToolStripMenuItem
            // 
            this.copyCommitInfoToolStripMenuItem.Image = global::GitUI.Properties.Resources.IconCopyToClipboard;
            this.copyCommitInfoToolStripMenuItem.Name = "copyCommitInfoToolStripMenuItem";
            this.copyCommitInfoToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.copyCommitInfoToolStripMenuItem.Text = "Copy commit info";
            this.copyCommitInfoToolStripMenuItem.Click += new System.EventHandler(this.copyCommitInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(450, 6);
            // 
            // showContainedInBranchesToolStripMenuItem
            // 
            this.showContainedInBranchesToolStripMenuItem.Name = "showContainedInBranchesToolStripMenuItem";
            this.showContainedInBranchesToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesToolStripMenuItem.Text = "Show local branches containing this commit";
            this.showContainedInBranchesToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesToolStripMenuItem_Click);
            // 
            // showContainedInBranchesRemoteToolStripMenuItem
            // 
            this.showContainedInBranchesRemoteToolStripMenuItem.Name = "showContainedInBranchesRemoteToolStripMenuItem";
            this.showContainedInBranchesRemoteToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesRemoteToolStripMenuItem.Text = "Show remote branches containing this commit";
            this.showContainedInBranchesRemoteToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesRemoteToolStripMenuItem_Click);
            // 
            // showContainedInBranchesRemoteIfNoLocalToolStripMenuItem
            // 
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Name = "showContainedInBranchesRemoteIfNoLocalToolStripMenuItem";
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Text = "Show remote branches only when no local branch contains this commit";
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem_Click);
            // 
            // showContainedInTagsToolStripMenuItem
            // 
            this.showContainedInTagsToolStripMenuItem.Name = "showContainedInTagsToolStripMenuItem";
            this.showContainedInTagsToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInTagsToolStripMenuItem.Text = "Show tags containing this commit";
            this.showContainedInTagsToolStripMenuItem.Click += new System.EventHandler(this.showContainedInTagsToolStripMenuItem_Click);
            // 
            // showMessagesOfAnnotatedTagsToolStripMenuItem
            // 
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Name = "showMessagesOfAnnotatedTagsToolStripMenuItem";
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Text = "Show messages of annotated tags";
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Click += new System.EventHandler(this.showMessagesOfAnnotatedTagsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(450, 6);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Image = global::GitUI.Properties.Resources.IconEditFile;
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.addNoteToolStripMenuItem.Text = "Add notes";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // gravatar1
            // 
            this.gravatar1.AutoSize = true;
            this.gravatar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gravatar1.Location = new System.Drawing.Point(28, 72);
            this.gravatar1.Margin = new System.Windows.Forms.Padding(4);
            this.gravatar1.MinimumSize = new System.Drawing.Size(20, 20);
            this.gravatar1.Name = "gravatar1";
            this.gravatar1.Size = new System.Drawing.Size(20, 20);
            this.gravatar1.TabIndex = 1;
            this.gravatar1.GravatarSizeChanged += new System.EventHandler(this.gravatar1_GravatarSizeChanged);
            // 
            // tlpnlCommitInfoLeft
            // 
            this.tlpnlCommitInfoLeft.AutoSize = true;
            this.tlpnlCommitInfoLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpnlCommitInfoLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpnlCommitInfoLeft.ColumnCount = 3;
            this.tlpnlCommitInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpnlCommitInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlCommitInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpnlCommitInfoLeft.Controls.Add(this.gravatar1, 1, 4);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblCommitterDate, 1, 11);
            this.tlpnlCommitInfoLeft.Controls.Add(this.llblAuthor, 1, 5);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblAuthorDate, 1, 6);
            this.tlpnlCommitInfoLeft.Controls.Add(this.llblCommitter, 1, 10);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblCreatedBy, 0, 2);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblSpacer1, 0, 3);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblCommitter, 0, 8);
            this.tlpnlCommitInfoLeft.Controls.Add(this.lblSpacer2, 0, 9);
            this.tlpnlCommitInfoLeft.Controls.Add(this.txtHash, 0, 0);
            this.tlpnlCommitInfoLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpnlCommitInfoLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpnlCommitInfoLeft.MinimumSize = new System.Drawing.Size(250, 0);
            this.tlpnlCommitInfoLeft.Name = "tlpnlCommitInfoLeft";
            this.tlpnlCommitInfoLeft.Padding = new System.Windows.Forms.Padding(8);
            this.tlpnlCommitInfoLeft.RowCount = 13;
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlCommitInfoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlCommitInfoLeft.Size = new System.Drawing.Size(267, 386);
            this.tlpnlCommitInfoLeft.TabIndex = 4;
            // 
            // lblCommitterDate
            // 
            this.lblCommitterDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommitterDate.AutoEllipsis = true;
            this.lblCommitterDate.Location = new System.Drawing.Point(27, 175);
            this.lblCommitterDate.Name = "lblCommitterDate";
            this.lblCommitterDate.Size = new System.Drawing.Size(173, 13);
            this.lblCommitterDate.TabIndex = 8;
            this.lblCommitterDate.Text = "5 days ago (16/5/17 11:31:21 pm)";
            this.lblCommitterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llblAuthor
            // 
            this.llblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblAuthor.AutoEllipsis = true;
            this.llblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAuthor.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblAuthor.Location = new System.Drawing.Point(27, 96);
            this.llblAuthor.Name = "llblAuthor";
            this.llblAuthor.Size = new System.Drawing.Size(125, 13);
            this.llblAuthor.TabIndex = 3;
            this.llblAuthor.TabStop = true;
            this.llblAuthor.Text = "RussKie <russkie@mac>";
            this.llblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorDate
            // 
            this.lblAuthorDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuthorDate.AutoEllipsis = true;
            this.lblAuthorDate.Location = new System.Drawing.Point(27, 109);
            this.lblAuthorDate.Name = "lblAuthorDate";
            this.lblAuthorDate.Size = new System.Drawing.Size(169, 13);
            this.lblAuthorDate.TabIndex = 5;
            this.lblAuthorDate.Text = "1 week ago (15/5/17 9:18:23 pm)";
            this.lblAuthorDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llblCommitter
            // 
            this.llblCommitter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblCommitter.AutoEllipsis = true;
            this.llblCommitter.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblCommitter.Location = new System.Drawing.Point(27, 162);
            this.llblCommitter.Name = "llblCommitter";
            this.llblCommitter.Size = new System.Drawing.Size(212, 13);
            this.llblCommitter.TabIndex = 7;
            this.llblCommitter.TabStop = true;
            this.llblCommitter.Text = "Janusz Białobrzewski <jbialobr@o2.hotmail.pl>";
            this.llblCommitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblCreatedBy, 2);
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCreatedBy.Location = new System.Drawing.Point(11, 48);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(174, 15);
            this.lblCreatedBy.TabIndex = 10;
            this.lblCreatedBy.Text = "Created by:";
            // 
            // lblSpacer1
            // 
            this.lblSpacer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpacer1.BackColor = System.Drawing.SystemColors.Control;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblSpacer1, 2);
            this.lblSpacer1.Location = new System.Drawing.Point(11, 65);
            this.lblSpacer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSpacer1.Name = "lblSpacer1";
            this.lblSpacer1.Size = new System.Drawing.Size(208, 1);
            this.lblSpacer1.TabIndex = 11;
            this.lblSpacer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitter
            // 
            this.lblCommitter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblCommitter, 2);
            this.lblCommitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommitter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitter.Location = new System.Drawing.Point(11, 142);
            this.lblCommitter.Name = "lblCommitter";
            this.lblCommitter.Size = new System.Drawing.Size(189, 15);
            this.lblCommitter.TabIndex = 6;
            this.lblCommitter.Text = "Committed by:";
            this.lblCommitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpacer2
            // 
            this.lblSpacer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpacer2.BackColor = System.Drawing.SystemColors.Control;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblSpacer2, 2);
            this.lblSpacer2.Location = new System.Drawing.Point(11, 159);
            this.lblSpacer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSpacer2.Name = "lblSpacer2";
            this.lblSpacer2.Size = new System.Drawing.Size(229, 1);
            this.lblSpacer2.TabIndex = 12;
            this.lblSpacer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHash
            // 
            this.txtHash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHash.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.txtHash, 3);
            this.txtHash.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtHash.Location = new System.Drawing.Point(11, 11);
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(228, 15);
            this.txtHash.TabIndex = 12;
            this.txtHash.Text = "253564567567678";
            this.txtHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDivider1
            // 
            this.lblDivider1.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDivider1.Location = new System.Drawing.Point(267, 0);
            this.lblDivider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.lblDivider1.Size = new System.Drawing.Size(1, 386);
            this.lblDivider1.TabIndex = 12;
            this.lblDivider1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpnlCommitInfoRight
            // 
            this.flpnlCommitInfoRight.Controls.Add(this.label1);
            this.flpnlCommitInfoRight.Controls.Add(this.lblDivider3);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlParents);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitChildren);
            this.flpnlCommitInfoRight.Controls.Add(this.lblDivider4);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlChildren);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitBranches);
            this.flpnlCommitInfoRight.Controls.Add(this.label3);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlBranches);
            this.flpnlCommitInfoRight.Controls.Add(this.lblCommitTags);
            this.flpnlCommitInfoRight.Controls.Add(this.label5);
            this.flpnlCommitInfoRight.Controls.Add(this.elpnlTags);
            this.flpnlCommitInfoRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpnlCommitInfoRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlCommitInfoRight.Location = new System.Drawing.Point(698, 0);
            this.flpnlCommitInfoRight.Name = "flpnlCommitInfoRight";
            this.flpnlCommitInfoRight.Padding = new System.Windows.Forms.Padding(8);
            this.flpnlCommitInfoRight.Size = new System.Drawing.Size(195, 386);
            this.flpnlCommitInfoRight.TabIndex = 13;
            this.flpnlCommitInfoRight.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parent(s):";
            // 
            // lblDivider3
            // 
            this.lblDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider3.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider3.Location = new System.Drawing.Point(11, 23);
            this.lblDivider3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider3.Name = "lblDivider3";
            this.lblDivider3.Size = new System.Drawing.Size(166, 1);
            this.lblDivider3.TabIndex = 14;
            this.lblDivider3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlParents
            // 
            this.elpnlParents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlParents.AutoSize = true;
            this.elpnlParents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlParents.Controls.Add(this.linkLabel1);
            this.elpnlParents.Controls.Add(this.linkLabel2);
            this.elpnlParents.Controls.Add(this.linkLabel3);
            this.elpnlParents.ItemsToShow = 2;
            this.elpnlParents.Location = new System.Drawing.Point(28, 29);
            this.elpnlParents.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlParents.Name = "elpnlParents";
            this.elpnlParents.Size = new System.Drawing.Size(149, 30);
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
            this.linkLabel3.Location = new System.Drawing.Point(3, 15);
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
            this.lblCommitChildren.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitChildren.Location = new System.Drawing.Point(11, 78);
            this.lblCommitChildren.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitChildren.Name = "lblCommitChildren";
            this.lblCommitChildren.Size = new System.Drawing.Size(166, 13);
            this.lblCommitChildren.TabIndex = 2;
            this.lblCommitChildren.Text = "Children:";
            // 
            // lblDivider4
            // 
            this.lblDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider4.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider4.Location = new System.Drawing.Point(11, 93);
            this.lblDivider4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider4.Name = "lblDivider4";
            this.lblDivider4.Size = new System.Drawing.Size(166, 1);
            this.lblDivider4.TabIndex = 13;
            this.lblDivider4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlChildren
            // 
            this.elpnlChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlChildren.AutoSize = true;
            this.elpnlChildren.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlChildren.Controls.Add(this.linkLabel4);
            this.elpnlChildren.Controls.Add(this.linkLabel5);
            this.elpnlChildren.Controls.Add(this.linkLabel6);
            this.elpnlChildren.ItemsToShow = 2;
            this.elpnlChildren.Location = new System.Drawing.Point(28, 99);
            this.elpnlChildren.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlChildren.Name = "elpnlChildren";
            this.elpnlChildren.Size = new System.Drawing.Size(149, 26);
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
            this.linkLabel6.Location = new System.Drawing.Point(3, 13);
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
            this.lblCommitBranches.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitBranches.Image = global::GitUI.Properties.Resources.Icon_35;
            this.lblCommitBranches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitBranches.Location = new System.Drawing.Point(11, 144);
            this.lblCommitBranches.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitBranches.Name = "lblCommitBranches";
            this.lblCommitBranches.Size = new System.Drawing.Size(166, 13);
            this.lblCommitBranches.TabIndex = 15;
            this.lblCommitBranches.Text = "       Contained in branches:";
            this.lblCommitBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 1);
            this.label3.TabIndex = 17;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlBranches
            // 
            this.elpnlBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlBranches.AutoSize = true;
            this.elpnlBranches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlBranches.Controls.Add(this.linkLabel7);
            this.elpnlBranches.Controls.Add(this.linkLabel8);
            this.elpnlBranches.Controls.Add(this.linkLabel9);
            this.elpnlBranches.ItemsToShow = 2;
            this.elpnlBranches.Location = new System.Drawing.Point(28, 165);
            this.elpnlBranches.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlBranches.Name = "elpnlBranches";
            this.elpnlBranches.Size = new System.Drawing.Size(149, 26);
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
            this.linkLabel9.Location = new System.Drawing.Point(3, 13);
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
            this.lblCommitTags.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCommitTags.Image = global::GitUI.Properties.Resources.Icon_33;
            this.lblCommitTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommitTags.Location = new System.Drawing.Point(11, 210);
            this.lblCommitTags.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.lblCommitTags.Name = "lblCommitTags";
            this.lblCommitTags.Size = new System.Drawing.Size(166, 13);
            this.lblCommitTags.TabIndex = 18;
            this.lblCommitTags.Text = "       Contained in tags:";
            this.lblCommitTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 1);
            this.label5.TabIndex = 20;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elpnlTags
            // 
            this.elpnlTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elpnlTags.AutoSize = true;
            this.elpnlTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elpnlTags.Controls.Add(this.linkLabel10);
            this.elpnlTags.Controls.Add(this.linkLabel11);
            this.elpnlTags.Controls.Add(this.linkLabel12);
            this.elpnlTags.ItemsToShow = 2;
            this.elpnlTags.Location = new System.Drawing.Point(28, 231);
            this.elpnlTags.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.elpnlTags.Name = "elpnlTags";
            this.elpnlTags.Size = new System.Drawing.Size(149, 26);
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
            this.linkLabel12.Location = new System.Drawing.Point(3, 13);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(59, 13);
            this.linkLabel12.TabIndex = 2;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "linkLabel12";
            // 
            // lblDivider2
            // 
            this.lblDivider2.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDivider2.Location = new System.Drawing.Point(697, 0);
            this.lblDivider2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider2.Name = "lblDivider2";
            this.lblDivider2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.lblDivider2.Size = new System.Drawing.Size(1, 386);
            this.lblDivider2.TabIndex = 14;
            this.lblDivider2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RevisionInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(429, 386);
            this.panel1.TabIndex = 15;
            // 
            // CommitInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDivider2);
            this.Controls.Add(this.flpnlCommitInfoRight);
            this.Controls.Add(this.lblDivider1);
            this.Controls.Add(this.tlpnlCommitInfoLeft);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CommitInfo";
            this.Size = new System.Drawing.Size(893, 386);
            this.commitInfoContextMenuStrip.ResumeLayout(false);
            this.tlpnlCommitInfoLeft.ResumeLayout(false);
            this.tlpnlCommitInfoLeft.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GravatarControl gravatar1;
        private System.Windows.Forms.RichTextBox RevisionInfo;
        private System.Windows.Forms.ContextMenuStrip commitInfoContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteIfNoLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessagesOfAnnotatedTagsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpnlCommitInfoLeft;
        private System.Windows.Forms.LinkLabel llblAuthor;
        private System.Windows.Forms.Label lblCommitter;
        private System.Windows.Forms.LinkLabel llblCommitter;
        private System.Windows.Forms.Label lblCommitterDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblSpacer1;
        private System.Windows.Forms.Label lblSpacer2;
        private System.Windows.Forms.Label lblAuthorDate;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblDivider1;
        private System.Windows.Forms.FlowLayoutPanel flpnlCommitInfoRight;
        private ExpandableListPanel elpnlParents;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCommitChildren;
        private ExpandableListPanel elpnlChildren;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label lblDivider2;
        private System.Windows.Forms.Label lblDivider3;
        private System.Windows.Forms.Label lblDivider4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCommitBranches;
        private System.Windows.Forms.Label label3;
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
