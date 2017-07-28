
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
		/// [GL] Binding for glGetProgramResourceLocationIndexEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="programInterface">
		/// A <see cref="T:ProgramInterface"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public static Int32 GetProgramResourceLocationIndexEXT(UInt32 program, ProgramInterface programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocationIndexEXT != null, "pglGetProgramResourceLocationIndexEXT not implemented");
			retValue = Delegates.pglGetProgramResourceLocationIndexEXT(program, (Int32)programInterface, name);
			LogCommand("glGetProgramResourceLocationIndexEXT", retValue, program, programInterface, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramResourceLocationIndexEXT", ExactSpelling = true)]
			internal extern static Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

			[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramResourceLocationIndexEXT pglGetProgramResourceLocationIndexEXT;

		}
	}

}
