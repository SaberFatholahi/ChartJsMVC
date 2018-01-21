// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="CapStyle.cs" company="">
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
	/// Enum CapStyle
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CapStyle
	{
		/// <summary>
		/// The butt
		/// </summary>
		[EnumMember(Value = "butt")]
		Butt,
		/// <summary>
		/// The round
		/// </summary>
		[EnumMember(Value = "round")]
		Round,
		/// <summary>
		/// The square
		/// </summary>
		[EnumMember(Value = "square")]
		Square,
	}
}