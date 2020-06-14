using ConEmu.WinForms;

namespace GitUI.Shells
{
    public class ShellProvider
    {
        private static PwshShell PwshShellInstance;
        private static PowerShellShell PowerShellShellInstance;
        private static CmdShell CmdShellInstance;
        private static BashShell BashShellInstance;

        public IShellDescriptor GetShell(string shellType)
        {
            switch (shellType.ToLowerInvariant())
            {
                case "pwsh":
                    return PwshShellInstance ?? (PwshShellInstance = new PwshShell());

                case "powershell":
                    return PowerShellShellInstance ?? (PowerShellShellInstance = new PowerShellShell());

                case "cmd":
                    return CmdShellInstance ?? (CmdShellInstance = new CmdShell());

                case "bash":
                default:
                    return BashShellInstance ?? (BashShellInstance = new BashShell());
            }
        }

        public string GetShellCommandLine(string shellType)
        {
            var shell = GetShell(shellType);

            if (!shell.HasExecutable)
            {
                return ConEmuConstants.DefaultConsoleCommandLine;
            }

            return shell.ExecutableCommandLine;
        }
    }
}
