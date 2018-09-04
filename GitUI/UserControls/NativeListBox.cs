using System.Windows.Forms;

namespace GitUI.UserControls
{
    public class NativeListBox : ListBox
    {
        private const int WM_ERASEBKGND = 0x14;

        protected override void CreateHandle()
        {
            base.CreateHandle();
            NativeMethods.SetWindowTheme(Handle, "explorer", null);
        }

        protected override void WndProc(ref Message m)
        {
            // Reduce flicker
            if (m.Msg != WM_ERASEBKGND)
            {
                base.WndProc(ref m);
            }
        }
    }
}