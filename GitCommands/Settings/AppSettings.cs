using System;
using System.Windows.Forms;

namespace GitCommands.Settings
{
    public static class AppSettings
    {
        public static readonly char PosixPathSeparator = '/';
        public static string ProductVersion => Application.ProductVersion;
        public static readonly string SettingsFileName = "GitExtensions.settings";
        public static readonly int DefaultRepositoriesCount = 30;

        public static bool IsPortable => Properties.Settings.Default.IsPortable;

        public static IAppSettings Current => new AppSettingsImplementations();
    }


    internal class AppSettingsPath : SettingsPath
    {
        private readonly IRepoDistSettings _settings;

        public AppSettingsPath(IRepoDistSettings settings, string aPathName) : base(null, aPathName)
        {
            _settings = settings;
        }

        public override T GetValue<T>(string name, T defaultValue, Func<string, T> decode)
        {
            return _settings.GetValue(PathFor(name), defaultValue, decode);
        }

        public override void SetValue<T>(string name, T value, Func<T, string> encode)
        {
            _settings.SetValue(PathFor(name), value, encode);
        }

    }

}
