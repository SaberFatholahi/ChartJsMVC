// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LegendBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LegendBuilder.
	/// </summary>
	public class LegendBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Legend _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="LegendBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public LegendBuilder(Legend component)
		{
			_component = component;
		}

		/// <summary>
		/// Displays the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder Display(bool value)
		{
			_component.Display = value;
			return this;
		}

		/// <summary>
		/// Fulls the width.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder FullWidth(bool value)
		{
			_component.FullWidth = value;
			return this;
		}

		/// <summary>
		/// Reverses the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder Reverse(bool value)
		{
			_component.Reverse = value;
			return this;
		}

		/// <summary>
		/// Positions the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder Position(Position value)
		{
			_component.Position = value;
			return this;
		}

		/// <summary>
		/// Labels the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder Label(Action<LabelsBuilder> action)
		{
			_component.Labels = _component.Labels ?? new Labels();
			var factory = new LabelsBuilder(_component.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Called when [hover].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder OnHover(Func<object, HelperResult> value)
		{
			_component.OnHover = value;
			return this;
		}

		/// <summary>
		/// Called when [click].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LegendBuilder.</returns>
		public LegendBuilder OnClick(Func<object, HelperResult> value)
		{
			_component.OnClick = value;
			return this;
		}
	}
}