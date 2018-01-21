// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BorderSkipped.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Enum BorderSkipped
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BorderSkipped
	{
		/// <summary>
		/// The bottom
		/// </summary>
		[EnumMember(Value = "bottom")]
		Bottom,
		/// <summary>
		/// The left
		/// </summary>
		[EnumMember(Value = "left")]
		Left,
		/// <summary>
		/// The top
		/// </summary>
		[EnumMember(Value = "top")]
		Top,
		/// <summary>
		/// The right
		/// </summary>
		[EnumMember(Value = "right")]
		Right,
	}
}