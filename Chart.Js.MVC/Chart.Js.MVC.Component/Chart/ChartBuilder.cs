// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ChartBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ChartBuilder.
	/// </summary>
	/// <typeparam name="TComponent">The type of the t component.</typeparam>
	/// <typeparam name="TBuilder">The type of the t builder.</typeparam>
	/// <seealso cref="Chart.Js.MVC.Component.ComponentBuilder{TComponent, TBuilder}" />
	public abstract class ChartBuilder<TComponent, TBuilder> : ComponentBuilder<TComponent, TBuilder>
		where TComponent : ChartComponent
		where TBuilder : ComponentBuilder<TComponent, TBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChartBuilder{TComponent, TBuilder}"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		protected ChartBuilder(TComponent component, HtmlHelper htmlHelper)
			: base(component, htmlHelper)
		{
		}

		/// <summary>
		/// Titles the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Title(string value)
		{
			Component.Title = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Heights the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Height(string value)
		{
			Component.Height = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Widthes the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Width(string value)
		{
			Component.Width = value;
			return this as TBuilder;
		}

		/// <summary>
		/// CSSs the class.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder CssClass(string value)
		{
			Component.CssClass = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Permissionses the specified values.
		/// </summary>
		/// <param name="values">The values.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Permissions(params long[] values)
		{
			if (values != null)
				Component.Permissions.AddRange(values);
			return this as TBuilder;
		}

		/// <summary>
		/// States the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder State(ComponentState value)
		{
			Component.State = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Determines whether the specified value has header.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TBuilder.</returns>
		public TBuilder HasHeader(bool value)
		{
			Component.HasHeader = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Determines whether [has collapse button] [the specified value].
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TBuilder.</returns>
		public TBuilder HasCollapseButton(bool value)
		{
			Component.HasCollapseButton = value;
			return this as TBuilder;
		}
		/// <summary>
		/// Determines whether [has remove button] [the specified value].
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TBuilder.</returns>
		public TBuilder HasRemoveButton(bool value)
		{
			Component.HasRemoveButton = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Loads the ajax.
		/// </summary>
		/// <returns>TBuilder.</returns>
		public TBuilder LoadAjax()
		{
			Component.LoadAjax = true;
			return this as TBuilder;
		}
		/// <summary>
		/// Optionses the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Options(ChartOptions value)
		{
			Component.ChartOptions = value;
			return this as TBuilder;
		}

		/// <summary>
		/// Optionses the specified add action.
		/// </summary>
		/// <param name="addAction">The add action.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder Options(Action<ChartOptionsBuilder> addAction)
		{
			var factory = new ChartOptionsBuilder(Component.ChartOptions);
			addAction(factory);
			return this as TBuilder;
		}

	}

}
