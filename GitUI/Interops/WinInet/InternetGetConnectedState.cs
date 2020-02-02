using System.Runtime.InteropServices;

namespace System
{
    internal static partial class NativeMethods
    {
        [DllImport(Libraries.WinInet)]
        internal static extern bool InternetGetConnectedState(out int description, int reservedValue);
    }
}
