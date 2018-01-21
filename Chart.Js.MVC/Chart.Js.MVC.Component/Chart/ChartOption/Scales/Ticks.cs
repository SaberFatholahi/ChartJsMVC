// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Ticks.cs" company="">
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
	/// Class Ticks.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Font" />
	public class Ticks : Font
	{
		/// <summary>
		/// Gets or sets the user callback function.
		/// </summary>
		/// <value>The user callback function.</value>
		[JsonProperty(PropertyName = "userCallback")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> UserCallbackFunction { get; set; }

		/// <summary>
		/// Gets or sets the maximum.
		/// </summary>
		/// <value>The maximum.</value>
		[JsonProperty(PropertyName = "max")]
		public decimal? Max { get; set; }

		/// <summary>
		/// Gets or sets the minimum.
		/// </summary>
		/// <value>The minimum.</value>
		[JsonProperty(PropertyName = "min")]
		public decimal? Min { get; set; }

		/// <summary>
		/// Gets or sets the size of the step.
		/// </summary>
		/// <value>The size of the step.</value>
		[JsonProperty(PropertyName = "stepSize")]
		public decimal? StepSize { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [begin at zero].
		/// </summary>
		/// <value><c>null</c> if [begin at zero] contains no value, <c>true</c> if [begin at zero]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "beginAtZero")]
		public bool? BeginAtZero { get; set; }
	}
}