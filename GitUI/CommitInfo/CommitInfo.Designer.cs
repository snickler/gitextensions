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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this._RevisionHeader = new System.Windows.Forms.RichTextBox();
            this.gravatar1 = new GitUI.GravatarControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCommitterDate = new System.Windows.Forms.Label();
            this.llblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblAuthorDate = new System.Windows.Forms.Label();
            this.llblCommitter = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblSpacer1 = new System.Windows.Forms.Label();
            this.lblCommitter = new System.Windows.Forms.Label();
            this.lblSpacer2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHash = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.commitInfoContextMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.38478F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.61522F));
            this.tableLayout.Controls.Add(this.RevisionInfo, 1, 1);
            this.tableLayout.Controls.Add(this._RevisionHeader, 1, 0);
            this.tableLayout.Location = new System.Drawing.Point(284, 51);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.73668F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.26332F));
            this.tableLayout.Size = new System.Drawing.Size(523, 319);
            this.tableLayout.TabIndex = 3;
            // 
            // RevisionInfo
            // 
            this.RevisionInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RevisionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RevisionInfo.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this.RevisionInfo.Location = new System.Drawing.Point(90, 119);
            this.RevisionInfo.Margin = new System.Windows.Forms.Padding(5);
            this.RevisionInfo.Name = "RevisionInfo";
            this.RevisionInfo.ReadOnly = true;
            this.RevisionInfo.Size = new System.Drawing.Size(428, 195);
            this.RevisionInfo.TabIndex = 0;
            this.RevisionInfo.Text = "";
            this.RevisionInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RevisionInfoLinkClicked);
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
            // _RevisionHeader
            // 
            this._RevisionHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this._RevisionHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._RevisionHeader.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this._RevisionHeader.Location = new System.Drawing.Point(89, 2);
            this._RevisionHeader.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this._RevisionHeader.Name = "_RevisionHeader";
            this._RevisionHeader.ReadOnly = true;
            this._RevisionHeader.Size = new System.Drawing.Size(430, 109);
            this._RevisionHeader.TabIndex = 0;
            this._RevisionHeader.Text = "";
            this._RevisionHeader.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this._RevisionHeader_ContentsResized);
            this._RevisionHeader.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RevisionInfoLinkClicked);
            this._RevisionHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RevisionHeader_MouseDown);
            // 
            // gravatar1
            // 
            this.gravatar1.AutoSize = true;
            this.gravatar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gravatar1.Location = new System.Drawing.Point(28, 33);
            this.gravatar1.Margin = new System.Windows.Forms.Padding(4);
            this.gravatar1.MinimumSize = new System.Drawing.Size(20, 20);
            this.gravatar1.Name = "gravatar1";
            this.gravatar1.Size = new System.Drawing.Size(20, 20);
            this.gravatar1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gravatar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitterDate, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.llblAuthor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthorDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.llblCommitter, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblCreatedBy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSpacer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCommitter, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSpacer2, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 386);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblCommitterDate
            // 
            this.lblCommitterDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommitterDate.AutoSize = true;
            this.lblCommitterDate.Location = new System.Drawing.Point(27, 137);
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
            this.llblAuthor.AutoSize = true;
            this.llblAuthor.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblAuthor.Location = new System.Drawing.Point(27, 57);
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
            this.lblAuthorDate.AutoSize = true;
            this.lblAuthorDate.Location = new System.Drawing.Point(27, 70);
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
            this.llblCommitter.AutoSize = true;
            this.llblCommitter.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblCommitter.Location = new System.Drawing.Point(27, 124);
            this.llblCommitter.Name = "llblCommitter";
            this.llblCommitter.Size = new System.Drawing.Size(195, 13);
            this.llblCommitter.TabIndex = 7;
            this.llblCommitter.TabStop = true;
            this.llblCommitter.Text = "Janusz Białobrzewski <jbialobr@o2.pl>";
            this.llblCommitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCreatedBy, 2);
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(11, 8);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(70, 15);
            this.lblCreatedBy.TabIndex = 10;
            this.lblCreatedBy.Text = "Created by:";
            // 
            // lblSpacer1
            // 
            this.lblSpacer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpacer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSpacer1, 2);
            this.lblSpacer1.Location = new System.Drawing.Point(11, 25);
            this.lblSpacer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSpacer1.Name = "lblSpacer1";
            this.lblSpacer1.Size = new System.Drawing.Size(208, 2);
            this.lblSpacer1.TabIndex = 11;
            this.lblSpacer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommitter
            // 
            this.lblCommitter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommitter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCommitter, 2);
            this.lblCommitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommitter.Location = new System.Drawing.Point(11, 103);
            this.lblCommitter.Name = "lblCommitter";
            this.lblCommitter.Size = new System.Drawing.Size(89, 15);
            this.lblCommitter.TabIndex = 6;
            this.lblCommitter.Text = "Committed by:";
            this.lblCommitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpacer2
            // 
            this.lblSpacer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpacer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSpacer2, 2);
            this.lblSpacer2.Location = new System.Drawing.Point(11, 120);
            this.lblSpacer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSpacer2.Name = "lblSpacer2";
            this.lblSpacer2.Size = new System.Drawing.Size(278, 2);
            this.lblSpacer2.TabIndex = 12;
            this.lblSpacer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.lblHash);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(250, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(643, 27);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHash.Location = new System.Drawing.Point(505, 8);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(119, 15);
            this.lblHash.TabIndex = 12;
            this.lblHash.Text = "#253564567567678";
            // 
            // CommitInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CommitInfo";
            this.Size = new System.Drawing.Size(893, 386);
            this.tableLayout.ResumeLayout(false);
            this.commitInfoContextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private GravatarControl gravatar1;
        private System.Windows.Forms.RichTextBox RevisionInfo;
        private System.Windows.Forms.ContextMenuStrip commitInfoContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInTagsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox _RevisionHeader;
        private System.Windows.Forms.ToolStripMenuItem copyCommitInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteIfNoLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessagesOfAnnotatedTagsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel llblAuthor;
        private System.Windows.Forms.Label lblCommitter;
        private System.Windows.Forms.LinkLabel llblCommitter;
        private System.Windows.Forms.Label lblCommitterDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblSpacer1;
        private System.Windows.Forms.Label lblSpacer2;
        private System.Windows.Forms.Label lblAuthorDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblHash;
    }
}
