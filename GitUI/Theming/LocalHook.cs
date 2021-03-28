﻿#pragma warning disable SA1121 // Use built-in type alias
#pragma warning disable SA1131 // Use readable conditions
#pragma warning disable SA1308 // Variable names should not be prefixed
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1313 // Parameter names should begin with lower-case letter
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable SX1309 // Field names should begin with underscore

// EasyHook (File: EasyHook\LocalHook.cs)
//
// Copyright (c) 2009 Christoph Husse & Copyright (c) 2015 Justin Stenning
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// Please visit https://easyhook.github.io for more information
// about the project and latest updates.

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace EasyHook
{
    /// <summary>
    /// Provides a managed interface to the native thread ACLs.
    /// </summary>
    /// <remarks>
    /// Refer to the official guide to learn more about why thread ACLs are useful.
    /// They can be used to exclude/include dedicated threads from interception or to dynamically
    /// apply different kind of hooks to different threads. Even if you could do this
    /// in managed code, it is not that easy to implement and also EasyHook evaluates
    /// those ACLs in unmanaged code. So if any thread is not intercepted, it will never
    /// enter the manged environment what will speed up things about orders of magnitudes.
    /// </remarks>
    public class HookAccessControl
    {
        private Int32[] m_ACL = new Int32[0];
        private IntPtr m_Handle;
        private Boolean m_IsExclusive;

        /// <summary>
        /// Is this ACL an exclusive one? Refer to <see cref="SetExclusiveACL"/> for more information.
        /// </summary>
        public Boolean IsExclusive
        {
            get { return m_IsExclusive; }
        }

        /// <summary>
        /// Is this ACL an inclusive one? Refer to <see cref="SetInclusiveACL"/> for more information.
        /// </summary>
        public Boolean IsInclusive
        {
            get { return !IsExclusive; }
        }

        /// <summary>
        /// Sets an inclusive ACL. This means all threads that are enumerated through <paramref name="InACL"/>
        /// are intercepted while all others are NOT. Of course this will overwrite the existing ACL.
        /// </summary>
        /// <remarks>
        /// Please note that this is not necessarily the final
        /// negotiation result. Refer to <see cref="LocalHook.IsThreadIntercepted"/> for more information.
        /// In general inclusive ACLs will restrict exclusive ACLs while local ACLs will overwrite the
        /// global ACL.
        /// </remarks>
        /// <param name="InACL">Threads to be explicitly included in negotiation.</param>
        /// <exception cref="ArgumentException">
        /// The limit of 128 access entries is exceeded!
        /// </exception>
        public void SetInclusiveACL(Int32[] InACL)
        {
            if (InACL == null)
            {
                m_ACL = new Int32[0];
            }
            else
            {
                m_ACL = (Int32[])InACL.Clone();
            }

            m_IsExclusive = false;

            ////if (m_Handle == IntPtr.Zero)
            ////    NativeAPI.LhSetGlobalInclusiveACL(m_ACL, m_ACL.Length);
            ////else
            ////    NativeAPI.LhSetInclusiveACL(m_ACL, m_ACL.Length, m_Handle);
        }

        /// <summary>
        /// Sets an exclusive ACL. This means all threads that are enumerated through <paramref name="InACL"/>
        /// are NOT intercepted while all others are. Of course this will overwrite the existing ACL.
        /// </summary>
        /// <remarks>
        /// Please note that this is not necessarily the final
        /// negotiation result. Refer to <see cref="LocalHook.IsThreadIntercepted"/> for more information.
        /// In general inclusive ACLs will restrict exclusive ACLs while local ACLs will overwrite the
        /// global ACL.
        /// </remarks>
        /// <param name="InACL">Threads to be explicitly included in negotiation.</param>
        /// <exception cref="ArgumentException">
        /// The limit of 128 access entries is exceeded!
        /// </exception>
        public void SetExclusiveACL(Int32[] InACL)
        {
            if (InACL == null)
            {
                m_ACL = new Int32[0];
            }
            else
            {
                m_ACL = (Int32[])InACL.Clone();
            }

            m_IsExclusive = true;

            ////if (m_Handle == IntPtr.Zero)
            ////    NativeAPI.LhSetGlobalExclusiveACL(m_ACL, m_ACL.Length);
            ////else
            ////    NativeAPI.LhSetExclusiveACL(m_ACL, m_ACL.Length, m_Handle);
        }

        /// <summary>
        /// Creates a copy of the internal thread list associated with this ACL. You may freely
        /// modify it without affecting the internal entries.
        /// </summary>
        /// <returns>
        /// A copy of the internal thread entries.
        /// </returns>
        public Int32[] GetEntries()
        {
            return (Int32[])m_ACL.Clone();
        }

        internal HookAccessControl(IntPtr InHandle)
        {
            if (InHandle == IntPtr.Zero)
            {
                m_IsExclusive = true;
            }
            else
            {
                m_IsExclusive = false;
            }

            m_Handle = InHandle;
        }
    }

    /// <summary>
    /// This class will provide various static members to be used with local hooking and
    /// is also the instance class of a hook.
    /// </summary>
    public class LocalHook : CriticalFinalizerObject, IDisposable
    {
        private Object m_ThreadSafe = new Object();
        private IntPtr m_Handle = IntPtr.Zero;
        private GCHandle m_SelfHandle;
        private Delegate m_HookProc;
        private Object m_Callback;
        private HookAccessControl m_ThreadACL;
        private static HookAccessControl m_GlobalThreadACL = new HookAccessControl(IntPtr.Zero);

        /// <summary>
        /// Ensures that each instance is always terminated with <see cref="Dispose"/>.
        /// </summary>
        ~LocalHook()
        {
            Dispose();
        }

        private LocalHook()
        {
        }

        /// <summary>
        /// The callback passed to <see cref="Create"/>.
        /// </summary>
        public Object Callback
        {
            get { return m_Callback; }
        }

        /// <summary>
        /// Returns the thread ACL associated with this hook. Refer to <see cref="IsThreadIntercepted"/>
        /// for more information about access negotiation.
        /// </summary>
        /// <exception cref="ObjectDisposedException">
        /// The underlying hook is already disposed.
        /// </exception>
        public HookAccessControl ThreadACL
        {
            get
            {
                if (IntPtr.Zero == m_Handle)
                {
                    throw new ObjectDisposedException(typeof(LocalHook).FullName);
                }

                return m_ThreadACL;
            }
        }

        /// <summary>
        /// Returns the trampoline bypass address associated with this hook.
        /// </summary>
        /// <exception cref="ObjectDisposedException">
        /// The underlying hook has been disposed.
        /// </exception>
        public IntPtr HookBypassAddress
        {
            get
            {
                if (IntPtr.Zero == m_Handle)
                {
                    throw new ObjectDisposedException(typeof(LocalHook).FullName);
                }

                IntPtr address = IntPtr.Zero;
                ////NativeAPI.LhGetHookBypassAddress(m_Handle, out address);
                return address;
            }
        }

        /// <summary>
        /// Checks whether a given thread ID will be intercepted by the underlying hook.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method provides an interface to the internal negotiation algorithm.
        /// You may use it to check whether your ACL provides expected results.
        /// </para><para>
        /// The following is a pseudo code of how this method is implemented:
        /// <code>
        /// if(InThreadID == 0)
        ///     InThreadID = GetCurrentThreadId();
        ///
        /// if(GlobalACL.Contains(InThreadID))
        /// {
        ///     if(LocalACL.Contains(InThreadID))
        ///     {
        ///         if(LocalACL.IsExclusive)
        ///             return false;
        ///     }
        ///     else
        ///     {
        ///         if(GlobalACL.IsExclusive)
        ///             return false;
        ///
        ///         if(!LocalACL.IsExclusive)
        ///             return false;
        ///     }
        /// }
        /// else
        /// {
        ///     if(LocalACL.Contains(InThreadID))
        ///     {
        ///         if(LocalACL.IsExclusive)
        ///             return false;
        ///     }
        ///     else
        ///     {
        ///         if(!GlobalACL.IsExclusive)
        ///             return false;
        ///
        ///         if(!LocalACL.IsExclusive)
        ///             return false;
        ///     }
        /// }
        ///
        /// return true;
        /// </code>
        /// </para>
        /// </remarks>
        /// <param name="InThreadID">A native OS thread ID; or zero if you want to check the current thread.</param>
        /// <returns><c>true</c> if the thread is intercepted, <c>false</c> otherwise.</returns>
        /// <exception cref="ObjectDisposedException">
        /// The underlying hook is already disposed.
        /// </exception>
        public bool IsThreadIntercepted(Int32 InThreadID)
        {
            Boolean Result = false;

            if (IntPtr.Zero == m_Handle)
            {
                throw new ObjectDisposedException(typeof(LocalHook).FullName);
            }

            ////NativeAPI.LhIsThreadIntercepted(m_Handle, InThreadID, out Result);

            return Result;
        }

        /// <summary>
        /// Returns the gloabl thread ACL associated with ALL hooks. Refer to <see cref="IsThreadIntercepted"/>
        /// for more information about access negotiation.
        /// </summary>
        public static HookAccessControl GlobalThreadACL
        {
            get { return m_GlobalThreadACL; }
        }

        /// <summary>
        /// If you want to immediately uninstall a hook, the only way is to dispose it. A disposed
        /// hook is guaranteed to never invoke your handler again but may still consume
        /// memory even for process life-time!
        /// </summary>
        /// <remarks>
        /// As we are living in a manged world, you don't have to dispose a hook because the next
        /// garbage collection will do it for you, assuming that your code does not reference it
        /// anymore. But there are times when you want to uninstall it excplicitly, with no delay.
        /// If you dispose a disposed or not installed hook, nothing will happen!
        /// </remarks>
        public void Dispose()
        {
            lock (m_ThreadSafe)
            {
                if (IntPtr.Zero == m_Handle)
                {
                    return;
                }

                ////NativeAPI.LhUninstallHook(m_Handle);

                Marshal.FreeCoTaskMem(m_Handle);

                m_Handle = IntPtr.Zero;
                m_Callback = null;
                m_HookProc = null;

                m_SelfHandle.Free();
            }
        }

        /// <summary>
        /// Installs a managed hook. After this you'll have to activate it by setting a proper <see cref="ThreadACL"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that not all entry points are hookable! In general methods like <c>CreateFileW</c>
        /// won't cause any trouble. But there might be methods that are not hookable because their
        /// entry point machine code is not eligable to be hooked. You should test all hooks on
        /// common environments like "Windows XP x86/x64 SP2/SP3" and "Windows Vista x86/x64 (SP1)".
        /// This is the only way to ensure that your application will work well on most machines.
        /// </para><para>
        /// Your handler delegate has to use the <see cref="UnmanagedFunctionPointerAttribute"/> and
        /// shall map to the same native method signature, otherwise the application will crash! The best
        /// way is to use predefined delegates used in related P-Invoke implementations usually found with Google.
        /// If you know how to write such native delegates you won't need internet resources of course.
        /// I recommend using C++.NET which allows you to just copy the related windows API to your managed
        /// class and thread it as delegate without any changes. This will also speed up the whole thing
        /// because no unnecessary marshalling is required! C++.NET is also better in most cases because you
        /// may access the whole native windows API from managed code without any effort what significantly eases
        /// writing of hook handlers.
        /// </para>
        /// <para>
        /// The given delegate is automatically prevented from being garbage collected until the hook itself
        /// is collected...
        /// </para>
        /// </remarks>
        /// <param name="InTargetProc">A target entry point that should be hooked.</param>
        /// <param name="InNewProc">A handler with the same signature as the original entry point
        /// that will be invoked for every call that has passed the Fiber Deadlock Barrier and various integrity checks.</param>
        /// <returns>
        /// A handle to the newly created hook.
        /// </returns>
        /// <exception cref="OutOfMemoryException">
        /// Not enough memory available to complete the operation. On 64-Bit this may also indicate
        /// that no memory can be allocated within a 31-Bit boundary around the given entry point.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The given function pointer does not map to executable memory (valid machine code) or
        /// you passed <c>null</c> as delegate.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The given entry point contains machine code that can not be hooked.
        /// </exception>
        /// <exception cref="InsufficientMemoryException">
        /// The maximum amount of hooks has been installed. This is currently set to MAX_HOOK_COUNT (1024).
        /// </exception>
        public static LocalHook Create(
            IntPtr InTargetProc,
            Delegate InNewProc,
            Object InCallback)
        {
            LocalHook Result = new LocalHook();

            Result.m_Callback = InCallback;
            Result.m_HookProc = InNewProc;
            Result.m_Handle = Marshal.AllocCoTaskMem(IntPtr.Size);
            Result.m_SelfHandle = GCHandle.Alloc(Result, GCHandleType.Weak);

            Marshal.WriteIntPtr(Result.m_Handle, IntPtr.Zero);

            try
            {
                ////NativeAPI.LhInstallHook(
                ////    InTargetProc,
                ////    Marshal.GetFunctionPointerForDelegate(Result.m_HookProc),
                ////    GCHandle.ToIntPtr(Result.m_SelfHandle),
                ////    Result.m_Handle);
            }
            catch (Exception)
            {
                Marshal.FreeCoTaskMem(Result.m_Handle);
                Result.m_Handle = IntPtr.Zero;

                Result.m_SelfHandle.Free();

                throw;
            }

            Result.m_ThreadACL = new HookAccessControl(Result.m_Handle);

            return Result;
        }

        /// <summary>
        /// Will return the address for a given DLL export symbol. The specified
        /// module has to be loaded into the current process space and also export
        /// the given method.
        /// </summary>
        /// <remarks>
        /// If you wonder how to get native entry points in a managed environment,
        /// this is the anwser. You will only be able to hook native code from a managed
        /// environment if you have access to a method like this, returning the native
        /// entry point. Please note that you will also hook any managed code, which
        /// of course ultimately relies on the native windows API!
        /// </remarks>
        /// <param name="InModule">A system DLL name like "kernel32.dll" or a full qualified path to any DLL.</param>
        /// <param name="InSymbolName">An exported symbol name like "CreateFileW".</param>
        /// <returns>The entry point for the given API method.</returns>
        /// <exception cref="DllNotFoundException">
        /// The given module is not loaded into the current process.
        /// </exception>
        /// <exception cref="MissingMethodException">
        /// The given module does not export the desired method.
        /// </exception>
        public static IntPtr GetProcAddress(
            String InModule,
            String InSymbolName)
        {
            ////IntPtr Module = NativeAPI.GetModuleHandle(InModule);

            ////if (Module == IntPtr.Zero)
            ////    throw new DllNotFoundException("The given library is not loaded into the current process.");

            ////IntPtr Method = NativeAPI.GetProcAddress(Module, InSymbolName);

            ////if (Method == IntPtr.Zero)
            ////    throw new MissingMethodException("The given method does not exist.");

            ////return Method;

            return IntPtr.Zero;
        }

        /// <summary>
        /// Processes any pending hook removals. Warning! This method can be quite slow (1 second) under certain circumstances.
        /// </summary>
        public static void Release()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            ////NativeAPI.LhWaitForPendingRemovals();
        }
    }
}
#pragma warning restore SX1309 // Field names should begin with underscore
#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore SA1313 // Parameter names should begin with lower-case letter
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1308 // Variable names should not be prefixed
#pragma warning restore SA1131 // Use readable conditions
#pragma warning restore SA1121 // Use built-in type alias
