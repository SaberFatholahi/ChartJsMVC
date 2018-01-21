// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ChartOptionsBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ChartOptionsBuilder.
	/// </summary>
	public class ChartOptionsBuilder

	{
		/// <summary>
		/// The component
		/// </summary>
		private readonly ChartOptions _component;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChartOptionsBuilder"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		public ChartOptionsBuilder(ChartOptions component)
		{
			_component = component;
		}

		/// <summary>
		/// Responsives the specified value.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Responsive(bool value)
		{
			_component.Responsive = value;
			return this;
		}

		/// <summary>
		/// Responsives the duration of the animation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder ResponsiveAnimationDuration(int value)
		{
			_component.ResponsiveAnimationDuration = value;
			return this;
		}

		/// <summary>
		/// Called when [resize].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder OnResize(Func<object, HelperResult> value)
		{
			_component.OnResize = value;
			return this;
		}

		/// <summary>
		/// Called when [hover].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder OnHover(Func<object, HelperResult> value)
		{
			_component.OnHover = value;
			return this;
		}

		/// <summary>
		/// Called when [legend callback].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder OnLegendCallback(Func<object, HelperResult> value)
		{
			_component.OnLegendCallback = value;
			return this;
		}

		/// <summary>
		/// Called when [click].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder OnClick(Func<object, HelperResult> value)
		{
			_component.OnClick = value;
			return this;
		}

		/// <summary>
		/// Maintains the aspect ratio.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder MaintainAspectRatio(bool value)
		{
			_component.MaintainAspectRatio = value;
			return this;
		}

		/// <summary>
		/// Legends the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Legend(Action<LegendBuilder> action)
		{
			_component.Legend = _component.Legend ?? new Legend();
			var factory = new LegendBuilder(_component.Legend);
			action(factory);
			return this;
		}

		/// <summary>
		/// Tooltipses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Tooltips(Action<TooltipsBuilder> action)
		{
			_component.Tooltips = _component.Tooltips ?? new Tooltips();
			var factory = new TooltipsBuilder(_component.Tooltips);
			action(factory);
			return this;
		}

		/// <summary>
		/// Animations the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Animation(Action<AnimationBuilder> action)
		{
			_component.Animation = _component.Animation ?? new Animation();
			var factory = new AnimationBuilder(_component.Animation);
			action(factory);
			return this;
		}

		/// <summary>
		/// Layouts the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Layout(Action<LayoutBuilder> action)
		{
			_component.Layout = _component.Layout ?? new Layout();
			var factory = new LayoutBuilder(_component.Layout);
			action(factory);
			return this;
		}

		/// <summary>
		/// Titles the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Title(Action<TitleBuilder> action)
		{
			_component.Title = _component.Title ?? new Title();
			var factory = new TitleBuilder(_component.Title);
			action(factory);
			return this;
		}

		/// <summary>
		/// Scaleses the specified action.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>ChartOptionsBuilder.</returns>
		public ChartOptionsBuilder Scales(Action<ScalesBuilder> action)
		{
			_component.Scales = _component.Scales ?? new Scales();
			var factory = new ScalesBuilder(_component.Scales);
			action(factory);
			return this;
		}
	}
}