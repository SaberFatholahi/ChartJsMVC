// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ChartOptions.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;
using Chart.Js.MVC.Helpers;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ChartOptions.
	/// </summary>
	public class ChartOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ChartOptions"/> is responsive.
		/// </summary>
		/// <value><c>null</c> if [responsive] contains no value, <c>true</c> if [responsive]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "responsive")]
		public bool? Responsive { get; set; }

		/// <summary>
		/// Gets or sets the on resize.
		/// </summary>
		/// <value>The on resize.</value>
		[JsonProperty(PropertyName = "onResize")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnResize { get; set; }

		/// <summary>
		/// Gets or sets the on click.
		/// </summary>
		/// <value>The on click.</value>
		[JsonProperty(PropertyName = "onClick")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnClick { get; set; }

		/// <summary>
		/// Gets or sets the on hover.
		/// </summary>
		/// <value>The on hover.</value>
		[JsonProperty(PropertyName = "onHover")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnHover { get; set; }

		/// <summary>
		/// Gets or sets the on legend callback.
		/// </summary>
		/// <value>The on legend callback.</value>
		[JsonProperty(PropertyName = "legendCallback")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnLegendCallback { get; set; }

		/// <summary>
		/// Gets or sets the duration of the responsive animation.
		/// </summary>
		/// <value>The duration of the responsive animation.</value>
		[JsonProperty(PropertyName = "responsiveAnimationDuration")]
		public int? ResponsiveAnimationDuration { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [maintain aspect ratio].
		/// </summary>
		/// <value><c>null</c> if [maintain aspect ratio] contains no value, <c>true</c> if [maintain aspect ratio]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "maintainAspectRatio")]
		public bool? MaintainAspectRatio { get; set; }

		/// <summary>
		/// Gets or sets the legend.
		/// </summary>
		/// <value>The legend.</value>
		[JsonProperty(PropertyName = "legend")]
		public Legend Legend { get; set; }

		/// <summary>
		/// Gets or sets the tooltips.
		/// </summary>
		/// <value>The tooltips.</value>
		[JsonProperty(PropertyName = "tooltips")]
		public Tooltips Tooltips { get; set; }

		/// <summary>
		/// Gets or sets the animation.
		/// </summary>
		/// <value>The animation.</value>
		[JsonProperty(PropertyName = "animation")]
		public Animation Animation { get; set; }

		/// <summary>
		/// Gets or sets the layout.
		/// </summary>
		/// <value>The layout.</value>
		[JsonProperty(PropertyName = "layout")]
		public Layout Layout { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		[JsonProperty(PropertyName = "title")]
		public Title Title { get; set; }

		/// <summary>
		/// Gets or sets the scales.
		/// </summary>
		/// <value>The scales.</value>
		[JsonProperty(PropertyName = "scales")]
		public Scales Scales { get; set; }
	}
}