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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel itemMore;
    }
}
