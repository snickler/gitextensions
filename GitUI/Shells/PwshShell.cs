#nullable enable

using System;
using GitCommands;
using GitUI.Properties;

namespace GitUI.Shells
{
    public class PwshShell : ShellDescriptor
    {
        public PwshShell()
        {
            Name = "pwsh";
            Type = ShellType.Pwsh;
            Icon = Images.pwsh;

            const string executableName = "pwsh.exe";
            Executable = new Lazy<(string, string?, string?)>(
                () => PathUtil.TryFindShellPath(executableName, out var exePath)
                        ? (name: executableName, path: exePath, commandLine: exePath.Quote())
                        : (name: executableName, path: null, commandLine: null));
        }

        public override string GetTerminalStartCommand(string path) => $"cd {path.QuoteNE()}";
    }
}
