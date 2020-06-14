#nullable enable

using System;
using System.Drawing;

namespace GitUI.Shells
{
    public abstract class ShellDescriptor : IShellDescriptor
    {
        /// <inheritdoc/>
        public Lazy<(string name, string? path, string? commandLine)> Executable { get; protected set; } = null!;

        /// <inheritdoc/>
        public bool IsExecutableFound => Executable.Value.path is object;

        /// <inheritdoc/>
        public Image Icon { get; protected set; } = null!;

        /// <inheritdoc/>
        public string Name { get; protected set; } = null!;

        /// <inheritdoc/>
        public ShellType Type { get; protected set; }

        /// <inheritdoc/>
        public abstract string GetTerminalStartCommand(string path);
    }
}
