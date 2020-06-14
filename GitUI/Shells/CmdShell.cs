#nullable enable

using System;
using GitCommands;
using GitUI.Properties;

namespace GitUI.Shells
{
    public class CmdShell : ShellDescriptor
    {
        public CmdShell()
        {
            Name = "cmd";
            Type = ShellType.Cmd;
            Icon = Images.cmd;

            const string executableName = "cmd.exe";
            Executable = new Lazy<(string, string?, string?)>(
                () => PathUtil.TryFindShellPath(executableName, out var exePath)
                        ? (name: executableName, path: exePath, commandLine: exePath.Quote())
                        : (name: executableName, path: null, commandLine: null));
        }

        public override string GetTerminalStartCommand(string path) => $"cd /D {path.QuoteNE()}";
    }
}
