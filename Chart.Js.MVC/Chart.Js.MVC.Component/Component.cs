// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Component.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Web.Routing;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component 
{
	/// <summary>
	/// Class Component.
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.IUiComponent" />
	public abstract class Component : IUiComponent
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="Component"/> class.
		/// </summary>
		protected Component()
        {
            HtmlAttributes = new RouteValueDictionary();
			ComponentVersion = BootstrapVersion.V3;
        }

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[JsonIgnore]
        public string Id
        {
            get
            {
                return !HtmlAttributes.ContainsKey("id") ? Name : HtmlAttributes["id"] as string;
			}
            set
            {
                HtmlAttributes["id"] = value;
            }
        }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		[JsonIgnore]
		public string Name
        {
            get;
            set;
        }

		/// <summary>
		/// Gets the HTML attributes.
		/// </summary>
		/// <value>The HTML attributes.</value>
		[JsonIgnore]
		public IDictionary<string, object> HtmlAttributes 
        {
            get;
        }

		/// <summary>
		/// Gets a value indicating whether [name is required].
		/// </summary>
		/// <value><c>true</c> if [name is required]; otherwise, <c>false</c>.</value>
		[JsonIgnore]
		public virtual bool NameIsRequired => false;

		/// <summary>
		/// Gets or sets the component version.
		/// </summary>
		/// <value>The component version.</value>
		[JsonIgnore]
		public BootstrapVersion ComponentVersion
		{
			get;
			set;
		}
	}

}
