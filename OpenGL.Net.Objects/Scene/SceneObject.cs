﻿
// Copyright (C) 2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;
using System.Diagnostics;

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Scene object.
	/// </summary>
	public class SceneObject : UserGraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObject() : this(String.Empty)
		{

		}

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObject(string id) : base(id)
		{
			// The graphics state TransformState is always defined
			LinkResource(ObjectState);

			ObjectState.DefineState(new TransformState());
		}

		#endregion

		#region Scene Hierarchy

		/// <summary>
		/// Add a <see cref="SceneObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneObject">
		/// The <see cref="SceneObject"/> to be included in the children list of this instance.
		/// </param>
		public virtual void AddChild(SceneObject sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");
			if (sceneObject._ParentObject != null)
				throw new ArgumentException("already in graph");

			// Set the parent to this instance
			sceneObject._ParentObject = this;
			// Include object in children list
			_Children.Add(sceneObject);
			LinkResource(sceneObject);
		}

		/// <summary>
		/// Unlink this SceneObject from the graph.
		/// </summary>
		public virtual void Unlink()
		{
			if (_ParentObject == null)
				throw new ArgumentException("not in graph");

			bool res = _ParentObject._Children.Remove(this);
			Debug.Assert(res);

			_ParentObject = null;
		}

		/// <summary>
		/// Remove all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to remove.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that indicates whether at least an object was removed from the graph.
		/// </returns>
		public bool RemoveChildren(Predicate<SceneObject> match)
		{
			return (RemoveChildren(match, true));
		}

		/// <summary>
		/// Remove all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to remove.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that indicates whether at least an object was removed from the graph.
		/// </returns>
		public virtual bool RemoveChildren(Predicate<SceneObject> match, bool recurse)
		{
			if (match == null)
				throw new ArgumentNullException("match");

			if (_Children.RemoveAll(match) > 0)
				return (true);

			if (recurse) {
				bool res = false;

				foreach (SceneObject sceneObject in _Children)
					res |= sceneObject.RemoveChildren(match, true);

				return (res);
			} else
				return (false);
		}

		/// <summary>
		/// Find all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public ICollection<SceneObject> FindChildren(Predicate<SceneObject> match)
		{
			return (FindChildren(match, true));
		}

		/// <summary>
		/// Find all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public virtual ICollection<SceneObject> FindChildren(Predicate<SceneObject> match, bool recurse)
		{
			if (match == null)
				throw new ArgumentNullException("match");

			List<SceneObject> foundChildren = new List<SceneObject>();

			foundChildren.AddRange(_Children.FindAll(match));

			if (recurse) {
				foreach (SceneObject sceneObject in _Children)
					foundChildren.AddRange(sceneObject.FindChildren(match, true));
			}

			return (foundChildren);
		}

		/// <summary>
		/// Find the first <see cref="SceneObject"/> instance matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public SceneObject FindChild(Predicate<SceneObject> match)
		{
			return (FindChild(match, true));
		}

		/// <summary>
		/// Find the first <see cref="SceneObject"/> instance matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public SceneObject FindChild(Predicate<SceneObject> match, bool recurse)
		{
			List<SceneObject> foundChildren = (List<SceneObject>)FindChildren(match, recurse);

			if (foundChildren.Count > 0)
				return (foundChildren[0]);
			else
				return (null);
		}

		/// <summary>
		/// The SceneGraphObject that links this instance to the scene graph. If it null, this
		/// instance is the root node.
		/// </summary>
		private SceneObject _ParentObject;

		/// <summary>
		/// Children drawn after this SceneGraphObject.
		/// </summary>
		protected readonly List<SceneObject> _Children = new List<SceneObject>();

		#endregion

		#region Local Model

		/// <summary>
		/// The local projection: the projection matrix of the current vertex arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public IProjectionMatrix LocalProjection
		{
			get { return (((TransformStateBase)ObjectState[TransformStateBase.StateId]).LocalProjection); }
			set { ((TransformStateBase)ObjectState[TransformStateBase.StateId]).LocalProjection = value; }
		}

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public IModelMatrix LocalModel
		{
			get { return (((TransformStateBase)ObjectState[TransformStateBase.StateId]).LocalModel); }
			set { ((TransformStateBase)ObjectState[TransformStateBase.StateId]).LocalModel.Set(value); }
		}

		/// <summary>
		/// The world model: the transform of the current vertex arrays object space, considering inherited
		/// transform states from parent objects.
		/// </summary>
		public IModelMatrix WorldModel
		{
			get
			{
				IModelMatrix worldModel = (IModelMatrix)LocalModel.Clone();

				for (SceneObject parentObject = _ParentObject; parentObject != null; parentObject = parentObject._ParentObject)
					worldModel = worldModel.Multiply(_ParentObject.LocalModel);

				return (worldModel);
			}
		}
	
		#endregion

		#region Updating

		/// <summary>
		/// Update this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctxScene"/>.
		/// </exception>
		protected internal virtual void Update(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			CheckCurrentContext(ctx);

			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			// Update this object
			UpdateThis(ctx, ctxScene);
			// Update all children
			foreach (SceneObject sceneGraphObject in _Children)
				sceneGraphObject.Update(ctx, ctxScene);
		}

		/// <summary>
		/// Update this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected virtual void UpdateThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			
		}

		#endregion

		#region Drawing

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctxScene"/>.
		/// </exception>
		protected internal virtual void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			CheckCurrentContext(ctx);

			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(ObjectState);
			try {
				// Draw this object
				DrawThis(ctx, ctxScene);
				// Draw all children
				foreach (SceneObject sceneGraphObject in _Children)
					sceneGraphObject.Draw(ctx, ctxScene);
			} finally {
				ctxScene.GraphicsStateStack.Pop();
			}
		}

		/// <summary>
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected virtual void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			
		}

		/// <summary>
		/// The state relative to this SceneGraphObject.
		/// </summary>
		public readonly GraphicsStateSet ObjectState = new GraphicsStateSet();

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <remarks>
		/// All resources linked with <see cref="LinkResource(IGraphicsResource)"/> will be automatically created.
		/// </remarks>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Create object state
			ObjectState.Create(ctx);

			// Base implementation
			base.CreateObject(ctx);
			// Propagate creation to hierarchy
			foreach (SceneObject sceneGraphObject in _Children)
				sceneGraphObject.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Dispose object state
				ObjectState.Dispose();
				// Propagate disposition to hierarchy
				foreach (SceneObject sceneGraphObject in _Children)
					sceneGraphObject.Dispose();
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}