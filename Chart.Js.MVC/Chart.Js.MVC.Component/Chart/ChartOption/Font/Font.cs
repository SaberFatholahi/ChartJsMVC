// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Font.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Font.
	/// </summary>
	public class Font
	{
		/// <summary>
		/// Gets or sets the color of the font.
		/// </summary>
		/// <value>The color of the font.</value>
		[JsonProperty(PropertyName = "fontColor")]
		public string FontColor { get; set; }

		/// <summary>
		/// Gets or sets the font family.
		/// </summary>
		/// <value>The font family.</value>
		[JsonProperty(PropertyName = "fontFamily")]
		public string FontFamily { get; set; }

		/// <summary>
		/// Gets or sets the size of the font.
		/// </summary>
		/// <value>The size of the font.</value>
		[JsonProperty(PropertyName = "fontSize")]
		public int? FontSize { get; set; }

		/// <summary>
		/// Gets or sets the font style.
		/// </summary>
		/// <value>The font style.</value>
		[JsonProperty(PropertyName = "fontStyle")]
		public FontStyle? FontStyle { get; set; }
	}
}