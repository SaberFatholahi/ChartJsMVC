// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="FontStyle.cs" company="">
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
	/// Enum FontStyle
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FontStyle
	{
		/// <summary>
		/// The normal
		/// </summary>
		[EnumMember(Value = "normal")]
		Normal,
		/// <summary>
		/// The italic
		/// </summary>
		[EnumMember(Value = "italic")]
		Italic,
		/// <summary>
		/// The oblique
		/// </summary>
		[EnumMember(Value = "oblique")]
		Oblique,
		/// <summary>
		/// The initial
		/// </summary>
		[EnumMember(Value = "initial")]
		Initial,
	}
}