using System;
using System.Reflection;
using System.Windows.Forms;
using GitCommands.Settings;

namespace GitCommands
{
    public enum LocalChangesAction
    {
        DontChange,
        Merge,
        Reset,
        Stash
    }

    public static class AppSettings
    {
        public static readonly char PosixPathSeparator = '/';
        public static string ProductVersion => Application.ProductVersion;
        public static readonly string SettingsFileName = "GitExtensions.settings";
        public static readonly int DefaultRepositoriesCount = 30;

        public static bool IsPortable()
        {
            return Properties.Settings.Default.IsPortable;
        }

        public static IAppSettings Instance => new AppSettingsImplementations();
    }


    public enum PullAction
    {
        None,
        Merge,
        Rebase,
        Fetch,
        FetchAll,
        Default
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
