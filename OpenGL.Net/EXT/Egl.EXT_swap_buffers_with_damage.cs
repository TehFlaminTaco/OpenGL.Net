
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
		/// [EGL] Binding for eglSwapBuffersWithDamageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="rects">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="n_rects">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
		public static bool SwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int[] rects, int n_rects)
		{
			bool retValue;

			unsafe {
				fixed (int* p_rects = rects)
				{
					Debug.Assert(Delegates.peglSwapBuffersWithDamageEXT != null, "peglSwapBuffersWithDamageEXT not implemented");
					retValue = Delegates.peglSwapBuffersWithDamageEXT(dpy, surface, p_rects, n_rects);
					LogCommand("eglSwapBuffersWithDamageEXT", retValue, dpy, surface, rects, n_rects					);
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
			[DllImport(Library, EntryPoint = "eglSwapBuffersWithDamageEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
			internal static eglSwapBuffersWithDamageEXT peglSwapBuffersWithDamageEXT;

		}
	}

}
