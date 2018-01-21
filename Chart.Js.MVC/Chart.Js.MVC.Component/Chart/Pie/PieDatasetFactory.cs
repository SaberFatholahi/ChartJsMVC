// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PieDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PieDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.PieDataset, Chart.Js.MVC.Component.PieDatasetBuilder}" />
	public class PieDatasetFactory : DatasetFactory<PieDataset, PieDatasetBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PieDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public PieDatasetFactory(IList<PieDataset> items) : base(items)
		{
		}
	}
}
