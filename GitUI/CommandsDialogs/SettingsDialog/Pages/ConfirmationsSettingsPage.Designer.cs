﻿namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    partial class ConfirmationsSettingsPage
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
            if (disposing && (components is not null))
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
            System.Windows.Forms.Label lblGroupCommits;
            System.Windows.Forms.Label lblGroupBranches;
            System.Windows.Forms.Label lblGroupStashes;
            System.Windows.Forms.Label lblGroupConflictResolution;
            System.Windows.Forms.Label lblGroupSubmodules;
            System.Windows.Forms.Label lblGroupWorktrees;
            this.tlpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbConfirmations = new System.Windows.Forms.GroupBox();
            this.tlpnlConfirmations = new System.Windows.Forms.TableLayoutPanel();
            this.chkAmend = new System.Windows.Forms.CheckBox();
            this.chkUndoLastCommitConfirmation = new System.Windows.Forms.CheckBox();
            this.chkCommitIfNoBranch = new System.Windows.Forms.CheckBox();
            this.chkRebaseOnTopOfSelectedCommit = new System.Windows.Forms.CheckBox();
            this.chkFetchAndPruneAllConfirmation = new System.Windows.Forms.CheckBox();
            this.chkPushNewBranch = new System.Windows.Forms.CheckBox();
            this.chkAddTrackingRef = new System.Windows.Forms.CheckBox();
            this.chkAutoPopStashAfterCheckout = new System.Windows.Forms.CheckBox();
            this.chkAutoPopStashAfterPull = new System.Windows.Forms.CheckBox();
            this.chkConfirmStashDrop = new System.Windows.Forms.CheckBox();
            this.chkResolveConflicts = new System.Windows.Forms.CheckBox();
            this.chkCommitAfterConflictsResolved = new System.Windows.Forms.CheckBox();
            this.chkSwitchWorktree = new System.Windows.Forms.CheckBox();
            this.chkUpdateModules = new System.Windows.Forms.CheckBox();
            this.chkSecondAbortConfirmation = new System.Windows.Forms.CheckBox();
            lblGroupCommits = new System.Windows.Forms.Label();
            lblGroupBranches = new System.Windows.Forms.Label();
            lblGroupStashes = new System.Windows.Forms.Label();
            lblGroupConflictResolution = new System.Windows.Forms.Label();
            lblGroupSubmodules = new System.Windows.Forms.Label();
            lblGroupWorktrees = new System.Windows.Forms.Label();
            this.tlpnlMain.SuspendLayout();
            this.gbConfirmations.SuspendLayout();
            this.tlpnlConfirmations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGroupCommits
            // 
            lblGroupCommits.AutoSize = true;
            lblGroupCommits.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupCommits.Location = new System.Drawing.Point(3, 0);
            lblGroupCommits.Name = "lblGroupCommits";
            lblGroupCommits.Size = new System.Drawing.Size(1331, 15);
            lblGroupCommits.Text = "Commits:";
            // 
            // lblGroupBranches
            // 
            lblGroupBranches.AutoSize = true;
            lblGroupBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupBranches.Location = new System.Drawing.Point(3, 127);
            lblGroupBranches.Name = "lblGroupBranches";
            lblGroupBranches.Size = new System.Drawing.Size(1331, 15);
            lblGroupBranches.Text = "Branches:";
            // 
            // lblGroupStashes
            // 
            lblGroupStashes.AutoSize = true;
            lblGroupStashes.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupStashes.Location = new System.Drawing.Point(3, 229);
            lblGroupStashes.Name = "lblGroupStashes";
            lblGroupStashes.Size = new System.Drawing.Size(1331, 15);
            lblGroupStashes.Text = "Stash:";
            // 
            // lblGroupConflictResolution
            // 
            lblGroupConflictResolution.AutoSize = true;
            lblGroupConflictResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupConflictResolution.Location = new System.Drawing.Point(3, 331);
            lblGroupConflictResolution.Name = "lblGroupConflictResolution";
            lblGroupConflictResolution.Size = new System.Drawing.Size(1331, 15);
            lblGroupConflictResolution.Text = "Rebase / Conflict Resolution:";
            // 
            // tlpnlMain
            // 
            this.tlpnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpnlMain.ColumnCount = 1;
            this.tlpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlMain.Controls.Add(this.gbConfirmations, 0, 0);
            this.tlpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tlpnlMain.Name = "tlpnlMain";
            this.tlpnlMain.RowCount = 2;
            this.tlpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlMain.Size = new System.Drawing.Size(1359, 693);
            // 
            // gbConfirmations
            // 
            this.gbConfirmations.AutoSize = true;
            this.gbConfirmations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbConfirmations.Controls.Add(this.tlpnlConfirmations);
            this.gbConfirmations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConfirmations.Location = new System.Drawing.Point(3, 3);
            this.gbConfirmations.Name = "gbConfirmations";
            this.gbConfirmations.Padding = new System.Windows.Forms.Padding(8);
            this.gbConfirmations.Size = new System.Drawing.Size(1353, 542);
            this.gbConfirmations.TabStop = false;
            this.gbConfirmations.Text = "Don\'t ask to confirm to (use with caution)";
            // 
            // tlpnlConfirmations
            // 
            this.tlpnlConfirmations.AutoSize = true;
            this.tlpnlConfirmations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpnlConfirmations.ColumnCount = 1;
            this.tlpnlConfirmations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlConfirmations.Controls.Add(lblGroupCommits, 0, 0);
            this.tlpnlConfirmations.Controls.Add(this.chkAmend, 0, 1);
            this.tlpnlConfirmations.Controls.Add(this.chkUndoLastCommitConfirmation, 0, 2);
            this.tlpnlConfirmations.Controls.Add(this.chkCommitIfNoBranch, 0, 3);
            this.tlpnlConfirmations.Controls.Add(this.chkRebaseOnTopOfSelectedCommit, 0, 4);
            this.tlpnlConfirmations.Controls.Add(lblGroupBranches, 0, 6);
            this.tlpnlConfirmations.Controls.Add(this.chkFetchAndPruneAllConfirmation, 0, 7);
            this.tlpnlConfirmations.Controls.Add(this.chkPushNewBranch, 0, 8);
            this.tlpnlConfirmations.Controls.Add(this.chkAddTrackingRef, 0, 9);
            this.tlpnlConfirmations.Controls.Add(lblGroupStashes, 0, 11);
            this.tlpnlConfirmations.Controls.Add(this.chkAutoPopStashAfterCheckout, 0, 12);
            this.tlpnlConfirmations.Controls.Add(this.chkAutoPopStashAfterPull, 0, 13);
            this.tlpnlConfirmations.Controls.Add(this.chkConfirmStashDrop, 0, 14);
            this.tlpnlConfirmations.Controls.Add(lblGroupConflictResolution, 0, 16);
            this.tlpnlConfirmations.Controls.Add(this.chkResolveConflicts, 0, 17);
            this.tlpnlConfirmations.Controls.Add(this.chkCommitAfterConflictsResolved, 0, 18);
            this.tlpnlConfirmations.Controls.Add(this.chkSecondAbortConfirmation, 0, 19);
            this.tlpnlConfirmations.Controls.Add(lblGroupSubmodules, 0, 21);
            this.tlpnlConfirmations.Controls.Add(this.chkUpdateModules, 0, 22);
            this.tlpnlConfirmations.Controls.Add(lblGroupWorktrees, 0, 24);
            this.tlpnlConfirmations.Controls.Add(this.chkSwitchWorktree, 0, 25);
            this.tlpnlConfirmations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlConfirmations.Location = new System.Drawing.Point(8, 24);
            this.tlpnlConfirmations.Name = "tlpnlConfirmations";
            this.tlpnlConfirmations.RowCount = 26;
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlConfirmations.Size = new System.Drawing.Size(1337, 510);
            // 
            // chkAmend
            // 
            this.chkAmend.AutoSize = true;
            this.chkAmend.Location = new System.Drawing.Point(3, 18);
            this.chkAmend.Name = "chkAmend";
            this.chkAmend.Size = new System.Drawing.Size(131, 19);
            this.chkAmend.Text = "Amend last commit";
            this.chkAmend.UseVisualStyleBackColor = true;
            // 
            // chkUndoLastCommitConfirmation
            // 
            this.chkUndoLastCommitConfirmation.AutoSize = true;
            this.chkUndoLastCommitConfirmation.Location = new System.Drawing.Point(3, 43);
            this.chkUndoLastCommitConfirmation.Name = "chkUndoLastCommitConfirmation";
            this.chkUndoLastCommitConfirmation.Size = new System.Drawing.Size(121, 19);
            this.chkUndoLastCommitConfirmation.Text = "Undo last commit";
            this.chkUndoLastCommitConfirmation.ThreeState = true;
            this.chkUndoLastCommitConfirmation.UseVisualStyleBackColor = true;
            // 
            // chkCommitIfNoBranch
            // 
            this.chkCommitIfNoBranch.AutoSize = true;
            this.chkCommitIfNoBranch.Location = new System.Drawing.Point(3, 68);
            this.chkCommitIfNoBranch.Name = "chkCommitIfNoBranch";
            this.chkCommitIfNoBranch.Size = new System.Drawing.Size(372, 19);
            this.chkCommitIfNoBranch.Text = "Commit when no branch is currently checked out (headless state)";
            this.chkCommitIfNoBranch.UseVisualStyleBackColor = true;
            // 
            // chkRebaseOnTopOfSelectedCommit
            // 
            this.chkRebaseOnTopOfSelectedCommit.AutoSize = true;
            this.chkRebaseOnTopOfSelectedCommit.Location = new System.Drawing.Point(3, 93);
            this.chkRebaseOnTopOfSelectedCommit.Name = "chkRebaseOnTopOfSelectedCommit";
            this.chkRebaseOnTopOfSelectedCommit.Size = new System.Drawing.Size(206, 19);
            this.chkRebaseOnTopOfSelectedCommit.Text = "Rebase on top of selected commit";
            this.chkRebaseOnTopOfSelectedCommit.ThreeState = true;
            this.chkRebaseOnTopOfSelectedCommit.UseVisualStyleBackColor = true;
            // 
            // chkFetchAndPruneAllConfirmation
            // 
            this.chkFetchAndPruneAllConfirmation.AutoSize = true;
            this.chkFetchAndPruneAllConfirmation.Location = new System.Drawing.Point(3, 145);
            this.chkFetchAndPruneAllConfirmation.Name = "chkFetchAndPruneAllConfirmation";
            this.chkFetchAndPruneAllConfirmation.Size = new System.Drawing.Size(163, 19);
            this.chkFetchAndPruneAllConfirmation.Text = "Fetch and prune branches";
            this.chkFetchAndPruneAllConfirmation.UseVisualStyleBackColor = true;
            // 
            // chkPushNewBranch
            // 
            this.chkPushNewBranch.AutoSize = true;
            this.chkPushNewBranch.Location = new System.Drawing.Point(3, 170);
            this.chkPushNewBranch.Name = "chkPushNewBranch";
            this.chkPushNewBranch.Size = new System.Drawing.Size(205, 19);
            this.chkPushNewBranch.Text = "Push a new branch for the remote";
            this.chkPushNewBranch.UseVisualStyleBackColor = true;
            // 
            // chkAddTrackingRef
            // 
            this.chkAddTrackingRef.AutoSize = true;
            this.chkAddTrackingRef.Location = new System.Drawing.Point(3, 195);
            this.chkAddTrackingRef.Name = "chkAddTrackingRef";
            this.chkAddTrackingRef.Size = new System.Drawing.Size(289, 19);
            this.chkAddTrackingRef.Text = "Add a tracking reference for newly pushed branch";
            this.chkAddTrackingRef.UseVisualStyleBackColor = true;
            // 
            // chkAutoPopStashAfterCheckout
            // 
            this.chkAutoPopStashAfterCheckout.AutoSize = true;
            this.chkAutoPopStashAfterCheckout.Location = new System.Drawing.Point(3, 247);
            this.chkAutoPopStashAfterCheckout.Name = "chkAutoPopStashAfterCheckout";
            this.chkAutoPopStashAfterCheckout.Size = new System.Drawing.Size(477, 19);
            this.chkAutoPopStashAfterCheckout.Text = "Apply stashed changes after successful checkout (stash will be popped automatically)";
            this.chkAutoPopStashAfterCheckout.ThreeState = true;
            this.chkAutoPopStashAfterCheckout.UseVisualStyleBackColor = true;
            // 
            // chkAutoPopStashAfterPull
            // 
            this.chkAutoPopStashAfterPull.AutoSize = true;
            this.chkAutoPopStashAfterPull.Location = new System.Drawing.Point(3, 272);
            this.chkAutoPopStashAfterPull.Name = "chkAutoPopStashAfterPull";
            this.chkAutoPopStashAfterPull.Size = new System.Drawing.Size(448, 19);
            this.chkAutoPopStashAfterPull.Text = "Apply stashed changes after successful pull (stash will be popped automatically)";
            this.chkAutoPopStashAfterPull.ThreeState = true;
            this.chkAutoPopStashAfterPull.UseVisualStyleBackColor = true;
            // 
            // chkConfirmStashDrop
            // 
            this.chkConfirmStashDrop.AutoSize = true;
            this.chkConfirmStashDrop.Location = new System.Drawing.Point(3, 297);
            this.chkConfirmStashDrop.Name = "chkConfirmStashDrop";
            this.chkConfirmStashDrop.Size = new System.Drawing.Size(82, 19);
            this.chkConfirmStashDrop.Text = "Drop stash";
            this.chkConfirmStashDrop.UseVisualStyleBackColor = true;
            // 
            // chkResolveConflicts
            // 
            this.chkResolveConflicts.AutoSize = true;
            this.chkResolveConflicts.Location = new System.Drawing.Point(3, 349);
            this.chkResolveConflicts.Name = "chkResolveConflicts";
            this.chkResolveConflicts.Size = new System.Drawing.Size(114, 19);
            this.chkResolveConflicts.Text = "Resolve conflicts";
            this.chkResolveConflicts.ThreeState = true;
            this.chkResolveConflicts.UseVisualStyleBackColor = true;
            // 
            // chkCommitAfterConflictsResolved
            // 
            this.chkCommitAfterConflictsResolved.AutoSize = true;
            this.chkCommitAfterConflictsResolved.Location = new System.Drawing.Point(3, 374);
            this.chkCommitAfterConflictsResolved.Name = "chkCommitAfterConflictsResolved";
            this.chkCommitAfterConflictsResolved.Size = new System.Drawing.Size(296, 19);
            this.chkCommitAfterConflictsResolved.Text = "Commit changes after conflicts have been resolved";
            this.chkCommitAfterConflictsResolved.ThreeState = true;
            this.chkCommitAfterConflictsResolved.UseVisualStyleBackColor = true;
            // 
            // chkSwitchWorktree
            // 
            this.chkSwitchWorktree.AutoSize = true;
            this.chkSwitchWorktree.Location = new System.Drawing.Point(3, 488);
            this.chkSwitchWorktree.Name = "chkSwitchWorktree";
            this.chkSwitchWorktree.Size = new System.Drawing.Size(112, 19);
            this.chkSwitchWorktree.Text = "Switch Worktree";
            this.chkSwitchWorktree.UseVisualStyleBackColor = true;
            // 
            // chkUpdateModules
            // 
            this.chkUpdateModules.AutoSize = true;
            this.chkUpdateModules.Location = new System.Drawing.Point(3, 451);
            this.chkUpdateModules.Name = "chkUpdateModules";
            this.chkUpdateModules.Size = new System.Drawing.Size(201, 19);
            this.chkUpdateModules.Text = "Update submodules on checkout";
            this.chkUpdateModules.ThreeState = true;
            this.chkUpdateModules.UseVisualStyleBackColor = true;
            // 
            // chkSecondAbortConfirmation
            // 
            this.chkSecondAbortConfirmation.AutoSize = true;
            this.chkSecondAbortConfirmation.Location = new System.Drawing.Point(3, 399);
            this.chkSecondAbortConfirmation.Name = "chkSecondAbortConfirmation";
            this.chkSecondAbortConfirmation.Size = new System.Drawing.Size(267, 19);
            this.chkSecondAbortConfirmation.Text = "Confirm for the second time to abort a merge";
            this.chkSecondAbortConfirmation.ThreeState = true;
            this.chkSecondAbortConfirmation.UseVisualStyleBackColor = true;
            // 
            // lblGroupSubmodules
            // 
            lblGroupSubmodules.AutoSize = true;
            lblGroupSubmodules.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupSubmodules.Location = new System.Drawing.Point(3, 433);
            lblGroupSubmodules.Name = "lblGroupSubmodules";
            lblGroupSubmodules.Size = new System.Drawing.Size(1331, 15);
            lblGroupSubmodules.Text = "Submodules:";
            // 
            // lblGroupWorktrees
            // 
            lblGroupWorktrees.AutoSize = true;
            lblGroupWorktrees.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGroupWorktrees.Location = new System.Drawing.Point(3, 473);
            lblGroupWorktrees.Name = "lblGroupWorktrees";
            lblGroupWorktrees.Size = new System.Drawing.Size(1331, 12);
            lblGroupWorktrees.Text = "Worktrees:";
            // 
            // ConfirmationsSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tlpnlMain);
            this.Name = "ConfirmationsSettingsPage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1375, 709);
            this.tlpnlMain.ResumeLayout(false);
            this.tlpnlMain.PerformLayout();
            this.gbConfirmations.ResumeLayout(false);
            this.gbConfirmations.PerformLayout();
            this.tlpnlConfirmations.ResumeLayout(false);
            this.tlpnlConfirmations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpnlMain;
        private System.Windows.Forms.GroupBox gbConfirmations;
        private System.Windows.Forms.TableLayoutPanel tlpnlConfirmations;
        private System.Windows.Forms.CheckBox chkAmend;
        private System.Windows.Forms.CheckBox chkAutoPopStashAfterPull;
        private System.Windows.Forms.CheckBox chkPushNewBranch;
        private System.Windows.Forms.CheckBox chkAddTrackingRef;
        private System.Windows.Forms.CheckBox chkAutoPopStashAfterCheckout;
        private System.Windows.Forms.CheckBox chkConfirmStashDrop;
        private System.Windows.Forms.CheckBox chkUpdateModules;
        private System.Windows.Forms.CheckBox chkCommitIfNoBranch;
        private System.Windows.Forms.CheckBox chkCommitAfterConflictsResolved;
        private System.Windows.Forms.CheckBox chkResolveConflicts;
        private System.Windows.Forms.CheckBox chkSecondAbortConfirmation;
        private System.Windows.Forms.CheckBox chkRebaseOnTopOfSelectedCommit;
        private System.Windows.Forms.CheckBox chkUndoLastCommitConfirmation;
        private System.Windows.Forms.CheckBox chkFetchAndPruneAllConfirmation;
        private System.Windows.Forms.CheckBox chkSwitchWorktree;
    }
}
