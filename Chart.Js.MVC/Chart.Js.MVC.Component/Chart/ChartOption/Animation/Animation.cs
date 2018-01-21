// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Animation.cs" company="">
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
	/// Class Animation.
	/// </summary>
	public class Animation
	{
		/// <summary>
		/// Gets or sets the duration.
		/// </summary>
		/// <value>The duration.</value>
		[JsonProperty(PropertyName = "duration")]
		public int? Duration { get; set; }

		/// <summary>
		/// Gets or sets the easing animation.
		/// </summary>
		/// <value>The easing animation.</value>
		[JsonProperty(PropertyName = "easing")]
		public EasingAnimation? EasingAnimation { get; set; }

		/// <summary>
		/// Gets or sets the on progress.
		/// </summary>
		/// <value>The on progress.</value>
		[JsonProperty(PropertyName = "onProgress")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnProgress { get; set; }

		/// <summary>
		/// Gets or sets the on complete.
		/// </summary>
		/// <value>The on complete.</value>
		[JsonProperty(PropertyName = "onComplete")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnComplete { get; set; }
	}
}