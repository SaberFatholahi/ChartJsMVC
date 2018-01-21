// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PolarDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PolarDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.PolarDataset, Chart.Js.MVC.Component.PolarDatasetBuilder}" />
	public class PolarDatasetFactory : DatasetFactory<PolarDataset, PolarDatasetBuilder>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="PolarDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public PolarDatasetFactory(IList<PolarDataset> items) : base(items)
		{
		}
	}
}
