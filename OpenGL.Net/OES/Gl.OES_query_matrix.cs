
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
		/// [GLES1.1] return the values of the current matrix
		/// </summary>
		/// <param name="mantissa">
		/// Returns the mantissa values of the current matrix.
		/// </param>
		/// <param name="exponent">
		/// Returns the exponents of the current matrix.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.MatrixMode"/>
		[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
		public static UInt32 QueryMatrixxOES(IntPtr[] mantissa, Int32[] exponent)
		{
			UInt32 retValue;

			unsafe {
				fixed (IntPtr* p_mantissa = mantissa)
				fixed (Int32* p_exponent = exponent)
				{
					Debug.Assert(Delegates.pglQueryMatrixxOES != null, "pglQueryMatrixxOES not implemented");
					retValue = Delegates.pglQueryMatrixxOES(p_mantissa, p_exponent);
					LogCommand("glQueryMatrixxOES", retValue, mantissa, exponent					);
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
			[DllImport(Library, EntryPoint = "glQueryMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

			[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glQueryMatrixxOES pglQueryMatrixxOES;

		}
	}

}
