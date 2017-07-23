using System.IO;
using System.Windows.Forms;

namespace GitCommands.Settings
{
    public interface IGitExtensionsPathProvider
    {
        string GetDictionaryDir();

        /// <summary>
        /// Returns the directory information for where Git Extensions executable is located.
        /// </summary>
        /// <returns></returns>
        string GetDirectory();

        /// <summary>
        /// Returns the full pathe to Git Extensions executable.
        /// </summary>
        /// <returns></returns>
        string GetFullPath();

        string GetInstallDir();
        void SetInstallDir(string path);
    }

    public sealed class GitExtensionsPathProvider : IGitExtensionsPathProvider
    {
        public string GetDictionaryDir()
        {
            return Path.Combine(GetResourceDir(), "Dictionaries");
        }

        /// <summary>
        /// Returns the directory information for where Git Extensions executable is located.
        /// </summary>
        /// <returns></returns>
        public string GetDirectory()
        {
            return Path.GetDirectoryName(GetFullPath());
        }

        /// <summary>
        /// Returns the full pathe to Git Extensions executable.
        /// </summary>
        /// <returns></returns>
        public string GetFullPath()
        {
            return Application.ExecutablePath;
        }

        public string GetInstallDir()
        {
            if (AppSettings.IsPortable)
                return GetDirectory();

            // TODO:
            //string dir = ReadStringRegValue("InstallDir", string.Empty);
            //if (string.IsNullOrEmpty(dir))
            //    return GetDirectory();
            //return dir;
            return GetDirectory();
        }

        //for repair only
        public void SetInstallDir(string dir)
        {
            // TODO:
            //WriteStringRegValue("InstallDir", dir);
        }


        private string GetResourceDir()
        {
#if DEBUG
            string gitExtDir = GetDirectory().TrimEnd('\\').TrimEnd('/');
            string debugPath = @"GitExtensions\bin\Debug";
            int len = debugPath.Length;
            var path = gitExtDir.Substring(gitExtDir.Length - len);
            if (debugPath.ToPosixPath().Equals(path.ToPosixPath()))
            {
                string projectPath = gitExtDir.Substring(0, gitExtDir.Length - len);
                return Path.Combine(projectPath, "Bin");
            }
#endif
            return GetInstallDir();
        }
    }
}