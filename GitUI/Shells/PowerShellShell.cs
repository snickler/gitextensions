#nullable enable

using System;
using GitCommands;
using GitUI.Properties;

namespace GitUI.Shells
{
    public class PowerShellShell : ShellDescriptor
    {
        public PowerShellShell()
        {
            Name = "powershell";
            Type = ShellType.PowerShell;
            Icon = Images.powershell;

            ExecutableName = "powershell.exe";
            if (PathUtil.TryFindShellPath(ExecutableName, out var exePath))
            {
                ExecutablePath = exePath;
                ExecutableCommandLine = exePath.Quote();
            }
        }

        public override string GetTerminalStartCommand(string path) => $"cd {path.QuoteNE()}";
    }
}
