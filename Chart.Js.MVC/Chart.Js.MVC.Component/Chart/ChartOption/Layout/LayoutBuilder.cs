// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LayoutBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LayoutBuilder.
	/// </summary>
	public class LayoutBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Layout _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="LayoutBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public LayoutBuilder(Layout component)
		{
			_component = component;
		}

		/// <summary>
		/// Paddings the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>LayoutBuilder.</returns>
		public LayoutBuilder Padding(Action<PaddingBuilder> action)
		{
			_component.Padding = _component.Padding ?? new Padding();
			var factory = new PaddingBuilder(_component.Padding);
			action(factory);
			return this;
		}
	}
}