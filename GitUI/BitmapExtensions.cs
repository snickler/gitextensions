﻿#nullable enable

using System;
using System.Drawing;

namespace GitUI
{
    public static class BitmapExtensions
    {
        public static Icon BitmapToIcon(this Bitmap bitmap)
        {
            if (bitmap is null)
            {
                throw new ArgumentNullException(nameof(bitmap));
            }

            IntPtr handle = IntPtr.Zero;
            try
            {
                handle = bitmap.GetHicon();
                var icon = Icon.FromHandle(handle);

                return (Icon)icon.Clone();
            }
            finally
            {
                if (handle != IntPtr.Zero)
                {
                    NativeMethods.DestroyIcon(handle);
                }
            }
        }
    }
}
