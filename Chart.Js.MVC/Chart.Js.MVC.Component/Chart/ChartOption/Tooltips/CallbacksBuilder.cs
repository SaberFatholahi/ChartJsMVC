// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-04-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-04-1396
// ***********************************************************************
// <copyright file="CallbacksBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class CallbacksBuilder.
	/// </summary>
	public class CallbacksBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Callbacks _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="CallbacksBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public CallbacksBuilder(Callbacks component)
		{
			_component = component;
		}

		/// <summary>
		/// Befores the title.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder BeforeTitle(Func<object, HelperResult> value)
		{
			_component.BeforeTitle = value;
			return this;
		}
		/// <summary>
		/// Titles the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder Title(Func<object, HelperResult> value)
		{
			_component.Title = value;
			return this;
		}
		/// <summary>
		/// Afters the title.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder AfterTitle(Func<object, HelperResult> value)
		{
			_component.AfterTitle = value;
			return this;
		}
		/// <summary>
		/// Befores the body.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder BeforeBody(Func<object, HelperResult> value)
		{
			_component.BeforeBody = value;
			return this;
		}
		/// <summary>
		/// Befores the label.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder BeforeLabel(Func<object, HelperResult> value)
		{
			_component.BeforeLabel = value;
			return this;
		}
		/// <summary>
		/// Labels the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder Label(Func<object, HelperResult> value)
		{
			_component.Label = value;
			return this;
		}
		/// <summary>
		/// Labels the color.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder LabelColor(Func<object, HelperResult> value)
		{
			_component.LabelColor = value;
			return this;
		}
		/// <summary>
		/// Labels the color of the text.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder LabelTextColor(Func<object, HelperResult> value)
		{
			_component.LabelTextColor = value;
			return this;
		}
		/// <summary>
		/// Afters the label.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder AfterLabel(Func<object, HelperResult> value)
		{
			_component.AfterLabel = value;
			return this;
		}
		/// <summary>
		/// Afters the body.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder AfterBody(Func<object, HelperResult> value)
		{
			_component.AfterBody = value;
			return this;
		}
		/// <summary>
		/// Befores the footer.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder BeforeFooter(Func<object, HelperResult> value)
		{
			_component.BeforeFooter = value;
			return this;
		}
		/// <summary>
		/// Footers the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder Footer(Func<object, HelperResult> value)
		{
			_component.Footer = value;
			return this;
		}

		/// <summary>
		/// Afters the footer.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>CallbacksBuilder.</returns>
		public CallbacksBuilder AfterFooter(Func<object, HelperResult> value)
		{
			_component.AfterFooter = value;
			return this;
		}
	}
}