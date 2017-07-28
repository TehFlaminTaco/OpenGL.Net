
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
		/// [EGL] Value of EGL_LINUX_DMA_BUF_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int LINUX_DMA_BUF_EXT = 0x3270;

		/// <summary>
		/// [EGL] Value of EGL_LINUX_DRM_FOURCC_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int LINUX_DRM_FOURCC_EXT = 0x3271;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_FD_EXT = 0x3272;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_OFFSET_EXT = 0x3273;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_PITCH_EXT = 0x3274;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_FD_EXT = 0x3275;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_OFFSET_EXT = 0x3276;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_PITCH_EXT = 0x3277;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_FD_EXT = 0x3278;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_OFFSET_EXT = 0x3279;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_PITCH_EXT = 0x327A;

		/// <summary>
		/// [EGL] Value of EGL_YUV_COLOR_SPACE_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_COLOR_SPACE_HINT_EXT = 0x327B;

		/// <summary>
		/// [EGL] Value of EGL_SAMPLE_RANGE_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int SAMPLE_RANGE_HINT_EXT = 0x327C;

		/// <summary>
		/// [EGL] Value of EGL_YUV_CHROMA_HORIZONTAL_SITING_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_HORIZONTAL_SITING_HINT_EXT = 0x327D;

		/// <summary>
		/// [EGL] Value of EGL_YUV_CHROMA_VERTICAL_SITING_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_VERTICAL_SITING_HINT_EXT = 0x327E;

		/// <summary>
		/// [EGL] Value of EGL_ITU_REC601_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC601_EXT = 0x327F;

		/// <summary>
		/// [EGL] Value of EGL_ITU_REC709_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC709_EXT = 0x3280;

		/// <summary>
		/// [EGL] Value of EGL_ITU_REC2020_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC2020_EXT = 0x3281;

		/// <summary>
		/// [EGL] Value of EGL_YUV_FULL_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_FULL_RANGE_EXT = 0x3282;

		/// <summary>
		/// [EGL] Value of EGL_YUV_NARROW_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_NARROW_RANGE_EXT = 0x3283;

		/// <summary>
		/// [EGL] Value of EGL_YUV_CHROMA_SITING_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_SITING_0_EXT = 0x3284;

		/// <summary>
		/// [EGL] Value of EGL_YUV_CHROMA_SITING_0_5_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_SITING_0_5_EXT = 0x3285;

	}

}
