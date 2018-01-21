// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="TicksBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class TicksBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.FontBuilder{Chart.Js.MVC.Component.Ticks, Chart.Js.MVC.Component.TicksBuilder}" />
	public class TicksBuilder : FontBuilder<Ticks, TicksBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicksBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public TicksBuilder(Ticks component) : base(component)
		{
		}

		/// <summary>
		/// Minimums the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TicksBuilder.</returns>
		public TicksBuilder Min(decimal value)
		{
			Component.Min = value;
			return this;
		}

		/// <summary>
		/// Maximums the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TicksBuilder.</returns>
		public TicksBuilder Max(decimal value)
		{
			Component.Max = value;
			return this;
		}

		/// <summary>
		/// Steps the size.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TicksBuilder.</returns>
		public TicksBuilder StepSize(decimal value)
		{
			Component.StepSize = value;
			return this;
		}

		/// <summary>
		/// Begins at zero.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TicksBuilder.</returns>
		public TicksBuilder BeginAtZero(bool value)
		{
			Component.BeginAtZero = value;
			return this;
		}

		/// <summary>
		/// Users the callback function.
		/// </summary>
		/// <param name="function">The function.</param>
		/// <returns>TicksBuilder.</returns>
		public TicksBuilder UserCallbackFunction(Func<object, HelperResult> function)
		{
			Component.UserCallbackFunction = function;
			return this;
		}
	}
}