// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BarDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BarDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.BarDataset, Chart.Js.MVC.Component.BarDatasetBuilder}" />
	public class BarDatasetBuilder : DatasetBuilder<BarDataset, BarDatasetBuilder>
	{
		/// <summary>
		/// Fills the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder Fill(bool value)
		{
			Dataset.Fill = value;
			return this;
		}
		/// <summary>
		/// xes the axis identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder XAxisId(string value)
		{
			Dataset.XAxisId = value;
			return this;
		}
		/// <summary>
		/// ies the axis identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder YAxisId(string value)
		{
			Dataset.YAxisId = value;
			return this;
		}
		/// <summary>
		/// Backgrounds the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder BackgroundColors(params string[] value)
		{
			Dataset.BackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Borders the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder BorderColors(params string[] value)
		{
			Dataset.BorderColor = value;
			return this;
		}
		/// <summary>
		/// Borders the widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder BorderWidths(params int[] value)
		{
			Dataset.BorderWidth = value;
			return this;
		}
		/// <summary>
		/// Borders the skipped.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>BarDatasetBuilder.</returns>
		public BarDatasetBuilder BorderSkipped(BorderSkipped value)
		{
			Dataset.BorderSkipped = value;
			return this;
		}
	}
}
