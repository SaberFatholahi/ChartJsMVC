// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="RadarDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class RadarDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.RadarDataset, Chart.Js.MVC.Component.RadarDatasetBuilder}" />
	public class RadarDatasetFactory : DatasetFactory<RadarDataset, RadarDatasetBuilder>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="RadarDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public RadarDatasetFactory(IList<RadarDataset> items) : base(items)
		{
		}
	}
}
