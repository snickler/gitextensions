
namespace GitUIPluginInterfaces.BuildServerIntegration
{
    public interface IBuildServerSettingsUserControl
    {
        void Initialize(string defaultProjectName);

        void LoadSettings(SettingsSource buildServerConfig);
        void SaveSettings(SettingsSource buildServerConfig);
    }
}