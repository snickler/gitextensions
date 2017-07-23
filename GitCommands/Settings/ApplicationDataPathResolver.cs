using System.Windows.Forms;

namespace GitCommands.Settings
{
    public interface IApplicationDataPathResolver
    {
        string Resolve();
    }

    public sealed class ApplicationDataPathResolver : IApplicationDataPathResolver
    {
        private readonly IGitExtensionsPathProvider _gitExtensionsPathProvider;


        public ApplicationDataPathResolver(IGitExtensionsPathProvider gitExtensionsPathProvider)
        {
            _gitExtensionsPathProvider = gitExtensionsPathProvider;
        }

        public ApplicationDataPathResolver()
            : this(new GitExtensionsPathProvider())
        {
        }


        public string Resolve()
        {
            if (Properties.Settings.Default.IsPortable)
            {
                return _gitExtensionsPathProvider.GetDirectory();
            }
            //Make applicationdatapath version independent
            return Application.UserAppDataPath.Replace(Application.ProductVersion, string.Empty);
        }
    }
}