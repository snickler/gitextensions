namespace GitUI.CommitInfo
{
    partial class CommitBasicDetails
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
            this.tlpnlCommitInfoLeft = new System.Windows.Forms.TableLayoutPanel();
            this.gravatar1 = new GitUI.GravatarControl();
            this.lblCommitterDate = new System.Windows.Forms.Label();
            this.llblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblAuthorDate = new System.Windows.Forms.Label();
            this.llblCommitter = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblSpacer1 = new System.Windows.Forms.Label();
            this.lblCommitter = new System.Windows.Forms.Label();
            this.lblSpacer2 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.tlpnlCommitInfoLeft.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpnlCommitInfoLeft.Size = new System.Drawing.Size(250, 305);
            this.tlpnlCommitInfoLeft.TabIndex = 5;
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
            // CommitBasicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpnlCommitInfoLeft);
            this.Name = "CommitBasicDetails";
            this.Size = new System.Drawing.Size(266, 305);
            this.tlpnlCommitInfoLeft.ResumeLayout(false);
            this.tlpnlCommitInfoLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpnlCommitInfoLeft;
        private GravatarControl gravatar1;
        private System.Windows.Forms.Label lblCommitterDate;
        private System.Windows.Forms.LinkLabel llblAuthor;
        private System.Windows.Forms.Label lblAuthorDate;
        private System.Windows.Forms.LinkLabel llblCommitter;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblSpacer1;
        private System.Windows.Forms.Label lblCommitter;
        private System.Windows.Forms.Label lblSpacer2;
        private System.Windows.Forms.TextBox txtHash;
    }
}
