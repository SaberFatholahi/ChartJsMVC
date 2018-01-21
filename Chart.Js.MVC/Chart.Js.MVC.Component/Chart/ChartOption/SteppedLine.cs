// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="SteppedLine.cs" company="">
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
	/// Enum SteppedLine
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SteppedLine
	{
		/// <summary>
		/// The false
		/// </summary>
		[EnumMember(Value = "false")]
		False,
		/// <summary>
		/// The true
		/// </summary>
		[EnumMember(Value = "true")]
		True,
		/// <summary>
		/// The before
		/// </summary>
		[EnumMember(Value = "before")]
		Before,
		/// <summary>
		/// The after
		/// </summary>
		[EnumMember(Value = "after")]
		After,
	}
}