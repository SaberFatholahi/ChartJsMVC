// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="HtmlHelperExtensions.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Mvc;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class HtmlHelperExtensions.
	/// </summary>
	public static class HtmlHelperExtensions
	{
		/// <summary>
		/// Components the specified helper.
		/// </summary>
		/// <param name="helper">The helper.</param>
		/// <returns>ComponentFactory.</returns>
		public static ComponentFactory Component(this HtmlHelper helper)
		{
			return new ComponentFactory(helper);
		}
	}
}
