// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="LabelsBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class LabelsBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.FontBuilder{Chart.Js.MVC.Component.Labels, Chart.Js.MVC.Component.LabelsBuilder}" />
	public class LabelsBuilder : FontBuilder<Labels, LabelsBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LabelsBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public LabelsBuilder(Labels component) : base(component)
		{
		}

		/// <summary>
		/// Boxes the width.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LabelsBuilder.</returns>
		public LabelsBuilder BoxWidth(int value)
		{
			Component.BoxWidth = value;
			return this;
		}

		/// <summary>
		/// Paddings the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>LabelsBuilder.</returns>
		public LabelsBuilder Padding(int value)
		{
			Component.Padding = value;
			return this;
		}

		/// <summary>
		/// Uses the point style.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>LabelsBuilder.</returns>
		public LabelsBuilder UsePointStyle(bool value)
		{
			Component.UsePointStyle = value;
			return this;
		}

		/// <summary>
		/// Called when [filter].
		/// </summary>
		/// <param name="function">The function.</param>
		/// <returns>LabelsBuilder.</returns>
		public LabelsBuilder OnFilter(Func<object, HelperResult> function)
		{
			Component.OnFilter = function;
			return this;
		}

		/// <summary>
		/// Called when [generate labels].
		/// </summary>
		/// <param name="function">The function.</param>
		/// <returns>LabelsBuilder.</returns>
		public LabelsBuilder OnGenerateLabels(Func<object, HelperResult> function)
		{
			Component.OnGenerateLabels = function;
			return this;
		}
	}
}