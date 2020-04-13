using System;

namespace GitUI.Script
{
    [Flags]
    public enum ScriptContexts
    {
        Global = 0,
        MainMenu = 1,
        RevisionGrid = MainMenu << 1,
        FileTree = RevisionGrid << 1
    }
}
