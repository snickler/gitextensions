using System;
using GitCommands;
using GitCommands.Settings;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class ShellExtensionSettingsPage : SettingsPageWithHeader
    {
        public ShellExtensionSettingsPage()
        {
            InitializeComponent();
            Text = "Shell extension";
            Translate();
        }

        protected override void SettingsToPage()
        {
            for (int i = 0; i < AppSettings.Current.CascadeShellMenuItems.Length; i++)
            {
                chlMenuEntries.SetItemChecked(i, AppSettings.Current.CascadeShellMenuItems[i] == '1');
            }
            cbAlwaysShowAllCommands.Checked = AppSettings.Current.AlwaysShowAllCommands;

            UpdatePreview();
        }

        protected override void PageToSettings()
        {
            String l_CascadeShellMenuItems = "";

            for (int i = 0; i < chlMenuEntries.Items.Count; i++)
            {
                if (chlMenuEntries.GetItemChecked(i))
                {
                    l_CascadeShellMenuItems += "1";
                }
                else
                {
                    l_CascadeShellMenuItems += "0";
                }
            }

            AppSettings.Current.CascadeShellMenuItems = l_CascadeShellMenuItems;
            AppSettings.Current.AlwaysShowAllCommands = cbAlwaysShowAllCommands.Checked;
        }

        private void chlMenuEntries_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            string topLevel = "";
            string cascaded = "";

            for (int i = 0; i < chlMenuEntries.Items.Count; i++)
            {
                if (chlMenuEntries.GetItemChecked(i))
                {
                    cascaded += "       " + chlMenuEntries.Items[i].ToString() + "\r\n";
                }
                else
                {
                    topLevel += "GitExt " + chlMenuEntries.Items[i].ToString() + "\r\n";
                }
            }

            labelPreview.Text = topLevel + "Git Extensions > \r\n" + cascaded;
        }
    }
}
