using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;
using GitUI.CommandsDialogs.BrowseDialog;

namespace GitUI.CommandsDialogs
{
    public class ToolbarManager
    {
        private ToolStripEx ToolStrip;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private ToolStripSplitButton toolStripButtonLevelUp;
        private System.Windows.Forms.ToolStripSplitButton _NO_TRANSLATE_Workingdir;
        private ToolStripSplitButton branchSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitStash;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ToolStripSplitButton toolStripButtonPull;
        private System.Windows.Forms.ToolStripButton toolStripButtonPush;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripFileExplorer;
        private System.Windows.Forms.ToolStripButton GitBash;
        private System.Windows.Forms.ToolStripButton EditSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripBranchFilterComboBox;
        private ToolStripDropDownButton toolStripBranchFilterDropDownButton;
        private ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripLabel toolStripRevisionFilterLabel;
        private ToolStripButton toggleSplitViewLayout;
        private System.Windows.Forms.ToolStripTextBox toolStripRevisionFilterTextBox;
        private ToolStripDropDownButton toolStripRevisionFilterDropDownButton;
        private ToolStripButton ShowFirstParent;
        private System.Windows.Forms.ToolStripMenuItem stashChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stashPopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem viewStashToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private ToolStripMenuItem rebaseToolStripMenuItem1;
        private ToolStripMenuItem fetchToolStripMenuItem;
        private ToolStripMenuItem pullToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem fetchAllToolStripMenuItem;
        private ToolStripMenuItem setNextPullActionAsDefaultToolStripMenuItem;


        public IEnumerable<ToolStrip> Load()
        {
            return null;
        }


