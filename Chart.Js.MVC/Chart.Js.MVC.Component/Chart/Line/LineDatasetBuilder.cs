// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LineDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LineDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.LineDataset, Chart.Js.MVC.Component.LineDatasetBuilder}" />
	public class LineDatasetBuilder : DatasetBuilder<LineDataset, LineDatasetBuilder>
	{
		/// <summary>
		/// xes the axis identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder XAxisId(string value)
		{
			Dataset.XAxisId = value;
			return this;
		}
		/// <summary>
		/// ies the axis identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder YAxisId(string value)
		{
			Dataset.YAxisId = value;
			return this;
		}
		/// <summary>
		/// Borders the dashs.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder BorderDashs(params long[] value)
		{
			Dataset.BorderDash = new List<long>(value);
			return this;
		}
		/// <summary>
		/// Borders the dash offset.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder BorderDashOffset(long value)
		{
			Dataset.BorderDashOffset = value;
			return this;
		}
		/// <summary>
		/// Borders the cap style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder BorderCapStyle(CapStyle value)
		{
			Dataset.BorderCapStyle = value;
			return this;
		}
		/// <summary>
		/// Borders the join style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder BorderJoinStyle(JoinStyle value)
		{
			Dataset.BorderJoinStyle = value;
			return this;
		}
		/// <summary>
		/// Fills the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder Fill(bool value)
		{
			Dataset.Fill = value;
			return this;
		}
		/// <summary>
		/// Lines the tension.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder LineTension(long value)
		{
			Dataset.LineTension = value;
			return this;
		}
		/// <summary>
		/// Points the color of the background.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBackgroundColor(string value)
		{
			Dataset.PointBackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Points the background colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBackgroundColors(params string[] value)
		{
			Dataset.PointBackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Points the color of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBorderColor(string value)
		{
			Dataset.PointBorderColor = value;
			return this;
		}
		/// <summary>
		/// Points the border colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBorderColors(params string[] value)
		{
			Dataset.PointBorderColor = value;
			return this;
		}
		/// <summary>
		/// Points the width of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBorderWidth(long value)
		{
			Dataset.PointBorderWidth = value;
			return this;
		}
		/// <summary>
		/// Points the border widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointBorderWidths(params long[] value)
		{
			Dataset.PointBorderWidth = value;
			return this;
		}
		/// <summary>
		/// Points the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointRadius(long value)
		{
			Dataset.PointRadius = value;
			return this;
		}
		/// <summary>
		/// Points the radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointRadiuses(params long[] value)
		{
			Dataset.PointRadius = value;
			return this;
		}
		/// <summary>
		/// Points the style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointStyle(PointStyle value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Points the styles.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointStyles(params PointStyle[] value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Points the hit radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointHitRadius(long value)
		{
			Dataset.PointHitRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hit radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointHitRadiuses(params long[] value)
		{
			Dataset.PointHitRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hover radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointHoverRadius(long value)
		{
			Dataset.PointHoverRadius = value;
			return this;
		}
		/// <summary>
		/// Points the hover radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder PointHoverRadiuses(params long[] value)
		{
			Dataset.PointHoverRadius = value;
			return this;
		}
		/// <summary>
		/// Shows the line.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder ShowLine(bool value)
		{
			Dataset.ShowLine = value;
			return this;
		}
		/// <summary>
		/// Spans the gaps.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder SpanGaps(bool value)
		{
			Dataset.SpanGaps = value;
			return this;
		}
		/// <summary>
		/// Steppeds the line.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LineDatasetBuilder.</returns>
		public LineDatasetBuilder SteppedLine(SteppedLine value)
		{
			Dataset.SteppedLine = value;
			return this;
		}
	}
}
