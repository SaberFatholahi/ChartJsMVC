using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Chart.Js.MVC.Helpers;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ComponentRenderer.
	/// </summary>
	/// <typeparam name="TComponent">The type of the t component.</typeparam>
	/// <seealso cref="System.Web.IHtmlString" />
	public abstract class ComponentRenderer<TComponent> : IHtmlString where TComponent : Component
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ComponentRenderer{TComponent}"/> class.
		/// </summary>
		protected ComponentRenderer()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ComponentRenderer{TComponent}"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		protected ComponentRenderer(TComponent component)
		{
			Component = component;
		}

		/// <summary>
		/// Gets or sets the component.
		/// </summary>
		/// <value>The component.</value>
		protected internal TComponent Component
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the HTML helper.
		/// </summary>
		/// <value>The HTML helper.</value>
		protected internal HtmlHelper HtmlHelper
		{
			get;
			internal set;
		}

		/// <summary>
		/// Gets the view context.
		/// </summary>
		/// <value>The view context.</value>
		protected internal ViewContext ViewContext
		{
			get;
			internal set;
		}
		/// <summary>
		/// Gets the view data.
		/// </summary>
		/// <value>The view data.</value>
		protected internal ViewDataDictionary ViewData
		{
			get;
			internal set;
		}
		/// <summary>
		/// Verifies the state.
		/// </summary>
		/// <exception cref="System.ArgumentNullException">Component</exception>
		/// <exception cref="System.Exception">A component must have a unique 'Name'. Please provide a name.</exception>
		public virtual void VerifyState()
		{
			if (Component == null)
				throw new ArgumentNullException(nameof(Component));

			if (Component.NameIsRequired && !Component.Id.HasValue())
			{
				throw new Exception("A component must have a unique 'Name'. Please provide a name.");
			}
		}
		/// <summary>
		/// Writes the HTML.
		/// </summary>
		/// <param name="writer">The writer.</param>
		protected void WriteHtml(HtmlTextWriter writer)
		{
			VerifyState();
			Component.Id = SanitizeId(Component.Id);

			WriteHtmlCore(writer);
		}
		/// <summary>
		/// Writes the HTML core.
		/// </summary>
		/// <param name="writer">The writer.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		protected virtual void WriteHtmlCore(HtmlTextWriter writer)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Renders this instance.
		/// </summary>
		public virtual void Render()
		{
			using (var htmlTextWriter = new HtmlTextWriter(ViewContext.Writer))
			{
				WriteHtml(htmlTextWriter);
			}
		}
		/// <summary>
		/// Returns an HTML-encoded string.
		/// </summary>
		/// <returns>An HTML-encoded string.</returns>
		public virtual string ToHtmlString()
		{
			string str;
			using (var stringWriter = new StringWriter())
			{
				using (var htmlWriter = new HtmlTextWriter(stringWriter))
				{
					WriteHtml(htmlWriter);
					str = stringWriter.ToString();
				}
			}
			return str;
		}
		/// <summary>
		/// Sanitizes the identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>System.String.</returns>
		protected string SanitizeId(string id)
		{
			return id.SanitizeHtmlId();
		}
	}
}
