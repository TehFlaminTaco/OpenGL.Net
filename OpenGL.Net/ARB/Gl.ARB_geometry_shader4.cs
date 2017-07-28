
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
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_VERTICES_OUT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_INPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_OUTPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;

		/// <summary>
		/// [GL] Value of GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;

		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;

		/// <summary>
		/// [GL] Binding for glFramebufferTextureFaceARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[AliasOf("glFramebufferTextureFaceEXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			Debug.Assert(Delegates.pglFramebufferTextureFaceARB != null, "pglFramebufferTextureFaceARB not implemented");
			Delegates.pglFramebufferTextureFaceARB((Int32)target, (Int32)attachment, texture, level, (Int32)face);
			LogCommand("glFramebufferTextureFaceARB", null, target, attachment, texture, level, face			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFramebufferTextureFaceARB", ExactSpelling = true)]
			internal extern static void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[AliasOf("glFramebufferTextureFaceARB")]
			[AliasOf("glFramebufferTextureFaceEXT")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[ThreadStatic]
			internal static glFramebufferTextureFaceARB pglFramebufferTextureFaceARB;

		}
	}

}
