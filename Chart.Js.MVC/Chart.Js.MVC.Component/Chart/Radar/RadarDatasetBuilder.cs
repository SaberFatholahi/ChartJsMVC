// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="RadarDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class RadarDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.RadarDataset, Chart.Js.MVC.Component.RadarDatasetBuilder}" />
	public class RadarDatasetBuilder : DatasetBuilder<RadarDataset, RadarDatasetBuilder>
	{
		/// <summary>
		/// Borders the dashs.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder BorderDashs(params long[] value)
		{
			Dataset.BorderDash = new List<long>(value);
			return this;
		}
		/// <summary>
		/// Borders the dash offset.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder BorderDashOffset(long value)
		{
			Dataset.BorderDashOffset = value;
			return this;
		}
		/// <summary>
		/// Borders the cap style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder BorderCapStyle(CapStyle value)
		{
			Dataset.BorderCapStyle = value;
			return this;
		}
		/// <summary>
		/// Borders the join style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder BorderJoinStyle(JoinStyle value)
		{
			Dataset.BorderJoinStyle = value;
			return this;
		}
		/// <summary>
		/// Fills the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder Fill(bool value)
		{
			Dataset.Fill = value;
			return this;
		}
		/// <summary>
		/// Radars the tension.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder RadarTension(long value)
		{
			Dataset.RadarTension = value;
			return this;
		}
		/// <summary>
		/// Points the color of the background.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBackgroundColor(string value)
		{
			Dataset.PointBackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Points the background colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBackgroundColors(params string[] value)
		{
			Dataset.PointBackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Points the color of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBorderColor(string value)
		{
			Dataset.PointBorderColor = value;
			return this;
		}
		/// <summary>
		/// Points the border colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBorderColors(params string[] value)
		{
			Dataset.PointBorderColor = value;
			return this;
		}
		/// <summary>
		/// Points the width of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBorderWidth(long value)
		{
			Dataset.PointBorderWidth = value;
			return this;
		}
		/// <summary>
		/// Points the border widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointBorderWidths(params long[] value)
		{
			Dataset.PointBorderWidth = value;
			return this;
		}
		/// <summary>
		/// Points the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointRadius(long value)
		{
			Dataset.PointRadius = value;
			return this;
		}
		/// <summary>
		/// Points the radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointRadiuses(params long[] value)
		{
			Dataset.PointRadius = value;
			return this;
		}
		/// <summary>
		/// Points the style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointStyle(PointStyle value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Points the styles.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointStyles(params PointStyle[] value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Points the hit radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointHitRadius(long value)
		{
			Dataset.PointHitRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hit radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointHitRadiuses(params long[] value)
		{
			Dataset.PointHitRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hover radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointHoverRadius(long value)
		{
			Dataset.PointHoverRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hover radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>RadarDatasetBuilder.</returns>
		public RadarDatasetBuilder PointHoverRadius(params long[] value)
		{
			Dataset.PointHoverRadius = value;
			return this;
		}
	}
}
