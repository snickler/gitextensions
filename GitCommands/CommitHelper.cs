using System;
using System.IO;
using GitCommands.Git;
using GitUIPluginInterfaces;

namespace GitCommands
{
    public class CommitDto
    {
        public CommitDto(string message, bool amend)
        {
            Message = message;
            Amend = amend;
        }

        public string Message { get; set; }
        public string Result { get; set; }
        public bool Amend { get; set; }
    }

    public class CommitHelper
    {
        public CommitHelper(CommitDto dto)
        {
            Dto = dto;
        }

        public CommitDto Dto { get; set; }

        public void Execute(GitModule module)
        {
            if (Dto.Amend)
                Dto.Result = module.RunGitCmd("commit --amend -m \"" + Dto.Message + "\"");
            else
                Dto.Result = module.RunGitCmd("commit -m \"" + Dto.Message + "\"");
        }

        public static void SetCommitMessage(IGitModuleState module, string commitMessageText, bool amendCommit)
        {
            if (string.IsNullOrEmpty(commitMessageText))
            {
                File.Delete(GetCommitMessagePath(module));
                File.Delete(GetAmendPath(module));
                return;
            }

            var moduleFunctions = new GitModule(module);
            using (var textWriter = new StreamWriter(GetCommitMessagePath(module), false, moduleFunctions.CommitEncoding))
            {
                textWriter.Write(commitMessageText);
            }
            if (AppSettings.RememberAmendCommitState && amendCommit)
                File.WriteAllText(GetAmendPath(module), true.ToString());
            else if (File.Exists(GetAmendPath(module)))
                File.Delete(GetAmendPath(module));
        }

        public static string GetCommitMessage(IGitModuleState module)
        {
            if (File.Exists(CommitHelper.GetCommitMessagePath(module)))
            {
                var moduleFunctions = new GitModule(module);
                return File.ReadAllText(CommitHelper.GetCommitMessagePath(module), moduleFunctions.CommitEncoding);
            }

            return string.Empty;
        }

        public static string GetCommitMessagePath(IGitModuleState module)
        {
            return GetFilePath(module, "COMMITMESSAGE");
        }

        private static string GetAmendPath(IGitModuleState module)
        {
            return GetFilePath(module, "GitExtensions.amend");
        }

        private static string GetFilePath(IGitModuleState module, string action)
        {
            return Path.Combine(module.WorkingDirGitDir, action);
        }

        public static bool GetAmendState(IGitModuleState module)
        {
            bool amendState = false;
            if (AppSettings.RememberAmendCommitState && File.Exists(CommitHelper.GetAmendPath(module)))
            {
                var amendSaveStateFilePath = CommitHelper.GetAmendPath(module);
                bool.TryParse(File.ReadAllText(amendSaveStateFilePath), out amendState);
                try
                {
                    File.Delete(amendSaveStateFilePath);
                }
                catch (Exception)
                {
                }
            }

            return amendState;
        }
    }
}