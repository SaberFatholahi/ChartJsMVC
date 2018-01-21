// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PieBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PieBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartBuilder{Chart.Js.MVC.Component.Pie, Chart.Js.MVC.Component.PieBuilder}" />
	public class PieBuilder : ChartBuilder<Pie, PieBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PieBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		public PieBuilder(Pie component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Labelses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>PieBuilder.</returns>
		public PieBuilder Labels(Action<ItemsFactory<string>> action)
		{
			var factory = new ItemsFactory<string>(Component.Data.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Datasetses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>PieBuilder.</returns>
		public PieBuilder Datasets(Action<PieDatasetFactory> action)
		{
			var factory = new PieDatasetFactory(Component.Data.Datasets);
			action(factory);
			return this;
		}
	}

}
