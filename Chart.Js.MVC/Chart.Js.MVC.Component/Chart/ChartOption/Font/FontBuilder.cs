// ***********************************************************************
// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="FontBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class FontBuilder.
	/// </summary>
	/// <typeparam name="TFont">The type of the t font.</typeparam>
	/// <typeparam name="TFontBuilder">The type of the t font builder.</typeparam>
	public class FontBuilder<TFont, TFontBuilder>
		where TFont : Font
		where TFontBuilder : FontBuilder<TFont, TFontBuilder>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="FontBuilder{TFont, TFontBuilder}"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public FontBuilder(TFont component)
		{
			Component = component;
		}

		/// <summary>
		/// Gets the component.
		/// </summary>
		/// <value>The component.</value>
		protected internal TFont Component
		{
			get;
		}

		/// <summary>
		/// Fonts the color.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TFontBuilder.</returns>
		public TFontBuilder FontColor(string value)
		{
			Component.FontColor = value;
			return this as TFontBuilder;
		}

		/// <summary>
		/// Fonts the family.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TFontBuilder.</returns>
		public TFontBuilder FontFamily(string value)
		{
			Component.FontFamily = value;
			return this as TFontBuilder;
		}

		/// <summary>
		/// Fonts the size.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TFontBuilder.</returns>
		public TFontBuilder FontSize(int value)
		{
			Component.FontSize = value;
			return this as TFontBuilder;
		}

		/// <summary>
		/// Fonts the style.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TFontBuilder.</returns>
		public TFontBuilder FontStyle(FontStyle value)
		{
			Component.FontStyle = value;
			return this as TFontBuilder;
		}
	}
}