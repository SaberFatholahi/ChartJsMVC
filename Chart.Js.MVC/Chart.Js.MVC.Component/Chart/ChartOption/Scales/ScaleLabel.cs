// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ScaleLabel.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ScaleLabel.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Font" />
	public class ScaleLabel : Font
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ScaleLabel"/> is display.
		/// </summary>
		/// <value><c>null</c> if [display] contains no value, <c>true</c> if [display]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "display")]
		public bool? Display { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		[JsonProperty(PropertyName = "labelString")]
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the height of the line.
		/// </summary>
		/// <value>The height of the line.</value>
		[JsonProperty(PropertyName = "lineHeight")]
		public decimal? LineHeight { get; set; }

		/// <summary>
		/// Gets or sets the padding.
		/// </summary>
		/// <value>The padding.</value>
		[JsonProperty(PropertyName = "padding")]
		public Padding Padding { get; set; }
	}
}