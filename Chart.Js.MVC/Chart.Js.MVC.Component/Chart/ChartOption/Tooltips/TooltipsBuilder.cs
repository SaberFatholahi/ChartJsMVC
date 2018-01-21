// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="TooltipsBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class TooltipsBuilder.
	/// </summary>
	public class TooltipsBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Tooltips _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="TooltipsBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public TooltipsBuilder(Tooltips component)
		{
			_component = component;
		}

		/// <summary>
		/// Enableds the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder Enabled(bool value)
		{
			_component.Enabled = value;
			return this;
		}

		/// <summary>
		/// Modes the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder Mode(InteractionModes value)
		{
			_component.Mode = value;
			return this;
		}

		/// <summary>
		/// Intersects the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder Intersect(bool value)
		{
			_component.Intersect = value;
			return this;
		}

		/// <summary>
		/// Positions the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder Position(PositionModes value)
		{
			_component.Position = value;
			return this;
		}

		/// <summary>
		/// Backgrounds the color.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BackgroundColor(string value)
		{
			_component.BackgroundColor = value;
			return this;
		}

		/// <summary>
		/// Titles the font family.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleFontFamily(string value)
		{
			_component.TitleFontFamily = value;
			return this;
		}

		/// <summary>
		/// Titles the size of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleFontSize(int value)
		{
			_component.TitleFontSize = value;
			return this;
		}

		/// <summary>
		/// Titles the font style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleFontStyle(FontStyle value)
		{
			_component.TitleFontStyle = value;
			return this;
		}

		/// <summary>
		/// Titles the color of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleFontColor(string value)
		{
			_component.TitleFontColor = value;
			return this;
		}

		/// <summary>
		/// Titles the spacing.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleSpacing(int value)
		{
			_component.TitleSpacing = value;
			return this;
		}

		/// <summary>
		/// Titles the margin bottom.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder TitleMarginBottom(int value)
		{
			_component.TitleMarginBottom = value;
			return this;
		}

		/// <summary>
		/// Bodies the font family.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BodyFontFamily(string value)
		{
			_component.BodyFontFamily = value;
			return this;
		}

		/// <summary>
		/// Bodies the size of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BodyFontSize(int value)
		{
			_component.BodyFontSize = value;
			return this;
		}

		/// <summary>
		/// Bodies the font style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BodyFontStyle(FontStyle value)
		{
			_component.BodyFontStyle = value;
			return this;
		}

		/// <summary>
		/// Bodies the color of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BodyFontColor(string value)
		{
			_component.BodyFontColor = value;
			return this;
		}

		/// <summary>
		/// Bodies the spacing.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BodySpacing(int value)
		{
			_component.BodySpacing = value;
			return this;
		}

		/// <summary>
		/// Footers the font family.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterFontFamily(string value)
		{
			_component.FooterFontFamily = value;
			return this;
		}

		/// <summary>
		/// Footers the size of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterFontSize(int value)
		{
			_component.FooterFontSize = value;
			return this;
		}

		/// <summary>
		/// Footers the font style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterFontStyle(FontStyle value)
		{
			_component.FooterFontStyle = value;
			return this;
		}

		/// <summary>
		/// Footers the color of the font.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterFontColor(string value)
		{
			_component.FooterFontColor = value;
			return this;
		}

		/// <summary>
		/// Footers the spacing.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterSpacing(int value)
		{
			_component.FooterSpacing = value;
			return this;
		}

		/// <summary>
		/// Footers the margin top.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder FooterMarginTop(int value)
		{
			_component.FooterMarginTop = value;
			return this;
		}

		/// <summary>
		/// xes the padding.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder XPadding(int value)
		{
			_component.XPadding = value;
			return this;
		}

		/// <summary>
		/// ies the padding.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder YPadding(int value)
		{
			_component.YPadding = value;
			return this;
		}

		/// <summary>
		/// Carets the padding.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder CaretPadding(int value)
		{
			_component.CaretPadding = value;
			return this;
		}

		/// <summary>
		/// Carets the size.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder CaretSize(int value)
		{
			_component.CaretSize = value;
			return this;
		}

		/// <summary>
		/// Corners the radius.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder CornerRadius(int value)
		{
			_component.CornerRadius = value;
			return this;
		}

		/// <summary>
		/// Multis the key background.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder MultiKeyBackground(string value)
		{
			_component.MultiKeyBackground = value;
			return this;
		}

		/// <summary>
		/// Displays the colors.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder DisplayColors(bool value)
		{
			_component.DisplayColors = value;
			return this;
		}

		/// <summary>
		/// Borders the color.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BorderColor(string value)
		{
			_component.BorderColor = value;
			return this;
		}

		/// <summary>
		/// Borders the width.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder BorderWidth(int value)
		{
			_component.BorderWidth = value;
			return this;
		}

		/// <summary>
		/// Called when [filter].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder OnFilter(Func<object, HelperResult> value)
		{
			_component.OnFilter = value;
			return this;
		}

		/// <summary>
		/// Called when [item sort].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TooltipsBuilder.</returns>
		public TooltipsBuilder OnItemSort(Func<object, HelperResult> value)
		{
			_component.OnItemSort = value;
			return this;
		}
	}
}