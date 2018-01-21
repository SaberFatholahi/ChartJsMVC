// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BubbleDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BubbleDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.BubbleDataset, Chart.Js.MVC.Component.BubbleDatasetBuilder}" />
	public class BubbleDatasetBuilder : DatasetBuilder<BubbleDataset, BubbleDatasetBuilder>
	{
		/// <summary>
		/// Hovers the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder HoverRadius(long value)
		{
			Dataset.HoverRadius = value;
			return this;
		}
		/// <summary>
		/// Hovers the radiuses.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder HoverRadiuses(params long[] value)
		{
			Dataset.HoverRadius = value;
			return this;
		}
		/// <summary>
		/// Hits the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder HitRadius(params long[] value)
		{
			Dataset.HitRadius = value;
			return this;
		}
		/// <summary>
		/// Hits the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder HitRadius(long value)
		{
			Dataset.HitRadius = value;
			return this;
		}
		/// <summary>
		/// Points the style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder PointStyle(PointStyle value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Points the style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder PointStyle(params PointStyle[] value)
		{
			Dataset.PointStyle = value;
			return this;
		}
		/// <summary>
		/// Radiuses the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder Radius(long value)
		{
			Dataset.Radius = value;
			return this;
		}
		/// <summary>
		/// Radiuseses the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BubbleDatasetBuilder.</returns>
		public BubbleDatasetBuilder Radiuses(params long[] value)
		{
			Dataset.Radius = value;
			return this;
		}
	}
}
