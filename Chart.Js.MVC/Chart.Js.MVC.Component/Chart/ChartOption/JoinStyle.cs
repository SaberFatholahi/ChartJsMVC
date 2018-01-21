// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="JoinStyle.cs" company="">
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
	/// Enum JoinStyle
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum JoinStyle
	{
		/// <summary>
		/// The bevel
		/// </summary>
		[EnumMember(Value = "bevel")]
		Bevel,
		/// <summary>
		/// The round
		/// </summary>
		[EnumMember(Value = "round")]
		Round,
		/// <summary>
		/// The miter
		/// </summary>
		[EnumMember(Value = "miter")]
		Miter,
	}
}