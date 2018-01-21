// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="GridLines.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class GridLines.
	/// </summary>
	public class GridLines
	{
		/// <summary>
		/// Gets or sets a value indicating whether [offset grid lines].
		/// </summary>
		/// <value><c>null</c> if [offset grid lines] contains no value, <c>true</c> if [offset grid lines]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "offsetGridLines")]
		public bool? OffsetGridLines { get; set; }
	}
}