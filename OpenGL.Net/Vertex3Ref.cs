﻿
// Copyright (C) 2009-2017 Luca Piccioni
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

using System;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Threedimensional vertex defined as reference type (float implementation).
	/// </summary>
	[DebuggerDisplay("Vertex3: X={X} Y={Y} Z={Z}")]
	public class Vertex3 : ICopiable<Vertex3>
	{
		#region Constructors
		
		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		public Vertex3()
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex3(float v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/>
		/// </param>
		public Vertex3(float[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3(Vertex3f other) : this(other.x, other.y, other.z) { }

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3"/>
		/// </param>
		public Vertex3(Vertex3 other) : this(other.X, other.Y, other.X) { }

		#endregion

		#region Vector Components

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X;

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y;

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="float[]"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static implicit operator float[](Vertex3 a)
		{
			float[] v = new float[3];

			v[0] = a.X;
			v[1] = a.Y;
			v[2] = a.Z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> equivalent to <paramref name="a"/>
		/// </returns>
		public static implicit operator Vertex3f(Vertex3 a)
		{
			return (new Vertex3f(a.X, a.Y, a.Z));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> equivalent to <paramref name="a"/>
		/// </returns>
		public static implicit operator Vertex3(Vertex3f a)
		{
			return (new Vertex3(a.x, a.y, a.z));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3 Zero = new Vertex3(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3 One = new Vertex3(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3 UnitX = new Vertex3(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3 UnitY = new Vertex3(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3 UnitZ = new Vertex3(0.0f, 0.0f, 1.0f);

		#endregion

		#region ICopiable<Vertex3> Implementation

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see name="Vertex3"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(Vertex3 other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			X = other.X;
			Y = other.Y;
			Z = other.Z;
		}

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Object"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(object other)
		{
			if (other is Vertex3)
				Copy(other as Vertex3);				// Copoy reference type
			else if (other is Vertex3f)
				Copy(new Vertex3((Vertex3f)other));	// Copy corresponding value type, for animation system
			else
				throw new ArgumentException("not supported object", "other");
		}

		#endregion
	}

	/// <summary>
	/// Threedimensional vertex defined as reference type (double implementation).
	/// </summary>
	[DebuggerDisplay("Vertex3Double: X={X} Y={Y} Z={Z}")]
	public class Vertex3Double : ICopiable<Vertex3Double>
	{
		#region Constructors
		
		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		public Vertex3Double()
		{

		}

		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex3Double(double v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/>
		/// </param>
		public Vertex3Double(double[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3Double(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3Double(Vertex3f other) : this(other.x, other.y, other.z) { }

		/// <summary>
		/// Vertex3Double constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3Double"/>
		/// </param>
		public Vertex3Double(Vertex3Double other) : this(other.X, other.Y, other.X) { }

		#endregion

		#region Vector Components

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public double X;

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public double Y;

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public double Z;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3Double"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="double[]"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static implicit operator double[](Vertex3Double a)
		{
			double[] v = new double[3];

			v[0] = a.X;
			v[1] = a.Y;
			v[2] = a.Z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3Double"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> equivalent to <paramref name="a"/>
		/// </returns>
		public static implicit operator Vertex3d(Vertex3Double a)
		{
			return (new Vertex3d(a.X, a.Y, a.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3Double"/> to be converted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> equivalent to <paramref name="a"/>
		/// </returns>
		public static implicit operator Vertex3Double(Vertex3d a)
		{
			return (new Vertex3Double(a.x, a.y, a.z));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3Double Zero = new Vertex3Double(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3Double One = new Vertex3Double(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3Double UnitX = new Vertex3Double(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3Double UnitY = new Vertex3Double(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3Double UnitZ = new Vertex3Double(0.0f, 0.0f, 1.0f);

		#endregion

		#region ICopiable<Vertex3> Implementation

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see name="Vertex3Double"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(Vertex3Double other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			X = other.X;
			Y = other.Y;
			Z = other.Z;
		}

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Object"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(object other)
		{
			if (other is Vertex3Double)
				Copy(other as Vertex3Double);				// Copoy reference type
			else if (other is Vertex3f)
				Copy(new Vertex3Double((Vertex3f)other));	// Copy corresponding value type, for animation system
			else
				throw new ArgumentException("not supported object", "other");
		}

		#endregion
	}

}