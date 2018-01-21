// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PositionModes.cs" company="">
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
	/// Enum PositionModes
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PositionModes
	{
		/// <summary>
		/// mode will place the tooltip at the average position of the items displayed in the tooltip.
		/// </summary>
		[EnumMember(Value = "average")]
		Average,
		/// <summary>
		/// will place the tooltip at the position of the element closest to the event position.
		/// </summary>
		[EnumMember(Value = "nearest")]
		Nearest,
	}
}