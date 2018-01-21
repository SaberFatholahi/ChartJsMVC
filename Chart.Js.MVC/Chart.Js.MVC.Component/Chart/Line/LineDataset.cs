// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LineDataset.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LineDataset.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Dataset" />
	public class LineDataset : Dataset
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
		/// Gets or sets the border dash.
		/// </summary>
		/// <value>The border dash.</value>
		[JsonProperty(PropertyName = "borderDash")]
		public List<long> BorderDash { get; set; }

		/// <summary>
		/// Gets or sets the border dash offset.
		/// </summary>
		/// <value>The border dash offset.</value>
		[JsonProperty(PropertyName = "borderDashOffset")]
		public long? BorderDashOffset { get; set; }

		/// <summary>
		/// Gets or sets the border cap style.
		/// </summary>
		/// <value>The border cap style.</value>
		[JsonProperty(PropertyName = "borderCapStyle")]
		public CapStyle? BorderCapStyle { get; set; }

		/// <summary>
		/// Gets or sets the border join style.
		/// </summary>
		/// <value>The border join style.</value>
		[JsonProperty(PropertyName = "borderJoinStyle")]
		public JoinStyle? BorderJoinStyle { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="LineDataset"/> is fill.
		/// </summary>
		/// <value><c>true</c> if fill; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "fill")]
		public bool Fill { get; set; }

		/// <summary>
		/// Gets or sets the line tension.
		/// </summary>
		/// <value>The line tension.</value>
		[JsonProperty(PropertyName = "lineTension")]
		public long? LineTension { get; set; }

		/// <summary>
		/// Gets or sets the color of the point background.
		/// </summary>
		/// <value>The color of the point background.</value>
		[JsonProperty(PropertyName = "pointBackgroundColor")]
		public dynamic PointBackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the color of the point border.
		/// </summary>
		/// <value>The color of the point border.</value>
		[JsonProperty(PropertyName = "pointBorderColor")]
		public dynamic PointBorderColor { get; set; }

		/// <summary>
		/// Gets or sets the width of the point border.
		/// </summary>
		/// <value>The width of the point border.</value>
		[JsonProperty(PropertyName = "pointBorderWidth")]
		public dynamic PointBorderWidth { get; set; }

		/// <summary>
		/// Gets or sets the point radius.
		/// </summary>
		/// <value>The point radius.</value>
		[JsonProperty(PropertyName = "pointRadius")]
		public dynamic PointRadius { get; set; }

		/// <summary>
		/// Gets or sets the point style.
		/// </summary>
		/// <value>The point style.</value>
		[JsonProperty(PropertyName = "pointStyle")]
		public dynamic PointStyle { get; set; }

		/// <summary>
		/// Gets or sets the point hit radius.
		/// </summary>
		/// <value>The point hit radius.</value>
		[JsonProperty(PropertyName = "pointHitRadius")]
		public dynamic PointHitRadius { get; set; }

		/// <summary>
		/// Gets or sets the point hover radius.
		/// </summary>
		/// <value>The point hover radius.</value>
		[JsonProperty(PropertyName = "pointHoverRadius")]
		public dynamic PointHoverRadius { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [show line].
		/// </summary>
		/// <value><c>null</c> if [show line] contains no value, <c>true</c> if [show line]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "showLine")]
		public bool? ShowLine { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [span gaps].
		/// </summary>
		/// <value><c>null</c> if [span gaps] contains no value, <c>true</c> if [span gaps]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "spanGaps")]
		public bool? SpanGaps { get; set; }

		/// <summary>
		/// Gets or sets the stepped line.
		/// </summary>
		/// <value>The stepped line.</value>
		[JsonProperty(PropertyName = "steppedLine")]
		public SteppedLine? SteppedLine { get; set; }
	}
}
