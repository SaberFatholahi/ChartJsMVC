// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="IHtmlAttributesContainer.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{

	/// <summary>
	/// Interface IHtmlAttributesContainer
	/// </summary>
	public interface IHtmlAttributesContainer
    {

		/// <summary>
		/// Gets the HTML attributes.
		/// </summary>
		/// <value>The HTML attributes.</value>
		IDictionary<string, object> HtmlAttributes
        {
            get;
        }

    }

}
