// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Axes.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Axes.
	/// </summary>
	public class Axes
	{
		/// <summary>
		/// Gets or sets the scale label.
		/// </summary>
		/// <value>The scale label.</value>
		[JsonProperty(PropertyName = "scaleLabel")]
		public ScaleLabel ScaleLabel { get; set; }

		/// <summary>
		/// Gets or sets the ticks.
		/// </summary>
		/// <value>The ticks.</value>
		[JsonProperty(PropertyName = "ticks")]
		public Ticks Ticks { get; set; }

		/// <summary>
		/// Gets or sets the grid lines.
		/// </summary>
		/// <value>The grid lines.</value>
		[JsonProperty(PropertyName = "gridLines")]
		public GridLines GridLines { get; set; }

		//public string type => "linear";

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Axes"/> is stacked.
		/// </summary>
		/// <value><c>null</c> if [stacked] contains no value, <c>true</c> if [stacked]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "stacked")]
		public bool? Stacked { get; set; }

	}
}