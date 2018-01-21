// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Radar.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Radar.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.ChartComponent" />
	public class Radar : ChartComponent
	{
		/// <summary>
		/// Gets or sets the type of the chart.
		/// </summary>
		/// <value>The type of the chart.</value>
		public override ChartType ChartType { get; set; } = ChartType.Radar;

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
		[JsonProperty(PropertyName = "data")]
		public virtual ChartData<RadarDataset> Data { get; set; } = new ChartData<RadarDataset>();
	}
}
