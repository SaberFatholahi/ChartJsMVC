// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="InteractionModes.cs" company="">
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
	/// Enum InteractionModes
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InteractionModes
	{
		/// <summary>
		/// Finds all of the items that intersect the point.
		/// </summary>
		[EnumMember(Value = "point")]
		Point,
		/// <summary>
		/// Gets the item that is nearest to the point. The nearest item is determined based on the distance to the center of the chart item (point, bar). If 2 or more items are at the same distance, the one with the smallest area is used. If intersect is true, this is only triggered when the mouse position intersects an item in the graph. This is very useful for combo charts where points are hidden behind bars.
		/// </summary>
		[EnumMember(Value = "nearest")]
		Nearest,
		/// <summary>
		/// Finds item at the same index. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item, in the x direction, is used to determine the index.
		/// </summary>
		[EnumMember(Value = "index")]
		Index,
		/// <summary>
		/// Returns all items that would intersect based on the X coordinate of the position only. Would be useful for a vertical cursor implementation. Note that this only applies to cartesian charts
		/// </summary>
		[EnumMember(Value = "x")]
		X,
		/// <summary>
		/// Returns all items that would intersect based on the Y coordinate of the position. This would be useful for a horizontal cursor implementation. Note that this only applies to cartesian charts.
		/// </summary>
		[EnumMember(Value = "y")]
		Y,
		/// <summary>
		/// Finds items in the same dataset. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index.
		/// </summary>
		[EnumMember(Value = "dataset")]
		Dataset,
	}
}