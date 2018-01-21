// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="AxesBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class AxesBuilder.
	/// </summary>
	public class AxesBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Axes _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="AxesBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public AxesBuilder(Axes component)
		{
			_component = component;
		}

		/// <summary>
		/// Scales the label.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>AxesBuilder.</returns>
		public AxesBuilder ScaleLabel(Action<ScaleLabelBuilder> action)
		{
			_component.ScaleLabel = _component.ScaleLabel ?? new ScaleLabel();
			var factory = new ScaleLabelBuilder(_component.ScaleLabel);
			action(factory);
			return this;
		}

		/// <summary>
		/// Grids the lines.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>AxesBuilder.</returns>
		public AxesBuilder GridLines(Action<GridLinesBuilder> action)
		{
			_component.GridLines = _component.GridLines ?? new GridLines();
			var factory = new GridLinesBuilder(_component.GridLines);
			action(factory);
			return this;
		}

		/// <summary>
		/// Tickses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>AxesBuilder.</returns>
		public AxesBuilder Ticks(Action<TicksBuilder> action)
		{
			_component.Ticks = _component.Ticks ?? new Ticks();
			var factory = new TicksBuilder(_component.Ticks);
			action(factory);
			return this;
		}

		/// <summary>
		/// Stackeds the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>AxesBuilder.</returns>
		public AxesBuilder Stacked(bool value)
		{
			_component.Stacked = value;
			return this;
		}
	}
}