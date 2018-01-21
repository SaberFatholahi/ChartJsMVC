// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="IUiComponent.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Interface IUiComponent
	/// </summary>
	/// <seealso cref="Chart.Js.MVC.Component.IHtmlAttributesContainer" />
	public interface IUiComponent : IHtmlAttributesContainer
    {
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		string Id
        {
            get;
        }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		string Name
        {
            get;
        }

		/// <summary>
		/// Gets a value indicating whether [name is required].
		/// </summary>
		/// <value><c>true</c> if [name is required]; otherwise, <c>false</c>.</value>
		bool NameIsRequired
        {
            get;
        }
    }
}
