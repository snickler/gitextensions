using System.Windows.Forms;
using GitUIPluginInterfaces;
using GitCommands;

namespace GitUI.CommandsDialogs.SettingsDialog
{
    public class SettingsPageWithHeader : SettingsPageBase, IGlobalSettingsPage
    {
        private SettingsPageHeader header;

        public override Control GuiControl
        {
            get
            {
                if (header == null)
                {
                    header = new SettingsPageHeader(this);
                }

                return header;
            }
        }

        public virtual void SetGlobalSettings()
        {        
        }

        protected override bool AreEffectiveSettings => true;
        protected override SettingsSource GetCurrentSettings()
        {
            return AppSettings.Instance.SettingsContainer;
        }
    }
}
