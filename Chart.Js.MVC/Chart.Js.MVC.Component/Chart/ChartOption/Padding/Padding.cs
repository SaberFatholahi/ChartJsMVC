// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Padding.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Padding.
	/// </summary>
	public class Padding
	{
		/// <summary>
		/// Gets or sets the left.
		/// </summary>
		/// <value>The left.</value>
		[JsonProperty(PropertyName = "left")]
		public int? Left { get; set; }

		/// <summary>
		/// Gets or sets the right.
		/// </summary>
		/// <value>The right.</value>
		[JsonProperty(PropertyName = "right")]
		public int? Right { get; set; }

		/// <summary>
		/// Gets or sets the top.
		/// </summary>
		/// <value>The top.</value>
		[JsonProperty(PropertyName = "top")]
		public int? Top { get; set; }

		/// <summary>
		/// Gets or sets the bottom.
		/// </summary>
		/// <value>The bottom.</value>
		[JsonProperty(PropertyName = "bottom")]
		public int? Bottom { get; set; }
	}
}