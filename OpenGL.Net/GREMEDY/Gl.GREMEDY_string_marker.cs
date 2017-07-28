
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
		/// [GL] Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglStringMarkerGREMEDY != null, "pglStringMarkerGREMEDY not implemented");
			Delegates.pglStringMarkerGREMEDY(len, @string);
			LogCommand("glStringMarkerGREMEDY", null, len, @string			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				StringMarkerGREMEDY(len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
			internal extern static unsafe void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_GREMEDY_string_marker")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

			[RequiredByFeature("GL_GREMEDY_string_marker")]
			[ThreadStatic]
			internal static glStringMarkerGREMEDY pglStringMarkerGREMEDY;

		}
	}

}
