// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ChartComponent.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ChartComponent.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.Component" />
	public abstract class ChartComponent : Component
	{

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		[JsonIgnore]
		public string Title { get; set; }
		/// <summary>
		/// Gets a value indicating whether [name is required].
		/// </summary>
		/// <value><c>true</c> if [name is required]; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public override bool NameIsRequired => true;
		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		[JsonIgnore]
		public string Height { get; set; } = "250px";
		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		[JsonIgnore]
		public string Width { get; set; }
		/// <summary>
		/// Gets or sets the CSS class.
		/// </summary>
		/// <value>The CSS class.</value>
		[JsonIgnore]
		public string CssClass { get; set; }
		/// <summary>
		/// Gets or sets the icon class.
		/// </summary>
		/// <value>The icon class.</value>
		[JsonIgnore]
		public string IconClass { get; set; } = "fa";
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		[JsonIgnore]
		public ComponentState State { get; set; } = ComponentState.Primary;
		/// <summary>
		/// Gets the permissions.
		/// </summary>
		/// <value>The permissions.</value>
		[JsonIgnore]
		public List<long> Permissions { get; } = new List<long>();
		/// <summary>
		/// Gets or sets a value indicating whether this instance has collapse button.
		/// </summary>
		/// <value><c>true</c> if this instance has collapse button; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public bool HasCollapseButton { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this instance has remove button.
		/// </summary>
		/// <value><c>true</c> if this instance has remove button; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public bool HasRemoveButton { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this instance has header.
		/// </summary>
		/// <value><c>true</c> if this instance has header; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public bool HasHeader { get; set; } = true;
		/// <summary>
		/// Gets or sets a value indicating whether [load ajax].
		/// </summary>
		/// <value><c>true</c> if [load ajax]; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public bool LoadAjax { get; set; }

		/// <summary>
		/// Gets or sets the type of the chart.
		/// </summary>
		/// <value>The type of the chart.</value>
		[JsonProperty(PropertyName = "type")]
		public virtual ChartType ChartType { get; set; } = ChartType.Line;

		/// <summary>
		/// Gets or sets the chart options.
		/// </summary>
		/// <value>The chart options.</value>
		[JsonProperty(PropertyName = "options")]
		public ChartOptions ChartOptions { get; set; } = new ChartOptions();
	}
}
