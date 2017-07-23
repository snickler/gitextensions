using System;
using System.IO;
using GitCommands;
using GitCommands.Settings;

namespace GitUI.UserManual
{
    public class SingleHtmlUserManual : IProvideUserManual
    {
        private static IGitExtensionsPathProvider _gitExtensionsPathProvider = new GitExtensionsPathProvider();
        private static string _Location;
        public static string Location 
        {
            get
            {
                if (_Location == null)
                {
                    var path = Path.Combine(_gitExtensionsPathProvider.GetInstallDir(), "help");
                    var uri = new System.Uri(path);
                    _Location = uri.AbsolutePath;
                }
                return _Location;
            }
        }
        private readonly string _anchorName;

        public SingleHtmlUserManual(string anchorName)
        {
            _anchorName = anchorName;
        }

        public string GetUrl()
        {
            return string.Format("{0}/index.html{1}{2}",
                                 Location, _anchorName.IsNullOrEmpty() ? "" : "#", _anchorName);
        }
    }
}