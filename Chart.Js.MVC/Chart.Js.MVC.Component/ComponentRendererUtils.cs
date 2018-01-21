// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ComponentRendererUtils.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Chart.Js.MVC.Helpers;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ComponentRendererUtils.
	/// </summary>
	public static class ComponentRendererUtils
    {
		/// <summary>
		/// The component size
		/// </summary>
		public static Dictionary<ComponentSize, string> ComponentSize = new Dictionary<ComponentSize, string>
	    {
		    {Chart.Js.MVC.Component.ComponentSize.ExtraSmall, "xs"},
		    {Chart.Js.MVC.Component.ComponentSize.Small, "sm"},
		    {Chart.Js.MVC.Component.ComponentSize.Medium, "md"},
		    {Chart.Js.MVC.Component.ComponentSize.Larg, "lg"}
	    };

		/// <summary>
		/// The component states
		/// </summary>
		public static Dictionary<ComponentState, string> ComponentStates = new Dictionary<ComponentState, string>
	    {
		    {ComponentState.Default, "default"},
		    {ComponentState.Danger, "danger"},
		    {ComponentState.Info, "info"},
		    {ComponentState.Primary, "primary"},
		    {ComponentState.Success, "success"},
		    {ComponentState.Warning, "warning"}
	    };

		/// <summary>
		/// Appends the CSS class.
		/// </summary>
		/// <param name="attributes">The attributes.</param>
		/// <param name="class">The class.</param>
		public static void AppendCssClass(this IDictionary<string, object> attributes, string @class)
        {
            attributes.AppendInValue("class", " ", @class);
        }

		/// <summary>
		/// Prepends the CSS class.
		/// </summary>
		/// <param name="attributes">The attributes.</param>
		/// <param name="class">The class.</param>
		public static void PrependCssClass(this IDictionary<string, object> attributes, string @class)
        {
            attributes.PrependInValue("class", " ", @class);
        }
	}

}
