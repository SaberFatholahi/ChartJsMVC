// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="TitleBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class TitleBuilder.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.FontBuilder{Chart.Js.MVC.Component.Title, Chart.Js.MVC.Component.TitleBuilder}" />
	public class TitleBuilder : FontBuilder<Title, TitleBuilder>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TitleBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public TitleBuilder(Title component) : base(component)
		{
		}

		/// <summary>
		/// Displays the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder Display(bool value)
		{
			Component.Display = value;
			return this;
		}

		/// <summary>
		/// Positions the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder Position(Position value)
		{
			Component.Position = value;
			return this;
		}

		/// <summary>
		/// Paddings the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder Padding(int value)
		{
			Component.Padding = value;
			return this;
		}

		/// <summary>
		/// Lines the height.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder LineHeight(string value)
		{
			Component.LineHeight = value;
			return this;
		}

		/// <summary>
		/// Texts the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder Text(string value)
		{
			Component.Text = value;
			return this;
		}

		/// <summary>
		/// Texts the specified add action.
		/// </summary>
		/// <param name="addAction">The add action.</param>
		/// <returns>TitleBuilder.</returns>
		public TitleBuilder Text(Action<ItemsFactory<string>> addAction)
		{
			var factory = new ItemsFactory<string>(Component.Text);
			addAction(factory);
			return this;
		}
	}
}