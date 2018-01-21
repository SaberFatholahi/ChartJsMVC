// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="GridLinesBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class GridLinesBuilder.
	/// </summary>
	public class GridLinesBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly GridLines _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="GridLinesBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public GridLinesBuilder(GridLines component)
		{
			_component = component;
		}

		/// <summary>
		/// Offsets the grid lines.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>GridLinesBuilder.</returns>
		public GridLinesBuilder OffsetGridLines(bool value)
		{
			_component.OffsetGridLines = value;
			return this;
		}
	}
}