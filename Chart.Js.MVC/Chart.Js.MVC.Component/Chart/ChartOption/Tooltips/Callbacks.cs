// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-04-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-04-1396
// ***********************************************************************
// <copyright file="Callbacks.cs" company="">
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
	/// Class Callbacks.
	/// </summary>
	public class Callbacks
	{
		/// <summary>
		/// Gets or sets the before title.
		/// </summary>
		/// <value>The before title.</value>
		[JsonProperty(PropertyName = "beforeTitle")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> BeforeTitle { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		[JsonProperty(PropertyName = "title")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> Title { get; set; }

		/// <summary>
		/// Gets or sets the after title.
		/// </summary>
		/// <value>The after title.</value>
		[JsonProperty(PropertyName = "afterTitle")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> AfterTitle { get; set; }

		/// <summary>
		/// Gets or sets the before body.
		/// </summary>
		/// <value>The before body.</value>
		[JsonProperty(PropertyName = "beforeBody")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> BeforeBody { get; set; }

		/// <summary>
		/// Gets or sets the before label.
		/// </summary>
		/// <value>The before label.</value>
		[JsonProperty(PropertyName = "beforeLabel")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> BeforeLabel { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
		[JsonProperty(PropertyName = "label")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> Label { get; set; }

		/// <summary>
		/// Gets or sets the color of the label.
		/// </summary>
		/// <value>The color of the label.</value>
		[JsonProperty(PropertyName = "labelColor")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> LabelColor { get; set; }

		/// <summary>
		/// Gets or sets the color of the label text.
		/// </summary>
		/// <value>The color of the label text.</value>
		[JsonProperty(PropertyName = "labelTextColor")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> LabelTextColor { get; set; }

		/// <summary>
		/// Gets or sets the after label.
		/// </summary>
		/// <value>The after label.</value>
		[JsonProperty(PropertyName = "afterLabel")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> AfterLabel { get; set; }

		/// <summary>
		/// Gets or sets the after body.
		/// </summary>
		/// <value>The after body.</value>
		[JsonProperty(PropertyName = "afterBody")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> AfterBody { get; set; }

		/// <summary>
		/// Gets or sets the before footer.
		/// </summary>
		/// <value>The before footer.</value>
		[JsonProperty(PropertyName = "beforeFooter")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> BeforeFooter { get; set; }

		/// <summary>
		/// Gets or sets the footer.
		/// </summary>
		/// <value>The footer.</value>
		[JsonProperty(PropertyName = "footer")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> Footer { get; set; }

		/// <summary>
		/// Gets or sets the after footer.
		/// </summary>
		/// <value>The after footer.</value>
		[JsonProperty(PropertyName = "afterFooter")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> AfterFooter { get; set; }
	}
}
