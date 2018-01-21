// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BarDataset.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BarDataset.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Dataset" />
	public class BarDataset : Dataset
	{

		/// <summary>
		/// Gets or sets the x axis identifier.
		/// </summary>
		/// <value>The x axis identifier.</value>
		[JsonProperty(PropertyName = "xAxisID")]
		public string XAxisId { get; set; }

		/// <summary>
		/// Gets or sets the y axis identifier.
		/// </summary>
		/// <value>The y axis identifier.</value>
		[JsonProperty(PropertyName = "yAxisID")]
		public string YAxisId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="BarDataset"/> is fill.
		/// </summary>
		/// <value><c>null</c> if [fill] contains no value, <c>true</c> if [fill]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "fill")]
		public bool? Fill { get; set; }

		/// <summary>
		/// Gets or sets the border skipped.
		/// </summary>
		/// <value>The border skipped.</value>
		[JsonProperty(PropertyName = "borderSkipped")]
		public BorderSkipped? BorderSkipped { get; set; }

		/// <summary>
		/// Gets or sets the color of the hover background.
		/// </summary>
		/// <value>The color of the hover background.</value>
		[JsonProperty(PropertyName = "hoverBackgroundColor")]
		public override dynamic HoverBackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the color of the hover border.
		/// </summary>
		/// <value>The color of the hover border.</value>
		[JsonProperty(PropertyName = "hoverBorderColor")]
		public override dynamic HoverBorderColor { get; set; }

		/// <summary>
		/// Gets or sets the width of the hover border.
		/// </summary>
		/// <value>The width of the hover border.</value>
		[JsonProperty(PropertyName = "hoverBorderWidth")]
		public override dynamic HoverBorderWidth { get; set; }
	}
}
