// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PieDatasetBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PieDatasetBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetBuilder{Chart.Js.MVC.Component.PieDataset, Chart.Js.MVC.Component.PieDatasetBuilder}" />
	public class PieDatasetBuilder : DatasetBuilder<PieDataset, PieDatasetBuilder>
	{
		/// <summary>
		/// Backgrounds the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PieDatasetBuilder.</returns>
		public PieDatasetBuilder BackgroundColors(params string[] value)
		{
			Dataset.BackgroundColor = value;
			return this;
		}
		/// <summary>
		/// Borders the colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PieDatasetBuilder.</returns>
		public PieDatasetBuilder BorderColors(params string[] value)
		{
			Dataset.BorderColor = value;
			return this;
		}
		/// <summary>
		/// Borders the widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PieDatasetBuilder.</returns>
		public PieDatasetBuilder BorderWidths(params int[] value)
		{
			Dataset.BorderWidth = value;
			return this;
		}
	}
}
