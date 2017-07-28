
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
		/// [EGL] Value of EGL_DRM_BUFFER_FORMAT_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_FORMAT_MESA = 0x31D0;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_USE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_USE_MESA = 0x31D1;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_FORMAT_ARGB32_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_FORMAT_ARGB32_MESA = 0x31D2;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_MESA = 0x31D3;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_STRIDE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_STRIDE_MESA = 0x31D4;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_USE_SCANOUT_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		[Log(BitmaskName = "EGLDRMBufferUseMESAMask")]
		public const int DRM_BUFFER_USE_SCANOUT_MESA = 0x00000001;

		/// <summary>
		/// [EGL] Value of EGL_DRM_BUFFER_USE_SHARE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		[Log(BitmaskName = "EGLDRMBufferUseMESAMask")]
		public const int DRM_BUFFER_USE_SHARE_MESA = 0x00000002;

		/// <summary>
		/// [EGL] Binding for eglCreateDRMImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public static IntPtr CreateDRMImageMESA(IntPtr dpy, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateDRMImageMESA != null, "peglCreateDRMImageMESA not implemented");
					retValue = Delegates.peglCreateDRMImageMESA(dpy, p_attrib_list);
					LogCommand("eglCreateDRMImageMESA", retValue, dpy, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglExportDRMImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="handle">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public static bool ExportDRMImageMESA(IntPtr dpy, IntPtr image, int[] name, int[] handle, int[] stride)
		{
			bool retValue;

			unsafe {
				fixed (int* p_name = name)
				fixed (int* p_handle = handle)
				fixed (int* p_stride = stride)
				{
					Debug.Assert(Delegates.peglExportDRMImageMESA != null, "peglExportDRMImageMESA not implemented");
					retValue = Delegates.peglExportDRMImageMESA(dpy, image, p_name, p_handle, p_stride);
					LogCommand("eglExportDRMImageMESA", retValue, dpy, image, name, handle, stride					);
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
			[DllImport(Library, EntryPoint = "eglCreateDRMImageMESA", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglExportDRMImageMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_MESA_drm_image")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			[RequiredByFeature("EGL_MESA_drm_image")]
			internal static eglCreateDRMImageMESA peglCreateDRMImageMESA;

			[RequiredByFeature("EGL_MESA_drm_image")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

			[RequiredByFeature("EGL_MESA_drm_image")]
			internal static eglExportDRMImageMESA peglExportDRMImageMESA;

		}
	}

}
