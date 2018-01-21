// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LineBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LineBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartBuilder{Chart.Js.MVC.Component.Line, Chart.Js.MVC.Component.LineBuilder}" />
	public class LineBuilder : ChartBuilder<Line, LineBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LineBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		public LineBuilder(Line component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Labelses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>LineBuilder.</returns>
		public LineBuilder Labels(Action<ItemsFactory<string>> action)
		{
			var factory = new ItemsFactory<string>(Component.Data.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Datasetses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>LineBuilder.</returns>
		public LineBuilder Datasets(Action<LineDatasetFactory> action)
		{
			var factory = new LineDatasetFactory(Component.Data.Datasets);
			action(factory);
			return this;
		}
	}
}
