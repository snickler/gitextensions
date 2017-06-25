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
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commitDetails1 = new GitUI.CommitInfo.CommitExtraDetails();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.commitInfoContextMenuStrip.SuspendLayout();
            this.tlpnlCommitInfoLeft.SuspendLayout();
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
            this.RevisionInfo.Size = new System.Drawing.Size(398, 370);
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
            this.tlpnlCommitInfoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tlpnlCommitInfoLeft.Size = new System.Drawing.Size(250, 386);
            this.tlpnlCommitInfoLeft.TabIndex = 4;
            // 
            // lblCommitterDate
            // 
            this.lblCommitterDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommitterDate.AutoEllipsis = true;
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblCommitterDate, 2);
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
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.llblAuthor, 2);
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
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.lblAuthorDate, 2);
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
            this.tlpnlCommitInfoLeft.SetColumnSpan(this.llblCommitter, 2);
            this.llblCommitter.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblCommitter.Location = new System.Drawing.Point(27, 162);
            this.llblCommitter.Name = "llblCommitter";
            this.llblCommitter.Size = new System.Drawing.Size(209, 13);
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
            this.lblSpacer2.Size = new System.Drawing.Size(212, 1);
            this.lblSpacer2.TabIndex = 12;
            this.lblSpacer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHash
            // 
            this.txtHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblDivider1.Location = new System.Drawing.Point(250, 0);
            this.lblDivider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.lblDivider1.Size = new System.Drawing.Size(1, 386);
            this.lblDivider1.TabIndex = 12;
            this.lblDivider1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDivider2
            // 
            this.lblDivider2.BackColor = System.Drawing.SystemColors.Control;
            this.lblDivider2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDivider2.Location = new System.Drawing.Point(665, 0);
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
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(414, 386);
            this.panel1.TabIndex = 15;
            // 
            // commitDetails1
            // 
            this.commitDetails1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.commitDetails1.Dock = System.Windows.Forms.DockStyle.Right;
            this.commitDetails1.Location = new System.Drawing.Point(669, 0);
            this.commitDetails1.Name = "commitDetails1";
            this.commitDetails1.Padding = new System.Windows.Forms.Padding(8);
            this.commitDetails1.Size = new System.Drawing.Size(224, 386);
            this.commitDetails1.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(666, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 386);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // CommitInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDivider2);
            this.Controls.Add(this.lblDivider1);
            this.Controls.Add(this.tlpnlCommitInfoLeft);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.commitDetails1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CommitInfo";
            this.Size = new System.Drawing.Size(893, 386);
            this.SizeChanged += new System.EventHandler(this.CommitInfo_SizeChanged);
            this.commitInfoContextMenuStrip.ResumeLayout(false);
            this.tlpnlCommitInfoLeft.ResumeLayout(false);
            this.tlpnlCommitInfoLeft.PerformLayout();
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
        private System.Windows.Forms.Label lblDivider2;
        private System.Windows.Forms.Panel panel1;
        private CommitExtraDetails commitDetails1;
        private System.Windows.Forms.Splitter splitter1;
    }
}
