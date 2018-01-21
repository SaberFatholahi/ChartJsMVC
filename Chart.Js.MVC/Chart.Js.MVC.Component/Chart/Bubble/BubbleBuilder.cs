// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BubbleBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BubbleBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartBuilder{Chart.Js.MVC.Component.Bubble, Chart.Js.MVC.Component.BubbleBuilder}" />
	public class BubbleBuilder : ChartBuilder<Bubble, BubbleBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BubbleBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		public BubbleBuilder(Bubble component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Labelses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>BubbleBuilder.</returns>
		public BubbleBuilder Labels(Action<ItemsFactory<string>> action)
		{
			var factory = new ItemsFactory<string>(Component.Data.Labels);
			action(factory);
			return this;
		}

		/// <summary>
		/// Datasetses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>BubbleBuilder.</returns>
		public BubbleBuilder Datasets(Action<BubbleDatasetFactory> action)
		{
			var factory = new BubbleDatasetFactory(Component.Data.Datasets);
			action(factory);
			return this;
		}
	}
}
