// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PolarBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PolarBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartBuilder{Chart.Js.MVC.Component.Polar, Chart.Js.MVC.Component.PolarBuilder}" />
	public class PolarBuilder : ChartBuilder<Polar, PolarBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PolarBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		public PolarBuilder(Polar component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Labelses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>PolarBuilder.</returns>
		public PolarBuilder Labels(Action<ItemsFactory<string>> action)
		{
			var factory = new ItemsFactory<string>(Component.Data.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Datasetses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>PolarBuilder.</returns>
		public PolarBuilder Datasets(Action<PolarDatasetFactory> action)
		{
			var factory = new PolarDatasetFactory(Component.Data.Datasets);
			action(factory);
			return this;
		}
	}

}
