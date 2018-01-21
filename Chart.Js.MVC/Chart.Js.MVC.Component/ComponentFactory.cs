// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ComponentFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Chart.Js.MVC.Component
{

	/// <summary>
	/// Class ComponentFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.IHideObjectMembers" />
	public class ComponentFactory : IHideObjectMembers
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ComponentFactory"/> class.
		/// </summary>
		/// <param name="helper">The helper.</param>
		public ComponentFactory(HtmlHelper helper)
		{
			HtmlHelper = helper;
		}

		/// <summary>
		/// Gets or sets the HTML helper.
		/// </summary>
		/// <value>The HTML helper.</value>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HtmlHelper HtmlHelper
		{
			get;
			set;
		}

		#region Builders

		/// <summary>
		/// Pies the chart.
		/// </summary>
		/// <returns>PieBuilder.</returns>
		public virtual PieBuilder PieChart()
		{
			return new PieBuilder(new Pie(), HtmlHelper);
		}

		/// <summary>
		/// Doughnuts the chart.
		/// </summary>
		/// <returns>PieBuilder.</returns>
		public virtual PieBuilder DoughnutChart()
		{
			return new PieBuilder(new Doughnut(), HtmlHelper);
		}

		/// <summary>
		/// Lines the chart.
		/// </summary>
		/// <returns>LineBuilder.</returns>
		public virtual LineBuilder LineChart()
		{
			return new LineBuilder(new Line(), HtmlHelper);
		}

		/// <summary>
		/// Bars the chart.
		/// </summary>
		/// <returns>BarBuilder.</returns>
		public virtual BarBuilder BarChart()
		{
			return new BarBuilder(new Bar(), HtmlHelper);
		}

		/// <summary>
		/// Horizontals the bar chart.
		/// </summary>
		/// <returns>BarBuilder.</returns>
		public virtual BarBuilder HorizontalBarChart()
		{
			return new BarBuilder(new HorizontalBar(), HtmlHelper);
		}

		/// <summary>
		/// Radars the chart.
		/// </summary>
		/// <returns>RadarBuilder.</returns>
		public virtual RadarBuilder RadarChart()
		{
			return new RadarBuilder(new Radar(), HtmlHelper);
		}

		/// <summary>
		/// Bubbles the chart.
		/// </summary>
		/// <returns>BubbleBuilder.</returns>
		public virtual BubbleBuilder BubbleChart()
		{
			return new BubbleBuilder(new Bubble(), HtmlHelper);
		}

		/// <summary>
		/// Polars the area chart.
		/// </summary>
		/// <returns>PolarBuilder.</returns>
		public virtual PolarBuilder PolarAreaChart()
		{
			return new PolarBuilder(new Polar(), HtmlHelper);
		}

		#endregion

	}

}
