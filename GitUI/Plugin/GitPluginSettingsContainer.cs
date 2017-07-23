using System;
using GitCommands;
using GitCommands.Settings;
using GitUIPluginInterfaces;

namespace GitUI
{
    public class GitPluginSettingsContainer : SettingsSource, IGitPluginSettingsContainer
    {
        private readonly string pluginName;
        private SettingsSource _settingsSource;

        public GitPluginSettingsContainer(string pluginName)
        {
            this.pluginName = pluginName;
        }

        public SettingsSource GetSettingsSource()
        {
            return this;
        }

        public void SetSettingsSource(SettingsSource settingsSource)
        {
            _settingsSource = settingsSource;
        }

        private SettingsSource ExternalSettings
        {
            get
            {
                return _settingsSource ?? AppSettings.Current.SettingsContainer;
            }
        }

        public override T GetValue<T>(string name, T defaultValue, Func<string, T> decode)
        {
            return ExternalSettings.GetValue(pluginName + name, defaultValue, decode);
        }

        public override void SetValue<T>(string name, T value, Func<T, string> encode)
        {
            ExternalSettings.SetValue(pluginName + name, value, encode);
        }
    }
}
