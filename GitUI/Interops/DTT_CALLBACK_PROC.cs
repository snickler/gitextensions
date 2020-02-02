using System.Runtime.InteropServices;

namespace System
{
    internal static partial class NativeMethods
    {
        internal delegate int DTT_CALLBACK_PROC(IntPtr hdc,
            [MarshalAs(UnmanagedType.LPWStr)] string text, int textLen, ref RECT rc, int flags,
            IntPtr lParam);
    }
}
