
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
		/// [GL] Binding for glCopyImageSubDataNV.
		/// </summary>
		/// <param name="srcName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:BufferTarget"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:BufferTarget"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_copy_image")]
		public static void CopyImageSubDataNV(UInt32 srcName, BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglCopyImageSubDataNV != null, "pglCopyImageSubDataNV not implemented");
			Delegates.pglCopyImageSubDataNV(srcName, (Int32)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (Int32)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			LogCommand("glCopyImageSubDataNV", null, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCopyImageSubDataNV", ExactSpelling = true)]
			internal extern static void glCopyImageSubDataNV(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_copy_image")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glCopyImageSubDataNV(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[RequiredByFeature("GL_NV_copy_image")]
			[ThreadStatic]
			internal static glCopyImageSubDataNV pglCopyImageSubDataNV;

		}
	}

}
