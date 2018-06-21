
namespace GitUI.CommandsDialogs
{
    partial class FormRemotes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.flpnlRemoteManagement = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.pnlMgtPuttySsh = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PuttySshKey = new System.Windows.Forms.TextBox();
            this.SshBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TestConnection = new System.Windows.Forms.Button();
            this.LoadSSHKey = new System.Windows.Forms.Button();
            this.lblMgtPuttyPanelHeader = new System.Windows.Forms.Label();
            this.lblHeaderLine2 = new System.Windows.Forms.Label();
            this.pnlMgtDetails = new System.Windows.Forms.Panel();
            this.tblpnlMgtDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserButtonPushUrl = new GitUI.UserControls.FolderBrowserButton();
            this.comboBoxPushUrl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Url = new System.Windows.Forms.ComboBox();
            this.labelPushUrl = new System.Windows.Forms.Label();
            this.folderBrowserButtonUrl = new GitUI.UserControls.FolderBrowserButton();
            this.checkBoxSepPushUrl = new System.Windows.Forms.CheckBox();
            this.RemoteName = new System.Windows.Forms.TextBox();
            this.pnlManagementContainer = new System.Windows.Forms.Panel();
            this.gbMgtPanel = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnToggleState = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remotes = new GitUI.UserControls.NativeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpnlMainBehaviours = new System.Windows.Forms.TableLayoutPanel();
            this.RemoteBranches = new System.Windows.Forms.DataGridView();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoteCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MergeWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UpdateBranch = new System.Windows.Forms.Button();
            this.Prune = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveDefaultPushPull = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DefaultMergeWithCombo = new System.Windows.Forms.ComboBox();
            this.RemoteRepositoryCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LocalBranchNameEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flpnlRemoteManagement.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlMgtPuttySsh.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnlMgtDetails.SuspendLayout();
            this.tblpnlMgtDetails.SuspendLayout();
            this.pnlManagementContainer.SuspendLayout();
            this.gbMgtPanel.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpnlMainBehaviours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteBranches)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnlRemoteManagement
            // 
            this.flpnlRemoteManagement.AutoSize = true;
            this.flpnlRemoteManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlRemoteManagement.ColumnCount = 1;
            this.flpnlRemoteManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flpnlRemoteManagement.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.flpnlRemoteManagement.Controls.Add(this.pnlMgtPuttySsh, 0, 1);
            this.flpnlRemoteManagement.Controls.Add(this.pnlMgtDetails, 0, 0);
            this.flpnlRemoteManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlRemoteManagement.Location = new System.Drawing.Point(6, 32);
            this.flpnlRemoteManagement.Margin = new System.Windows.Forms.Padding(6);
            this.flpnlRemoteManagement.Name = "flpnlRemoteManagement";
            this.flpnlRemoteManagement.RowCount = 3;
            this.flpnlRemoteManagement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flpnlRemoteManagement.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flpnlRemoteManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flpnlRemoteManagement.Size = new System.Drawing.Size(998, 587);
            this.flpnlRemoteManagement.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.Save);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 519);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(986, 62);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Image = global::GitUI.Properties.Resources.IconSave;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(680, 6);
            this.Save.Margin = new System.Windows.Forms.Padding(6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(260, 50);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveClick);
            // 
            // pnlMgtPuttySsh
            // 
            this.pnlMgtPuttySsh.AutoSize = true;
            this.pnlMgtPuttySsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMgtPuttySsh.Controls.Add(this.tableLayoutPanel1);
            this.pnlMgtPuttySsh.Controls.Add(this.lblMgtPuttyPanelHeader);
            this.pnlMgtPuttySsh.Controls.Add(this.lblHeaderLine2);
            this.pnlMgtPuttySsh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMgtPuttySsh.Location = new System.Drawing.Point(6, 317);
            this.pnlMgtPuttySsh.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMgtPuttySsh.Name = "pnlMgtPuttySsh";
            this.pnlMgtPuttySsh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.pnlMgtPuttySsh.Size = new System.Drawing.Size(986, 190);
            this.pnlMgtPuttySsh.TabIndex = 1;
            this.pnlMgtPuttySsh.Text = "PuTTY SSH";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.PuttySshKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SshBrowse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 132);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // PuttySshKey
            // 
            this.PuttySshKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PuttySshKey.Location = new System.Drawing.Point(218, 6);
            this.PuttySshKey.Margin = new System.Windows.Forms.Padding(6);
            this.PuttySshKey.Name = "PuttySshKey";
            this.PuttySshKey.Size = new System.Drawing.Size(466, 33);
            this.PuttySshKey.TabIndex = 1;
            // 
            // SshBrowse
            // 
            this.SshBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SshBrowse.Image = global::GitUI.Properties.Resources.New;
            this.SshBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SshBrowse.Location = new System.Drawing.Point(696, 6);
            this.SshBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.SshBrowse.MinimumSize = new System.Drawing.Size(208, 0);
            this.SshBrowse.Name = "SshBrowse";
            this.SshBrowse.Size = new System.Drawing.Size(208, 62);
            this.SshBrowse.TabIndex = 2;
            this.SshBrowse.Text = " Browse...";
            this.SshBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SshBrowse.UseVisualStyleBackColor = true;
            this.SshBrowse.Click += new System.EventHandler(this.SshBrowseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.MinimumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 74);
            this.label3.TabIndex = 0;
            this.label3.Text = "Private key file";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.TestConnection);
            this.flowLayoutPanel3.Controls.Add(this.LoadSSHKey);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(212, 74);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(698, 58);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // TestConnection
            // 
            this.TestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestConnection.Image = global::GitUI.Properties.Resources.putty;
            this.TestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestConnection.Location = new System.Drawing.Point(372, 6);
            this.TestConnection.Margin = new System.Windows.Forms.Padding(6);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(320, 46);
            this.TestConnection.TabIndex = 1;
            this.TestConnection.Text = "Test connection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnectionClick);
            // 
            // LoadSSHKey
            // 
            this.LoadSSHKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSSHKey.Image = global::GitUI.Properties.Resources.putty;
            this.LoadSSHKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadSSHKey.Location = new System.Drawing.Point(40, 6);
            this.LoadSSHKey.Margin = new System.Windows.Forms.Padding(6);
            this.LoadSSHKey.Name = "LoadSSHKey";
            this.LoadSSHKey.Size = new System.Drawing.Size(320, 46);
            this.LoadSSHKey.TabIndex = 0;
            this.LoadSSHKey.Text = "Load SSH key";
            this.LoadSSHKey.UseVisualStyleBackColor = true;
            this.LoadSSHKey.Click += new System.EventHandler(this.LoadSshKeyClick);
            // 
            // lblMgtPuttyPanelHeader
            // 
            this.lblMgtPuttyPanelHeader.AutoSize = true;
            this.lblMgtPuttyPanelHeader.Location = new System.Drawing.Point(16, 0);
            this.lblMgtPuttyPanelHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMgtPuttyPanelHeader.Name = "lblMgtPuttyPanelHeader";
            this.lblMgtPuttyPanelHeader.Size = new System.Drawing.Size(117, 25);
            this.lblMgtPuttyPanelHeader.TabIndex = 0;
            this.lblMgtPuttyPanelHeader.Text = "PuTTY SSH";
            // 
            // lblHeaderLine2
            // 
            this.lblHeaderLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeaderLine2.Location = new System.Drawing.Point(32, 16);
            this.lblHeaderLine2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeaderLine2.Name = "lblHeaderLine2";
            this.lblHeaderLine2.Size = new System.Drawing.Size(932, 6);
            this.lblHeaderLine2.TabIndex = 1;
            // 
            // pnlMgtDetails
            // 
            this.pnlMgtDetails.AutoSize = true;
            this.pnlMgtDetails.Controls.Add(this.tblpnlMgtDetails);
            this.pnlMgtDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMgtDetails.Location = new System.Drawing.Point(6, 6);
            this.pnlMgtDetails.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMgtDetails.Name = "pnlMgtDetails";
            this.pnlMgtDetails.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.pnlMgtDetails.Size = new System.Drawing.Size(986, 299);
            this.pnlMgtDetails.TabIndex = 0;
            this.pnlMgtDetails.Text = "Details";
            // 
            // tblpnlMgtDetails
            // 
            this.tblpnlMgtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnlMgtDetails.AutoSize = true;
            this.tblpnlMgtDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblpnlMgtDetails.ColumnCount = 3;
            this.tblpnlMgtDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlMgtDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMgtDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tblpnlMgtDetails.Controls.Add(this.label1, 0, 0);
            this.tblpnlMgtDetails.Controls.Add(this.folderBrowserButtonPushUrl, 2, 3);
            this.tblpnlMgtDetails.Controls.Add(this.label2, 0, 1);
            this.tblpnlMgtDetails.Controls.Add(this.Url, 1, 1);
            this.tblpnlMgtDetails.Controls.Add(this.comboBoxPushUrl, 1, 3);
            this.tblpnlMgtDetails.Controls.Add(this.labelPushUrl, 0, 3);
            this.tblpnlMgtDetails.Controls.Add(this.folderBrowserButtonUrl, 2, 1);
            this.tblpnlMgtDetails.Controls.Add(this.checkBoxSepPushUrl, 0, 2);
            this.tblpnlMgtDetails.Controls.Add(this.RemoteName, 1, 0);
            this.tblpnlMgtDetails.Location = new System.Drawing.Point(32, 22);
            this.tblpnlMgtDetails.Margin = new System.Windows.Forms.Padding(6);
            this.tblpnlMgtDetails.Name = "tblpnlMgtDetails";
            this.tblpnlMgtDetails.RowCount = 4;
            this.tblpnlMgtDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMgtDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMgtDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMgtDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMgtDetails.Size = new System.Drawing.Size(910, 255);
            this.tblpnlMgtDetails.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MinimumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // folderBrowserButtonPushUrl
            // 
            this.folderBrowserButtonPushUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderBrowserButtonPushUrl.Location = new System.Drawing.Point(696, 183);
            this.folderBrowserButtonPushUrl.Margin = new System.Windows.Forms.Padding(6);
            this.folderBrowserButtonPushUrl.Name = "folderBrowserButtonPushUrl";
            this.folderBrowserButtonPushUrl.PathShowingControl = this.comboBoxPushUrl;
            this.folderBrowserButtonPushUrl.Size = new System.Drawing.Size(208, 66);
            this.folderBrowserButtonPushUrl.TabIndex = 8;
            this.folderBrowserButtonPushUrl.Visible = false;
            // 
            // comboBoxPushUrl
            // 
            this.comboBoxPushUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPushUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPushUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPushUrl.FormattingEnabled = true;
            this.comboBoxPushUrl.Location = new System.Drawing.Point(218, 183);
            this.comboBoxPushUrl.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPushUrl.Name = "comboBoxPushUrl";
            this.comboBoxPushUrl.Size = new System.Drawing.Size(466, 33);
            this.comboBoxPushUrl.TabIndex = 7;
            this.comboBoxPushUrl.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Url
            // 
            this.Url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Url.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Url.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Url.FormattingEnabled = true;
            this.Url.Location = new System.Drawing.Point(218, 64);
            this.Url.Margin = new System.Windows.Forms.Padding(6);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(466, 33);
            this.Url.TabIndex = 3;
            // 
            // labelPushUrl
            // 
            this.labelPushUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPushUrl.Location = new System.Drawing.Point(6, 177);
            this.labelPushUrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPushUrl.Name = "labelPushUrl";
            this.labelPushUrl.Size = new System.Drawing.Size(200, 78);
            this.labelPushUrl.TabIndex = 6;
            this.labelPushUrl.Text = "Push Url";
            this.labelPushUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPushUrl.Visible = false;
            // 
            // folderBrowserButtonUrl
            // 
            this.folderBrowserButtonUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderBrowserButtonUrl.Location = new System.Drawing.Point(696, 64);
            this.folderBrowserButtonUrl.Margin = new System.Windows.Forms.Padding(6);
            this.folderBrowserButtonUrl.Name = "folderBrowserButtonUrl";
            this.folderBrowserButtonUrl.PathShowingControl = this.Url;
            this.folderBrowserButtonUrl.Size = new System.Drawing.Size(208, 66);
            this.folderBrowserButtonUrl.TabIndex = 4;
            // 
            // checkBoxSepPushUrl
            // 
            this.checkBoxSepPushUrl.AutoSize = true;
            this.tblpnlMgtDetails.SetColumnSpan(this.checkBoxSepPushUrl, 2);
            this.checkBoxSepPushUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSepPushUrl.Location = new System.Drawing.Point(6, 142);
            this.checkBoxSepPushUrl.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxSepPushUrl.Name = "checkBoxSepPushUrl";
            this.checkBoxSepPushUrl.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.checkBoxSepPushUrl.Size = new System.Drawing.Size(678, 29);
            this.checkBoxSepPushUrl.TabIndex = 5;
            this.checkBoxSepPushUrl.Text = "Separate Push Url";
            this.checkBoxSepPushUrl.UseVisualStyleBackColor = true;
            this.checkBoxSepPushUrl.CheckedChanged += new System.EventHandler(this.checkBoxSepPushUrl_CheckedChanged);
            // 
            // RemoteName
            // 
            this.RemoteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoteName.Location = new System.Drawing.Point(218, 6);
            this.RemoteName.Margin = new System.Windows.Forms.Padding(6);
            this.RemoteName.Name = "RemoteName";
            this.RemoteName.Size = new System.Drawing.Size(466, 33);
            this.RemoteName.TabIndex = 1;
            this.RemoteName.TextChanged += new System.EventHandler(this.RemoteName_TextChanged);
            // 
            // pnlManagementContainer
            // 
            this.pnlManagementContainer.Controls.Add(this.gbMgtPanel);
            this.pnlManagementContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagementContainer.Location = new System.Drawing.Point(394, 6);
            this.pnlManagementContainer.Margin = new System.Windows.Forms.Padding(6);
            this.pnlManagementContainer.Name = "pnlManagementContainer";
            this.pnlManagementContainer.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.pnlManagementContainer.Size = new System.Drawing.Size(1042, 627);
            this.pnlManagementContainer.TabIndex = 0;
            // 
            // gbMgtPanel
            // 
            this.gbMgtPanel.AutoSize = true;
            this.gbMgtPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbMgtPanel.Controls.Add(this.flpnlRemoteManagement);
            this.gbMgtPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMgtPanel.Location = new System.Drawing.Point(16, 8);
            this.gbMgtPanel.Margin = new System.Windows.Forms.Padding(6);
            this.gbMgtPanel.Name = "gbMgtPanel";
            this.gbMgtPanel.Padding = new System.Windows.Forms.Padding(6);
            this.gbMgtPanel.Size = new System.Drawing.Size(1010, 625);
            this.gbMgtPanel.TabIndex = 0;
            this.gbMgtPanel.TabStop = false;
            this.gbMgtPanel.Text = "Create New Remote";
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.Controls.Add(this.New);
            this.panelButtons.Controls.Add(this.Delete);
            this.panelButtons.Controls.Add(this.btnToggleState);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelButtons.Location = new System.Drawing.Point(300, 16);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(16);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(72, 595);
            this.panelButtons.TabIndex = 1;
            // 
            // New
            // 
            this.New.Image = global::GitUI.Properties.Resources.IconMaintenance;
            this.New.Location = new System.Drawing.Point(14, 6);
            this.New.Margin = new System.Windows.Forms.Padding(6);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(52, 52);
            this.New.TabIndex = 0;
            this.toolTip1.SetToolTip(this.New, "Add new remote");
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.NewClick);
            // 
            // Delete
            // 
            this.Delete.Image = global::GitUI.Properties.Resources.IconDeleteRemote;
            this.Delete.Location = new System.Drawing.Point(14, 70);
            this.Delete.Margin = new System.Windows.Forms.Padding(6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(52, 52);
            this.Delete.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Delete, "Delete the selected remote");
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.DeleteClick);
            // 
            // btnToggleState
            // 
            this.btnToggleState.Image = global::GitUI.Properties.Resources.eye_opened;
            this.btnToggleState.Location = new System.Drawing.Point(14, 134);
            this.btnToggleState.Margin = new System.Windows.Forms.Padding(6);
            this.btnToggleState.Name = "btnToggleState";
            this.btnToggleState.Size = new System.Drawing.Size(52, 52);
            this.btnToggleState.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnToggleState, "Enable or disable the selected remote");
            this.btnToggleState.UseVisualStyleBackColor = true;
            this.btnToggleState.Click += new System.EventHandler(this.btnToggleState_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1458, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlManagementContainer);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1442, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote repositories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Remotes);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(388, 627);
            this.panel1.TabIndex = 0;
            // 
            // Remotes
            // 
            this.Remotes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Remotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Remotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remotes.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.Remotes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.Remotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Remotes.HideSelection = false;
            this.Remotes.LabelWrap = false;
            this.Remotes.Location = new System.Drawing.Point(16, 16);
            this.Remotes.Margin = new System.Windows.Forms.Padding(6);
            this.Remotes.MultiSelect = false;
            this.Remotes.Name = "Remotes";
            this.Remotes.Size = new System.Drawing.Size(284, 595);
            this.Remotes.TabIndex = 1;
            this.Remotes.TileSize = new System.Drawing.Size(136, 18);
            this.Remotes.UseCompatibleStateImageBehavior = false;
            this.Remotes.View = System.Windows.Forms.View.Details;
            this.Remotes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Remotes_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpnlMainBehaviours);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1442, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Default pull behavior (fetch & merge)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpnlMainBehaviours
            // 
            this.tlpnlMainBehaviours.ColumnCount = 1;
            this.tlpnlMainBehaviours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlMainBehaviours.Controls.Add(this.RemoteBranches, 0, 0);
            this.tlpnlMainBehaviours.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tlpnlMainBehaviours.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlpnlMainBehaviours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlMainBehaviours.Location = new System.Drawing.Point(6, 6);
            this.tlpnlMainBehaviours.Margin = new System.Windows.Forms.Padding(6);
            this.tlpnlMainBehaviours.Name = "tlpnlMainBehaviours";
            this.tlpnlMainBehaviours.RowCount = 3;
            this.tlpnlMainBehaviours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlMainBehaviours.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlMainBehaviours.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlMainBehaviours.Size = new System.Drawing.Size(1430, 627);
            this.tlpnlMainBehaviours.TabIndex = 12;
            // 
            // RemoteBranches
            // 
            this.RemoteBranches.AllowUserToAddRows = false;
            this.RemoteBranches.AllowUserToDeleteRows = false;
            this.RemoteBranches.AllowUserToResizeRows = false;
            this.RemoteBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoteBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RemoteBranches.BackgroundColor = System.Drawing.SystemColors.Window;
            this.RemoteBranches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemoteBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemoteBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchName,
            this.RemoteCombo,
            this.MergeWith});
            this.RemoteBranches.GridColor = System.Drawing.SystemColors.ControlLight;
            this.RemoteBranches.Location = new System.Drawing.Point(6, 6);
            this.RemoteBranches.Margin = new System.Windows.Forms.Padding(6);
            this.RemoteBranches.MultiSelect = false;
            this.RemoteBranches.Name = "RemoteBranches";
            this.RemoteBranches.ReadOnly = true;
            this.RemoteBranches.RowHeadersVisible = false;
            this.RemoteBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemoteBranches.Size = new System.Drawing.Size(1448, 353);
            this.RemoteBranches.TabIndex = 0;
            this.RemoteBranches.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.RemoteBranchesDataError);
            // 
            // BranchName
            // 
            this.BranchName.HeaderText = "Local branch name";
            this.BranchName.Name = "BranchName";
            this.BranchName.ReadOnly = true;
            // 
            // RemoteCombo
            // 
            this.RemoteCombo.HeaderText = "Remote repository";
            this.RemoteCombo.Name = "RemoteCombo";
            this.RemoteCombo.ReadOnly = true;
            // 
            // MergeWith
            // 
            this.MergeWith.HeaderText = "Default merge with";
            this.MergeWith.Name = "MergeWith";
            this.MergeWith.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.UpdateBranch);
            this.flowLayoutPanel1.Controls.Add(this.Prune);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 574);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1448, 47);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // UpdateBranch
            // 
            this.UpdateBranch.AutoSize = true;
            this.UpdateBranch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBranch.Location = new System.Drawing.Point(1138, 6);
            this.UpdateBranch.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateBranch.Name = "UpdateBranch";
            this.UpdateBranch.Size = new System.Drawing.Size(304, 35);
            this.UpdateBranch.TabIndex = 1;
            this.UpdateBranch.Text = "Update all remote branch info";
            this.UpdateBranch.UseVisualStyleBackColor = true;
            this.UpdateBranch.Click += new System.EventHandler(this.UpdateBranchClick);
            // 
            // Prune
            // 
            this.Prune.AutoSize = true;
            this.Prune.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Prune.Location = new System.Drawing.Point(884, 6);
            this.Prune.Margin = new System.Windows.Forms.Padding(6);
            this.Prune.Name = "Prune";
            this.Prune.Size = new System.Drawing.Size(242, 35);
            this.Prune.TabIndex = 0;
            this.Prune.Text = "Prune remote branches";
            this.Prune.UseVisualStyleBackColor = true;
            this.Prune.Click += new System.EventHandler(this.PruneClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.SaveDefaultPushPull, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DefaultMergeWithCombo, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.RemoteRepositoryCombo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.LocalBranchNameEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 368);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1454, 197);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // SaveDefaultPushPull
            // 
            this.SaveDefaultPushPull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDefaultPushPull.Image = global::GitUI.Properties.Resources.IconSave;
            this.SaveDefaultPushPull.Location = new System.Drawing.Point(1188, 141);
            this.SaveDefaultPushPull.Margin = new System.Windows.Forms.Padding(6);
            this.SaveDefaultPushPull.Name = "SaveDefaultPushPull";
            this.SaveDefaultPushPull.Size = new System.Drawing.Size(260, 50);
            this.SaveDefaultPushPull.TabIndex = 3;
            this.SaveDefaultPushPull.Text = "Save changes";
            this.SaveDefaultPushPull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveDefaultPushPull.UseVisualStyleBackColor = true;
            this.SaveDefaultPushPull.Click += new System.EventHandler(this.SaveDefaultPushPullClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Local branch name";
            // 
            // DefaultMergeWithCombo
            // 
            this.DefaultMergeWithCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultMergeWithCombo.FormattingEnabled = true;
            this.DefaultMergeWithCombo.Location = new System.Drawing.Point(211, 96);
            this.DefaultMergeWithCombo.Margin = new System.Windows.Forms.Padding(6);
            this.DefaultMergeWithCombo.Name = "DefaultMergeWithCombo";
            this.DefaultMergeWithCombo.Size = new System.Drawing.Size(1237, 33);
            this.DefaultMergeWithCombo.TabIndex = 2;
            this.DefaultMergeWithCombo.DropDown += new System.EventHandler(this.DefaultMergeWithComboDropDown);
            this.DefaultMergeWithCombo.Validated += new System.EventHandler(this.DefaultMergeWithComboValidated);
            // 
            // RemoteRepositoryCombo
            // 
            this.RemoteRepositoryCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoteRepositoryCombo.FormattingEnabled = true;
            this.RemoteRepositoryCombo.Location = new System.Drawing.Point(211, 51);
            this.RemoteRepositoryCombo.Margin = new System.Windows.Forms.Padding(6);
            this.RemoteRepositoryCombo.Name = "RemoteRepositoryCombo";
            this.RemoteRepositoryCombo.Size = new System.Drawing.Size(1237, 33);
            this.RemoteRepositoryCombo.TabIndex = 1;
            this.RemoteRepositoryCombo.Validated += new System.EventHandler(this.RemoteRepositoryComboValidated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 45);
            this.label6.TabIndex = 2;
            this.label6.Text = "Default merge with";
            // 
            // LocalBranchNameEdit
            // 
            this.LocalBranchNameEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalBranchNameEdit.Location = new System.Drawing.Point(211, 6);
            this.LocalBranchNameEdit.Margin = new System.Windows.Forms.Padding(6);
            this.LocalBranchNameEdit.Name = "LocalBranchNameEdit";
            this.LocalBranchNameEdit.Size = new System.Drawing.Size(1237, 33);
            this.LocalBranchNameEdit.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remote repository";
            // 
            // FormRemotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1458, 686);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1484, 637);
            this.Name = "FormRemotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote repositories";
            this.flpnlRemoteManagement.ResumeLayout(false);
            this.flpnlRemoteManagement.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlMgtPuttySsh.ResumeLayout(false);
            this.pnlMgtPuttySsh.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnlMgtDetails.ResumeLayout(false);
            this.pnlMgtDetails.PerformLayout();
            this.tblpnlMgtDetails.ResumeLayout(false);
            this.tblpnlMgtDetails.PerformLayout();
            this.pnlManagementContainer.ResumeLayout(false);
            this.pnlManagementContainer.PerformLayout();
            this.gbMgtPanel.ResumeLayout(false);
            this.gbMgtPanel.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tlpnlMainBehaviours.ResumeLayout(false);
            this.tlpnlMainBehaviours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteBranches)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NativeListView Remotes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button UpdateBranch;
        private System.Windows.Forms.Button Prune;
        private System.Windows.Forms.Button LoadSSHKey;
        private System.Windows.Forms.TextBox PuttySshKey;
        private System.Windows.Forms.Button TestConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SshBrowse;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox RemoteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Url;
        private System.Windows.Forms.CheckBox checkBoxSepPushUrl;
        private System.Windows.Forms.Label labelPushUrl;
        private System.Windows.Forms.ComboBox comboBoxPushUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpnlMainBehaviours;
        private System.Windows.Forms.DataGridView RemoteBranches;
        private System.Windows.Forms.Button SaveDefaultPushPull;
        private System.Windows.Forms.TextBox LocalBranchNameEdit;
        private System.Windows.Forms.ComboBox RemoteRepositoryCombo;
        private System.Windows.Forms.ComboBox DefaultMergeWithCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.FolderBrowserButton folderBrowserButtonUrl;
        private UserControls.FolderBrowserButton folderBrowserButtonPushUrl;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.GroupBox gbMgtPanel;
        private System.Windows.Forms.Panel pnlMgtPuttySsh;
        private System.Windows.Forms.Label lblMgtPuttyPanelHeader;
        private System.Windows.Forms.TableLayoutPanel flpnlRemoteManagement;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblHeaderLine2;
        private System.Windows.Forms.Panel pnlMgtDetails;
        private System.Windows.Forms.TableLayoutPanel tblpnlMgtDetails;
        private System.Windows.Forms.Panel pnlManagementContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemoteCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MergeWith;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnToggleState;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
