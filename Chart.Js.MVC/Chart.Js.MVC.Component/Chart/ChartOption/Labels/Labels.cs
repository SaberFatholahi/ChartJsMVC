// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Labels.cs" company="">
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
	/// Class Labels.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Font" />
	public class Labels : Font
	{
		/// <summary>
		/// Gets or sets the width of the box.
		/// </summary>
		/// <value>The width of the box.</value>
		[JsonProperty(PropertyName = "boxWidth")]
		public int? BoxWidth { get; set; }

		/// <summary>
		/// Gets or sets the padding.
		/// </summary>
		/// <value>The padding.</value>
		[JsonProperty(PropertyName = "padding")]
		public int? Padding { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [use point style].
		/// </summary>
		/// <value><c>null</c> if [use point style] contains no value, <c>true</c> if [use point style]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "usePointStyle")]
		public bool? UsePointStyle { get; set; }

		/// <summary>
		/// Gets or sets the on generate labels.
		/// </summary>
		/// <value>The on generate labels.</value>
		[JsonProperty(PropertyName = "generateLabels")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnGenerateLabels { get; set; }

		/// <summary>
		/// Gets or sets the on filter.
		/// </summary>
		/// <value>The on filter.</value>
		[JsonProperty(PropertyName = "filter")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnFilter { get; set; }
	}
}