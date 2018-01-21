// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BarDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BarDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.BarDataset, Chart.Js.MVC.Component.BarDatasetBuilder}" />
	public class BarDatasetFactory: DatasetFactory<BarDataset, BarDatasetBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BarDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public BarDatasetFactory(IList<BarDataset> items):base(items)
        {
        }
    }
}
