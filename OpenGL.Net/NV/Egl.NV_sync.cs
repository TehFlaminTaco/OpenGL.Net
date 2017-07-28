
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_SYNC_PRIOR_COMMANDS_COMPLETE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_PRIOR_COMMANDS_COMPLETE_NV = 0x30E6;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_STATUS_NV = 0x30E7;

		/// <summary>
		/// [EGL] Value of EGL_SIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SIGNALED_NV = 0x30E8;

		/// <summary>
		/// [EGL] Value of EGL_UNSIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int UNSIGNALED_NV = 0x30E9;

		/// <summary>
		/// [EGL] Value of EGL_ALREADY_SIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int ALREADY_SIGNALED_NV = 0x30EA;

		/// <summary>
		/// [EGL] Value of EGL_TIMEOUT_EXPIRED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int TIMEOUT_EXPIRED_NV = 0x30EB;

		/// <summary>
		/// [EGL] Value of EGL_CONDITION_SATISFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int CONDITION_SATISFIED_NV = 0x30EC;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_TYPE_NV = 0x30ED;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_CONDITION_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_CONDITION_NV = 0x30EE;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_FENCE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_FENCE_NV = 0x30EF;

		/// <summary>
		/// [EGL] Binding for eglCreateFenceSyncNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="condition">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static IntPtr CreateFenceSyncNV(IntPtr dpy, uint condition, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateFenceSyncNV != null, "peglCreateFenceSyncNV not implemented");
					retValue = Delegates.peglCreateFenceSyncNV(dpy, condition, p_attrib_list);
					LogCommand("eglCreateFenceSyncNV", retValue, dpy, condition, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglDestroySyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool DestroySyncNV(IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroySyncNV != null, "peglDestroySyncNV not implemented");
			retValue = Delegates.peglDestroySyncNV(sync);
			LogCommand("eglDestroySyncNV", retValue, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglFenceNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool FenceNV(IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglFenceNV != null, "peglFenceNV not implemented");
			retValue = Delegates.peglFenceNV(sync);
			LogCommand("eglFenceNV", retValue, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglClientWaitSyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static int ClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.peglClientWaitSyncNV != null, "peglClientWaitSyncNV not implemented");
			retValue = Delegates.peglClientWaitSyncNV(sync, flags, timeout);
			LogCommand("eglClientWaitSyncNV", retValue, sync, flags, timeout			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglSignalSyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool SignalSyncNV(IntPtr sync, uint mode)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSignalSyncNV != null, "peglSignalSyncNV not implemented");
			retValue = Delegates.peglSignalSyncNV(sync, mode);
			LogCommand("eglSignalSyncNV", retValue, sync, mode			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglGetSyncAttribNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool GetSyncAttribNV(IntPtr sync, int attribute, [Out] int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttribNV != null, "peglGetSyncAttribNV not implemented");
					retValue = Delegates.peglGetSyncAttribNV(sync, attribute, p_value);
					LogCommand("eglGetSyncAttribNV", retValue, sync, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateFenceSyncNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglDestroySyncNV", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySyncNV(IntPtr sync);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglFenceNV", ExactSpelling = true)]
			internal extern static unsafe bool eglFenceNV(IntPtr sync);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglClientWaitSyncNV", ExactSpelling = true)]
			internal extern static unsafe int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglSignalSyncNV", ExactSpelling = true)]
			internal extern static unsafe bool eglSignalSyncNV(IntPtr sync, uint mode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetSyncAttribNV", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglCreateFenceSyncNV peglCreateFenceSyncNV;

			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglDestroySyncNV(IntPtr sync);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglDestroySyncNV peglDestroySyncNV;

			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglFenceNV(IntPtr sync);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglFenceNV peglFenceNV;

			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglClientWaitSyncNV peglClientWaitSyncNV;

			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSignalSyncNV(IntPtr sync, uint mode);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglSignalSyncNV peglSignalSyncNV;

			[RequiredByFeature("EGL_NV_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

			[RequiredByFeature("EGL_NV_sync")]
			internal static eglGetSyncAttribNV peglGetSyncAttribNV;

		}
	}

}
