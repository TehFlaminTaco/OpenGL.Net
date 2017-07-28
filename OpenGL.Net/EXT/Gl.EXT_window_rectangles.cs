
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_INCLUSIVE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int INCLUSIVE_EXT = 0x8F10;

		/// <summary>
		/// [GL] Value of GL_EXCLUSIVE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int EXCLUSIVE_EXT = 0x8F11;

		/// <summary>
		/// [GL] Value of GL_WINDOW_RECTANGLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int WINDOW_RECTANGLE_EXT = 0x8F12;

		/// <summary>
		/// [GL] Value of GL_WINDOW_RECTANGLE_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int WINDOW_RECTANGLE_MODE_EXT = 0x8F13;

		/// <summary>
		/// [GL] Value of GL_MAX_WINDOW_RECTANGLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int MAX_WINDOW_RECTANGLES_EXT = 0x8F14;

		/// <summary>
		/// [GL] Value of GL_NUM_WINDOW_RECTANGLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int NUM_WINDOW_RECTANGLES_EXT = 0x8F15;

		/// <summary>
		/// [GL] Binding for glWindowRectanglesEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="box">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public static void WindowRectanglesEXT(Int32 mode, Int32 count, Int32[] box)
		{
			unsafe {
				fixed (Int32* p_box = box)
				{
					Debug.Assert(Delegates.pglWindowRectanglesEXT != null, "pglWindowRectanglesEXT not implemented");
					Delegates.pglWindowRectanglesEXT(mode, count, p_box);
					LogCommand("glWindowRectanglesEXT", null, mode, count, box					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glWindowRectanglesEXT", ExactSpelling = true)]
			internal extern static unsafe void glWindowRectanglesEXT(Int32 mode, Int32 count, Int32* box);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glWindowRectanglesEXT(Int32 mode, Int32 count, Int32* box);

			[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glWindowRectanglesEXT pglWindowRectanglesEXT;

		}
	}

}
