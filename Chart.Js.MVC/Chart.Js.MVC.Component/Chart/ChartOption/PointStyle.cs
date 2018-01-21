// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PointStyle.cs" company="">
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
	/// Enum PointStyle
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PointStyle
	{
		/// <summary>
		/// The circle
		/// </summary>
		[EnumMember(Value = "circle")]
		Circle,
		/// <summary>
		/// The cross
		/// </summary>
		[EnumMember(Value = "cross")]
		Cross,
		/// <summary>
		/// The cross rot
		/// </summary>
		[EnumMember(Value = "crossRot")]
		CrossRot,
		/// <summary>
		/// The dash
		/// </summary>
		[EnumMember(Value = "dash")]
		Dash,
		/// <summary>
		/// The line
		/// </summary>
		[EnumMember(Value = "line")]
		Line,
		/// <summary>
		/// The rect
		/// </summary>
		[EnumMember(Value = "rect")]
		Rect,
		/// <summary>
		/// The rect rounded
		/// </summary>
		[EnumMember(Value = "rectRounded")]
		RectRounded,
		/// <summary>
		/// The rect rot
		/// </summary>
		[EnumMember(Value = "rectRot")]
		RectRot,
		/// <summary>
		/// The star
		/// </summary>
		[EnumMember(Value = "star")]
		Star,
		/// <summary>
		/// The triangle
		/// </summary>
		[EnumMember(Value = "triangle")]
		Triangle,

	}
}