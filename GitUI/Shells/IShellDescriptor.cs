#nullable enable

using System;
using System.Drawing;

namespace GitUI.Shells
{
    public interface IShellDescriptor
    {
        public Lazy<(string name, string? path, string? commandLine)> Executable { get; }

        /// <summary>
        /// Gets whether the executable for the given shell is located.
        /// </summary>
        public bool IsExecutableFound { get; }

        /// <summary>
        /// Gets the shell icon.
        /// </summary>
        public Image Icon { get; }

        /// <summary>
        /// Gets the user visible shell name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the shell type.
        /// </summary>
        public ShellType Type { get; }

        /// <summary>
        /// Gets the command to execute when a new terminal starts.
        /// </summary>
        /// <param name="path">The working directory path.</param>
        /// <returns>The start command.</returns>
        public string GetTerminalStartCommand(string path);
    }
}
