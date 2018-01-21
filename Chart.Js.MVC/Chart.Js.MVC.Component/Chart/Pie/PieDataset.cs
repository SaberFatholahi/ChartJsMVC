// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PieDataset.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PieDataset.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Dataset" />
	public class PieDataset : Dataset
	{
		/// <summary>
		/// Gets or sets the color of the hover background.
		/// </summary>
		/// <value>The color of the hover background.</value>
		[JsonProperty(PropertyName = "hoverBackgroundColor")]
		public override dynamic HoverBackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the color of the hover border.
		/// </summary>
		/// <value>The color of the hover border.</value>
		[JsonProperty(PropertyName = "hoverBorderColor")]
		public override dynamic HoverBorderColor { get; set; }

		/// <summary>
		/// Gets or sets the width of the hover border.
		/// </summary>
		/// <value>The width of the hover border.</value>
		[JsonProperty(PropertyName = "hoverBorderWidth")]
		public override dynamic HoverBorderWidth { get; set; }
	}
}
