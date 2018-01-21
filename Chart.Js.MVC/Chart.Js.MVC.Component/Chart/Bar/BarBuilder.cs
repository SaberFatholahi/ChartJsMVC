// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BarBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BarBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartBuilder{Chart.Js.MVC.Component.Bar, Chart.Js.MVC.Component.BarBuilder}" />
	public class BarBuilder : ChartBuilder<Bar, BarBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BarBuilder" /> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		public BarBuilder(Bar component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Labelses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>BarBuilder.</returns>
		public BarBuilder Labels(Action<ItemsFactory<string>> action)
		{
			var factory = new ItemsFactory<string>(Component.Data.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Datasetses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>BarBuilder.</returns>
		public BarBuilder Datasets(Action<BarDatasetFactory> action)
		{
			var factory = new BarDatasetFactory(Component.Data.Datasets);
			action(factory);
			return this;
		}

	}

}
