// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Scales.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Scales.
	/// </summary>
	public class Scales
	{
		/// <summary>
		/// Gets or sets the x axes.
		/// </summary>
		/// <value>The x axes.</value>
		[JsonProperty(PropertyName = "xAxes")]
		public IList<Axes> XAxes { get; set; }

		/// <summary>
		/// Gets or sets the y axes.
		/// </summary>
		/// <value>The y axes.</value>
		[JsonProperty(PropertyName = "yAxes")]
		public IList<Axes> YAxes { get; set; }
	}
}