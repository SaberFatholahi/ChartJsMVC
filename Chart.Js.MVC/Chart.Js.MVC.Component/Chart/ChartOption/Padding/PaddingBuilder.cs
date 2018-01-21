// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="PaddingBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class PaddingBuilder.
	/// </summary>
	public class PaddingBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Padding _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="PaddingBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public PaddingBuilder(Padding component)
		{
			_component = component;
		}

		/// <summary>
		/// Lefts the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PaddingBuilder.</returns>
		public PaddingBuilder Left(int value)
		{
			_component.Left = value;
			return this;
		}

		/// <summary>
		/// Rights the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PaddingBuilder.</returns>
		public PaddingBuilder Right(int value)
		{
			_component.Right = value;
			return this;
		}

		/// <summary>
		/// Tops the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PaddingBuilder.</returns>
		public PaddingBuilder Top(int value)
		{
			_component.Top = value;
			return this;
		}

		/// <summary>
		/// Bottoms the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>PaddingBuilder.</returns>
		public PaddingBuilder Bottom(int value)
		{
			_component.Bottom = value;
			return this;
		}
	}
}