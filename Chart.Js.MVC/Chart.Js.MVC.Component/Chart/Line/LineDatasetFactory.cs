// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LineDatasetFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LineDatasetFactory.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.DatasetFactory{Chart.Js.MVC.Component.LineDataset, Chart.Js.MVC.Component.LineDatasetBuilder}" />
	public class LineDatasetFactory : DatasetFactory<LineDataset, LineDatasetBuilder>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LineDatasetFactory"/> class.
		/// </summary>
		/// <param name="items">The items.</param>
		public LineDatasetFactory(IList<LineDataset> items) : base(items)
		{
		}
	}
}
