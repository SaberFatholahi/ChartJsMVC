// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PolarDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PolarDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.PolarDataset, Chart.Js.MVC.Component.PolarDatasetBuilder}" />
	public class PolarDatasetBuilder : DatasetBuilder<PolarDataset, PolarDatasetBuilder>
	{
		/// <summary>
		/// Backgrounds the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PolarDatasetBuilder.</returns>
		public PolarDatasetBuilder BackgroundColors(params string[] value)
		{
			Dataset.BackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Borders the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PolarDatasetBuilder.</returns>
		public PolarDatasetBuilder BorderColors(params string[] value)
		{
			Dataset.BorderColor = value;
			return this;
		}
		/// <summary>
		/// Borders the widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PolarDatasetBuilder.</returns>
		public PolarDatasetBuilder BorderWidths(params int[] value)
		{
			Dataset.BorderWidth = value;
			return this;
		}
	}
}
