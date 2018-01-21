// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Legend.cs" company="">
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
	/// Class Legend.
	/// </summary>
	public class Legend
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Legend"/> is display.
		/// </summary>
		/// <value><c>null</c> if [display] contains no value, <c>true</c> if [display]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "display")]
		public bool? Display { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [full width].
		/// </summary>
		/// <value><c>null</c> if [full width] contains no value, <c>true</c> if [full width]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "fullWidth")]
		public bool? FullWidth { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Legend"/> is reverse.
		/// </summary>
		/// <value><c>null</c> if [reverse] contains no value, <c>true</c> if [reverse]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "reverse")]
		public bool? Reverse { get; set; }

		/// <summary>
		/// Gets or sets the position.
		/// </summary>
		/// <value>The position.</value>
		[JsonProperty(PropertyName = "position")]
		public Position? Position { get; set; }

		/// <summary>
		/// Gets or sets the labels.
		/// </summary>
		/// <value>The labels.</value>
		[JsonProperty(PropertyName = "labels")]
		public Labels Labels { get; set; }

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

	}
}
