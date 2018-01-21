// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ScaleLabelBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ScaleLabelBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.FontBuilder{Chart.Js.MVC.Component.ScaleLabel, Chart.Js.MVC.Component.ScaleLabelBuilder}" />
	public class ScaleLabelBuilder : FontBuilder<ScaleLabel, ScaleLabelBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ScaleLabelBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public ScaleLabelBuilder(ScaleLabel component):base(component)
		{
		}

		/// <summary>
		/// Displays the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>ScaleLabelBuilder.</returns>
		public ScaleLabelBuilder Display(bool value)
		{
			Component.Display = value;
			return this;
		}

		/// <summary>
		/// Texts the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ScaleLabelBuilder.</returns>
		public ScaleLabelBuilder Text(string value)
		{
			Component.Text = value;
			return this;
		}

		/// <summary>
		/// Lines the height.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ScaleLabelBuilder.</returns>
		public ScaleLabelBuilder LineHeight(decimal value)
		{
			Component.LineHeight = value;
			return this;
		}

		/// <summary>
		/// Paddings the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ScaleLabelBuilder.</returns>
		public ScaleLabelBuilder Padding(Action<PaddingBuilder> action)
		{
			Component.Padding = Component.Padding ?? new Padding();
			var factory = new PaddingBuilder(Component.Padding);
			action(factory);
			return this;
		}
	}
}