        private void Init()
        {
            this.ToolStrip = new GitUI.ToolStripEx();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLevelUp = new System.Windows.Forms.ToolStripSplitButton();
            this._NO_TRANSLATE_Workingdir = new System.Windows.Forms.ToolStripSplitButton();
            this.branchSelect = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitStash = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPull = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButtonPush = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFileExplorer = new System.Windows.Forms.ToolStripButton();
            this.GitBash = new System.Windows.Forms.ToolStripButton();
            this.EditSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBranchFilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBranchFilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRevisionFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.toggleSplitViewLayout = new System.Windows.Forms.ToolStripButton();
            this.toolStripRevisionFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripRevisionFilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ShowFirstParent = new System.Windows.Forms.ToolStripButton();
            this.stashChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stashPopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.viewStashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.pullToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNextPullActionAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.ToolStrip.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ClickThrough = true;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.RefreshButton,
                this.toolStripSeparator17,
                this.toolStripButtonLevelUp,
                this._NO_TRANSLATE_Workingdir,
                this.branchSelect,
                this.toolStripSeparator1,
                this.toolStripSplitStash,
                this.toolStripButton1,
                this.toolStripButtonPull,
                this.toolStripButtonPush,
                this.toolStripSeparator2,
                this.toolStripFileExplorer,
                this.GitBash,
                this.EditSettings,
                this.toolStripSeparator5,
                this.toolStripLabel1,
                this.toolStripBranchFilterComboBox,
                this.toolStripBranchFilterDropDownButton,
                this.toolStripSeparator19,
                this.toolStripRevisionFilterLabel,
                this.toggleSplitViewLayout,
                this.toolStripRevisionFilterTextBox,
                this.toolStripRevisionFilterDropDownButton,
                this.ShowFirstParent});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStrip.Size = new System.Drawing.Size(906, 25);
            this.ToolStrip.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::GitUI.Properties.Resources.arrow_refresh;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.White;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLevelUp
            // 
            this.toolStripButtonLevelUp.AutoToolTip = false;
            this.toolStripButtonLevelUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLevelUp.Image = global::GitUI.Properties.Resources.levelUp;
            this.toolStripButtonLevelUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLevelUp.Name = "toolStripButtonLevelUp";
            this.toolStripButtonLevelUp.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonLevelUp.Text = "Go to superproject";
            this.toolStripButtonLevelUp.ToolTipText = "Go to superproject";
            this.toolStripButtonLevelUp.ButtonClick += new System.EventHandler(this.toolStripButtonLevelUp_ButtonClick);
            this.toolStripButtonLevelUp.DropDownOpening += new System.EventHandler(this.toolStripButtonLevelUp_DropDownOpening);
            // 
            // _NO_TRANSLATE_Workingdir
            // 
            this._NO_TRANSLATE_Workingdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._NO_TRANSLATE_Workingdir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._NO_TRANSLATE_Workingdir.Name = "_NO_TRANSLATE_Workingdir";
            this._NO_TRANSLATE_Workingdir.Size = new System.Drawing.Size(83, 22);
            this._NO_TRANSLATE_Workingdir.Text = "WorkingDir";
            this._NO_TRANSLATE_Workingdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._NO_TRANSLATE_Workingdir.ToolTipText = "Change working directory";
            this._NO_TRANSLATE_Workingdir.ButtonClick += new System.EventHandler(this.WorkingdirClick);
            this._NO_TRANSLATE_Workingdir.DropDownOpening += new System.EventHandler(this.WorkingdirDropDownOpening);
            this._NO_TRANSLATE_Workingdir.MouseUp += new System.Windows.Forms.MouseEventHandler(this._NO_TRANSLATE_Workingdir_MouseUp);
            // 
            // branchSelect
            // 
            this.branchSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.branchSelect.Name = "branchSelect";
            this.branchSelect.Size = new System.Drawing.Size(60, 22);
            this.branchSelect.Text = "Branch";
            this.branchSelect.ToolTipText = "Change current branch";
            this.branchSelect.ButtonClick += new System.EventHandler(this.CurrentBranchClick);
            this.branchSelect.DropDownOpening += new System.EventHandler(this.CurrentBranchDropDownOpening);
            this.branchSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.branchSelect_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitStash
            // 
            this.toolStripSplitStash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.stashChangesToolStripMenuItem,
                this.stashPopToolStripMenuItem,
                this.toolStripSeparator9,
                this.viewStashToolStripMenuItem});
            this.toolStripSplitStash.Image = global::GitUI.Properties.Resources.stash;
            this.toolStripSplitStash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitStash.Name = "toolStripSplitStash";
            this.toolStripSplitStash.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitStash.ToolTipText = "Stash changes";
            this.toolStripSplitStash.ButtonClick += new System.EventHandler(this.ToolStripSplitStashButtonClick);
            this.toolStripSplitStash.DropDownOpened += new System.EventHandler(this.toolStripSplitStash_DropDownOpened);
            // 
            // stashChangesToolStripMenuItem
            // 
            this.stashChangesToolStripMenuItem.Name = "stashChangesToolStripMenuItem";
            this.stashChangesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.stashChangesToolStripMenuItem.Text = "Stash";
            this.stashChangesToolStripMenuItem.ToolTipText = "Stash changes";
            this.stashChangesToolStripMenuItem.Click += new System.EventHandler(this.StashChangesToolStripMenuItemClick);
            // 
            // stashPopToolStripMenuItem
            // 
            this.stashPopToolStripMenuItem.Name = "stashPopToolStripMenuItem";
            this.stashPopToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.stashPopToolStripMenuItem.Text = "Stash pop";
            this.stashPopToolStripMenuItem.ToolTipText = "Apply and drop single stash";
            this.stashPopToolStripMenuItem.Click += new System.EventHandler(this.StashPopToolStripMenuItemClick);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(126, 6);
            // 
            // viewStashToolStripMenuItem
            // 
            this.viewStashToolStripMenuItem.Name = "viewStashToolStripMenuItem";
            this.viewStashToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.viewStashToolStripMenuItem.Text = "View stash";
            this.viewStashToolStripMenuItem.ToolTipText = "View stash";
            this.viewStashToolStripMenuItem.Click += new System.EventHandler(this.ViewStashToolStripMenuItemClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GitUI.Properties.Resources.IconClean;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton1.Text = "Commit";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // toolStripButtonPull
            // 
            this.toolStripButtonPull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPull.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mergeToolStripMenuItem,
                this.rebaseToolStripMenuItem1,
                this.fetchToolStripMenuItem,
                this.toolStripSeparator14,
                this.pullToolStripMenuItem1,
                this.fetchAllToolStripMenuItem,
                this.setNextPullActionAsDefaultToolStripMenuItem});
            this.toolStripButtonPull.Image = global::GitUI.Properties.Resources.IconPull;
            this.toolStripButtonPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPull.Name = "toolStripButtonPull";
            this.toolStripButtonPull.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonPull.Text = "Pull";
            this.toolStripButtonPull.ButtonClick += new System.EventHandler(this.ToolStripButtonPullClick);
            this.toolStripButtonPull.DropDownOpened += new System.EventHandler(this.toolStripButtonPull_DropDownOpened);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Image = global::GitUI.Properties.Resources.PullMerge;
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.mergeToolStripMenuItem.Text = "Pull - merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // rebaseToolStripMenuItem1
            // 
            this.rebaseToolStripMenuItem1.Image = global::GitUI.Properties.Resources.PullRebase;
            this.rebaseToolStripMenuItem1.Name = "rebaseToolStripMenuItem1";
            this.rebaseToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.rebaseToolStripMenuItem1.Text = "Pull - rebase";
            this.rebaseToolStripMenuItem1.Click += new System.EventHandler(this.rebaseToolStripMenuItem1_Click);
            // 
            // fetchToolStripMenuItem
            // 
            this.fetchToolStripMenuItem.Image = global::GitUI.Properties.Resources.PullFetch;
            this.fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            this.fetchToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.fetchToolStripMenuItem.Text = "Fetch";
            this.fetchToolStripMenuItem.Click += new System.EventHandler(this.fetchToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(236, 6);
            // 
            // pullToolStripMenuItem1
            // 
            this.pullToolStripMenuItem1.Image = global::GitUI.Properties.Resources.IconPull;
            this.pullToolStripMenuItem1.Name = "pullToolStripMenuItem1";
            this.pullToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.pullToolStripMenuItem1.Text = "Open pull dialog...";
            this.pullToolStripMenuItem1.Click += new System.EventHandler(this.pullToolStripMenuItem1_Click);
            // 
            // fetchAllToolStripMenuItem
            // 
            this.fetchAllToolStripMenuItem.Image = global::GitUI.Properties.Resources.PullFetchAll;
            this.fetchAllToolStripMenuItem.Name = "fetchAllToolStripMenuItem";
            this.fetchAllToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.fetchAllToolStripMenuItem.Text = "Fetch all";
            this.fetchAllToolStripMenuItem.Click += new System.EventHandler(this.fetchAllToolStripMenuItem_Click);
            // 
            // setNextPullActionAsDefaultToolStripMenuItem
            // 
            this.setNextPullActionAsDefaultToolStripMenuItem.Checked = true;
            this.setNextPullActionAsDefaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setNextPullActionAsDefaultToolStripMenuItem.Name = "setNextPullActionAsDefaultToolStripMenuItem";
            this.setNextPullActionAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.setNextPullActionAsDefaultToolStripMenuItem.Text = "Set the next selection as default";
            this.setNextPullActionAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.dontSetAsDefaultToolStripMenuItem_Click);
            // 
            // toolStripButtonPush
            // 
            this.toolStripButtonPush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPush.Image = global::GitUI.Properties.Resources.IconPush;
            this.toolStripButtonPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPush.Name = "toolStripButtonPush";
            this.toolStripButtonPush.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPush.Text = "Push";
            this.toolStripButtonPush.Click += new System.EventHandler(this.ToolStripButtonPushClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripFileExplorer
            // 
            this.toolStripFileExplorer.CheckOnClick = true;
            this.toolStripFileExplorer.Enabled = false;
            this.toolStripFileExplorer.Image = global::GitUI.Properties.Resources.Folder;
            this.toolStripFileExplorer.ImageTransparentColor = System.Drawing.Color.Gray;
            this.toolStripFileExplorer.Name = "toolStripFileExplorer";
            this.toolStripFileExplorer.Size = new System.Drawing.Size(23, 22);
            this.toolStripFileExplorer.ToolTipText = "File Explorer";
            this.toolStripFileExplorer.Click += new System.EventHandler(this.FileExplorerToolStripMenuItemClick);
            // 
            // GitBash
            // 
            this.GitBash.Image = global::GitUI.Properties.Resources.bash;
            this.GitBash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GitBash.Name = "GitBash";
            this.GitBash.Size = new System.Drawing.Size(23, 22);
            this.GitBash.ToolTipText = "Git bash";
            this.GitBash.Click += new System.EventHandler(this.GitBashClick);
            // 
            // EditSettings
            // 
            this.EditSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditSettings.Image = global::GitUI.Properties.Resources.IconSettingsTools;
            this.EditSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSettings.Name = "EditSettings";
            this.EditSettings.Size = new System.Drawing.Size(23, 22);
            this.EditSettings.ToolTipText = "Settings";
            this.EditSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Branches:";
            // 
            // toolStripBranchFilterComboBox
            // 
            this.toolStripBranchFilterComboBox.AutoSize = false;
            this.toolStripBranchFilterComboBox.DropDownWidth = 300;
            this.toolStripBranchFilterComboBox.Name = "toolStripBranchFilterComboBox";
            this.toolStripBranchFilterComboBox.Size = new System.Drawing.Size(150, 23);
            this.toolStripBranchFilterComboBox.Click += new System.EventHandler(this.toolStripBranchFilterComboBox_Click);
            // 
            // toolStripBranchFilterDropDownButton
            // 
            this.toolStripBranchFilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBranchFilterDropDownButton.Image = global::GitUI.Properties.Resources.Settings;
            this.toolStripBranchFilterDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBranchFilterDropDownButton.Name = "toolStripBranchFilterDropDownButton";
            this.toolStripBranchFilterDropDownButton.Size = new System.Drawing.Size(29, 22);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRevisionFilterLabel
            // 
            this.toolStripRevisionFilterLabel.Name = "toolStripRevisionFilterLabel";
            this.toolStripRevisionFilterLabel.Size = new System.Drawing.Size(36, 22);
            this.toolStripRevisionFilterLabel.Text = "Filter:";
            // 
            // toggleSplitViewLayout
            // 
            this.toggleSplitViewLayout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toggleSplitViewLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleSplitViewLayout.Image = global::GitUI.Properties.Resources.SplitViewLayout;
            this.toggleSplitViewLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleSplitViewLayout.Name = "toggleSplitViewLayout";
            this.toggleSplitViewLayout.Size = new System.Drawing.Size(23, 22);
            this.toggleSplitViewLayout.ToolTipText = "Toggle split view layout";
            this.toggleSplitViewLayout.Click += new System.EventHandler(this.toggleSplitViewLayout_Click);
            // 
            // toolStripRevisionFilterTextBox
            // 
            this.toolStripRevisionFilterTextBox.ForeColor = System.Drawing.Color.Black;
            this.toolStripRevisionFilterTextBox.Name = "toolStripRevisionFilterTextBox";
            this.toolStripRevisionFilterTextBox.Size = new System.Drawing.Size(97, 25);
            // 
            // toolStripRevisionFilterDropDownButton
            // 
            this.toolStripRevisionFilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRevisionFilterDropDownButton.Image = global::GitUI.Properties.Resources.Settings;
            this.toolStripRevisionFilterDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRevisionFilterDropDownButton.Name = "toolStripRevisionFilterDropDownButton";
            this.toolStripRevisionFilterDropDownButton.Size = new System.Drawing.Size(29, 22);
            // 
            // ShowFirstParent
            // 
            this.ShowFirstParent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowFirstParent.Image = global::GitUI.Properties.Resources.IconShowFirstParent;
            this.ShowFirstParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFirstParent.Name = "ShowFirstParent";
            this.ShowFirstParent.Size = new System.Drawing.Size(23, 22);
            this.ShowFirstParent.ToolTipText = "Show first parents";

            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();


        }


        private void RefreshButtonClick(object sender, EventArgs e)
        {
            RefreshToolStripMenuItemClick(sender, e);
        }

        private void WorkingdirClick(object sender, EventArgs e)
        {
            _NO_TRANSLATE_Workingdir.ShowDropDown();
        }

        private void AddWorkingdirDropDownItem(Repository repo, string caption)
        {
            ToolStripMenuItem toolStripItem = new ToolStripMenuItem(caption);
            _NO_TRANSLATE_Workingdir.DropDownItems.Add(toolStripItem);

            toolStripItem.Click += (hs, he) => ChangeWorkingDir(repo.Path);

            if (repo.Title != null || !repo.Path.Equals(caption))
                toolStripItem.ToolTipText = repo.Path;
        }

        private void WorkingdirDropDownOpening(object sender, EventArgs e)
        {
            _NO_TRANSLATE_Workingdir.DropDownItems.Clear();

            List<RecentRepoInfo> mostRecentRepos = new List<RecentRepoInfo>();
            List<RecentRepoInfo> lessRecentRepos = new List<RecentRepoInfo>();

            using (var graphics = CreateGraphics())
            {
                var splitter = new RecentRepoSplitter
                {
                    MeasureFont = _NO_TRANSLATE_Workingdir.Font,
                    Graphics = graphics
                };
                splitter.SplitRecentRepos(Repositories.RepositoryHistory.Repositories, mostRecentRepos, lessRecentRepos);
            }

            foreach (RecentRepoInfo repo in mostRecentRepos)
                AddWorkingdirDropDownItem(repo.Repo, repo.Caption);

            if (lessRecentRepos.Count > 0)
            {
                if (mostRecentRepos.Count > 0 && (AppSettings.SortMostRecentRepos || AppSettings.SortLessRecentRepos))
                    _NO_TRANSLATE_Workingdir.DropDownItems.Add(new ToolStripSeparator());

                foreach (RecentRepoInfo repo in lessRecentRepos)
                    AddWorkingdirDropDownItem(repo.Repo, repo.Caption);
            }

            _NO_TRANSLATE_Workingdir.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem toolStripItem = new ToolStripMenuItem(openToolStripMenuItem.Text);
            toolStripItem.ShortcutKeys = openToolStripMenuItem.ShortcutKeys;
            _NO_TRANSLATE_Workingdir.DropDownItems.Add(toolStripItem);
            toolStripItem.Click += (hs, he) => OpenToolStripMenuItemClick(hs, he);

            toolStripItem = new ToolStripMenuItem(_configureWorkingDirMenu.Text);
            _NO_TRANSLATE_Workingdir.DropDownItems.Add(toolStripItem);
            toolStripItem.Click += (hs, he) =>
            {
                using (var frm = new FormRecentReposSettings()) frm.ShowDialog(this);
                RefreshWorkingDirCombo();
            };

            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void CurrentBranchClick(object sender, EventArgs e)
        {
            branchSelect.ShowDropDown();
        }

        private void ToolStripButtonPushClick(object sender, EventArgs e)
        {
            PushToolStripMenuItemClick(sender, e);
        }

        private void ToolStripSplitStashButtonClick(object sender, EventArgs e)
        {
            UICommands.StartStashDialog(this);
        }

        private void StashChangesToolStripMenuItemClick(object sender, EventArgs e)
        {
            UICommands.StashSave(this, AppSettings.IncludeUntrackedFilesInManualStash);
        }

        private void StashPopToolStripMenuItemClick(object sender, EventArgs e)
        {
            UICommands.StashPop(this);
        }

        private void ViewStashToolStripMenuItemClick(object sender, EventArgs e)
        {
            UICommands.StartStashDialog(this);
        }

        private void GitBashClick(object sender, EventArgs e)
        {
            GitBashToolStripMenuItemClick1(sender, e);
        }

        private void ToolStripButtonPullClick(object sender, EventArgs e)
        {
            PullToolStripMenuItemClick(sender, e);
        }

        private void CurrentBranchDropDownOpening(object sender, EventArgs e)
        {
            branchSelect.DropDownItems.Clear();

            ToolStripMenuItem item = new ToolStripMenuItem(checkoutBranchToolStripMenuItem.Text);
            item.ShortcutKeys = checkoutBranchToolStripMenuItem.ShortcutKeys;
            item.ShortcutKeyDisplayString = checkoutBranchToolStripMenuItem.ShortcutKeyDisplayString;
            branchSelect.DropDownItems.Add(item);
            item.Click += (hs, he) => CheckoutBranchToolStripMenuItemClick(hs, he);

            branchSelect.DropDownItems.Add(new ToolStripSeparator());

            foreach (var branch in Module.GetRefs(false))
            {
                var toolStripItem = branchSelect.DropDownItems.Add(branch.Name);
                toolStripItem.Click += BranchSelectToolStripItem_Click;

                //Make sure there are never more than 100 branches added to the menu
                //GitExtensions will hang when the drop down is to large...
                if (branchSelect.DropDownItems.Count > 100)
                    break;
            }

            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toggleSplitViewLayout_Click(object sender, EventArgs e)
        {
            EnabledSplitViewLayout(MainSplitContainer.Panel2.Height == 0 && MainSplitContainer.Height > 0);
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoPullAction(() =>
                {
                    Module.LastPullAction = AppSettings.PullAction.Merge;
                    PullToolStripMenuItemClick(sender, e);
                }
            );
        }

        private void rebaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoPullAction(() =>
                {
                    Module.LastPullAction = AppSettings.PullAction.Rebase;
                    PullToolStripMenuItemClick(sender, e);
                }
            );
        }

        private void fetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoPullAction(() =>
                {
                    Module.LastPullAction = AppSettings.PullAction.Fetch;
                    PullToolStripMenuItemClick(sender, e);
                }
            );
        }

        private void pullToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AppSettings.SetNextPullActionAsDefault)
                Module.LastPullAction = AppSettings.PullAction.None;
            PullToolStripMenuItemClick(sender, e);

            //restore AppSettings.FormPullAction value
            if (!AppSettings.SetNextPullActionAsDefault)
                Module.LastPullActionToFormPullAction();

            AppSettings.SetNextPullActionAsDefault = false;
        }

        private void _NO_TRANSLATE_Workingdir_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                OpenToolStripMenuItemClick(sender, e);
        }

        private void branchSelect_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                CheckoutBranchToolStripMenuItemClick(sender, e);
        }

        private void toolStripButtonLevelUp_DropDownOpening(object sender, EventArgs e)
        {
            LoadSubmodulesIntoDropDownMenu();
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toolStripButtonLevelUp_ButtonClick(object sender, EventArgs e)
        {
            if (Module.SuperprojectModule != null)
                SetGitModule(this, new GitModuleEventArgs(Module.SuperprojectModule));
            else
                toolStripButtonLevelUp.ShowDropDown();
        }

        private void toolStripButtonPull_DropDownOpened(object sender, EventArgs e)
        {
            setNextPullActionAsDefaultToolStripMenuItem.Checked = AppSettings.SetNextPullActionAsDefault;
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toolStripSplitStash_DropDownOpened(object sender, EventArgs e)
        {
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toolStripBranchFilterComboBox_Click(object sender, EventArgs e)
        {
            toolStripBranchFilterComboBox.DroppedDown = true;
        }


    }
}