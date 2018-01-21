// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="AnimationBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class AnimationBuilder.
	/// </summary>
	public class AnimationBuilder
	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly Animation _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="AnimationBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public AnimationBuilder(Animation component)
		{
			_component = component;
		}

		/// <summary>
		/// Durations the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>AnimationBuilder.</returns>
		public AnimationBuilder Duration(int value)
		{
			_component.Duration = value;
			return this;
		}

		/// <summary>
		/// Easings the animation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>AnimationBuilder.</returns>
		public AnimationBuilder EasingAnimation(EasingAnimation value)
		{
			_component.EasingAnimation = value;
			return this;
		}

		/// <summary>
		/// Called when [progress].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>AnimationBuilder.</returns>
		public AnimationBuilder OnProgress(Func<object, HelperResult> value)
		{
			_component.OnProgress = value;
			return this;
		}

		/// <summary>
		/// Called when [complete].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>AnimationBuilder.</returns>
		public AnimationBuilder OnComplete(Func<object, HelperResult> value)
		{
			_component.OnComplete = value;
			return this;
		}
	}
}