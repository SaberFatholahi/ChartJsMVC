// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ScalesBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ScalesBuilder.
	/// </summary>
	public class ScalesBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Scales _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="ScalesBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public ScalesBuilder(Scales component)
		{
			_component = component;
		}

		/// <summary>
		/// xes the axes.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ScalesBuilder.</returns>
		public ScalesBuilder XAxes(Action<AxesBuilder> action)
		{
			_component.XAxes = _component.XAxes ?? new List<Axes>();
			var item = new Axes();
			_component.XAxes.Add(item);
			var factory = new AxesBuilder(item);
			action(factory);
			return this;
		}

		/// <summary>
		/// ies the axes.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ScalesBuilder.</returns>
		public ScalesBuilder YAxes(Action<AxesBuilder> action)
		{
			_component.YAxes = _component.YAxes ?? new List<Axes>();
			var item = new Axes();
			_component.YAxes.Add(item);
			var factory = new AxesBuilder(item);
			action(factory);
			return this;
		}
	}
}