// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="BubbleDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class BubbleDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.BubbleDataset, Chart.Js.MVC.Component.BubbleDatasetBuilder}" />
	public class BubbleDatasetFactory : DatasetFactory<BubbleDataset, BubbleDatasetBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BubbleDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public BubbleDatasetFactory(IList<BubbleDataset> items) : base(items)
		{
		}
	}
}
