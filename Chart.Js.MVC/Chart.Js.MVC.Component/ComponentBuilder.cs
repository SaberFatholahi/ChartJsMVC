// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="ComponentBuilder.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Chart.Js.MVC.Helpers;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class ComponentBuilder.
	/// </summary>
	/// <typeparam name="TComponent">The type of the t component.</typeparam>
	/// <typeparam name="TBuilder">The type of the t builder.</typeparam>
	/// <seealso cref="System.Web.IHtmlString" />
	/// <seealso cref="Chart.Js.MVC.Component.IHideObjectMembers" />
	public abstract class ComponentBuilder<TComponent, TBuilder> : IHtmlString, IHideObjectMembers 
        where TComponent : Component
        where TBuilder : ComponentBuilder<TComponent, TBuilder>
    {
		/// <summary>
		/// The renderer
		/// </summary>
		private ComponentRenderer<TComponent> _renderer;

		/// <summary>
		/// Initializes a new instance of the <see cref="ComponentBuilder{TComponent, TBuilder}"/> class.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <param name="htmlHelper">The HTML helper.</param>
		protected ComponentBuilder(TComponent component, HtmlHelper htmlHelper)
        {
            Guard.NotNull(component, nameof(component));
            Guard.NotNull(htmlHelper, nameof(htmlHelper));
            
            Component = component;
            HtmlHelper = htmlHelper;
        }

		/// <summary>
		/// Gets the HTML helper.
		/// </summary>
		/// <value>The HTML helper.</value>
		protected internal HtmlHelper HtmlHelper
        {
            get;
        }

		/// <summary>
		/// Gets the component.
		/// </summary>
		/// <value>The component.</value>
		protected internal TComponent Component
        {
            get;
        }

		/// <summary>
		/// To the component.
		/// </summary>
		/// <returns>TComponent.</returns>
		public TComponent ToComponent()
        {
            return Component;
        }

		/// <summary>
		/// Gets the renderer.
		/// </summary>
		/// <value>The renderer.</value>
		protected ComponentRenderer<TComponent> Renderer
        {
            get
            {
                if (_renderer != null) return _renderer;
	            //todo use DI BEST PRACTICE (ComponentRenderer<TComponent>) DependencyResolver.Current.GetService(typeof(ComponentRenderer<TComponent>));

				_renderer = (ComponentRenderer<TComponent>)RendererFactory.ResolveRenderer(Component);
				EnrichRenderer(_renderer);
                return _renderer;
            }
            private set
            {
                _renderer = value;
                if (_renderer != null)
                {
                    EnrichRenderer(_renderer);
                }
            }
        }

		/// <summary>
		/// Enriches the renderer.
		/// </summary>
		/// <param name="renderer">The renderer.</param>
		private void EnrichRenderer(ComponentRenderer<TComponent> renderer)
        {
            renderer.Component = Component;
            renderer.HtmlHelper = HtmlHelper;
            renderer.ViewContext = HtmlHelper.ViewContext;
            renderer.ViewData = HtmlHelper.ViewData;
        }

		/// <summary>
		/// Withes the renderer.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder WithRenderer(ComponentRenderer<TComponent> instance)
		{
			Guard.NotNull(instance, nameof(instance));

			return WithRenderer<ComponentRenderer<TComponent>>(instance);
		}

		/// <summary>
		/// Withes the renderer.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="instance">The instance.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder WithRenderer<T>(ComponentRenderer<TComponent> instance) 
            where T : ComponentRenderer<TComponent>
        {
            Guard.NotNull(instance, nameof(instance));

			Renderer = instance;
			return this as TBuilder;
		}

		/// <summary>
		/// Withes the renderer.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>TBuilder.</returns>
		public TBuilder WithRenderer<T>()
			where T : ComponentRenderer<TComponent>
		{
			return WithRenderer(typeof(T));
		}

		/// <summary>
		/// Withes the renderer.
		/// </summary>
		/// <param name="rendererType">Type of the renderer.</param>
		/// <returns>TBuilder.</returns>
		public TBuilder WithRenderer(Type rendererType)
        {
            Guard.NotNull(rendererType, nameof(rendererType));
            Guard.Implements<ComponentRenderer<TComponent>>(rendererType);

            var renderer = Activator.CreateInstance(rendererType) as ComponentRenderer<TComponent>;
            if (renderer != null)
            {
                Renderer = renderer;
            }

            return this as TBuilder;
        }

		/// <summary>
		/// Names the specified name.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>TBuilder.</returns>
		public virtual TBuilder Name(string name)
        {
            Component.Name = name;
            return this as TBuilder;
        }

		/// <summary>
		/// Components the version.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TBuilder.</returns>
		public virtual TBuilder ComponentVersion(BootstrapVersion value)
		{
			Component.ComponentVersion = value;
			return this as TBuilder;
		}

		/// <summary>
		/// HTMLs the attributes.
		/// </summary>
		/// <param name="attributes">The attributes.</param>
		/// <returns>TBuilder.</returns>
		public virtual TBuilder HtmlAttributes(object attributes)
        {
            return HtmlAttributes(Extentions.ObjectToDictionary(attributes));
        }

		/// <summary>
		/// HTMLs the attributes.
		/// </summary>
		/// <param name="attributes">The attributes.</param>
		/// <returns>TBuilder.</returns>
		public virtual TBuilder HtmlAttributes(IDictionary<string, object> attributes)
        {
            Component.HtmlAttributes.Merge(attributes);
            return this as TBuilder;
        }

		/// <summary>
		/// Returns an HTML-encoded string.
		/// </summary>
		/// <returns>An HTML-encoded string.</returns>
		public string ToHtmlString()
        {
            return Renderer.ToHtmlString();
        }

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
        {
            return ToHtmlString();
        }

		/// <summary>
		/// Renders this instance.
		/// </summary>
		public virtual void Render()
        {
            Renderer.Render();
        }

		/// <summary>
		/// Performs an implicit conversion from <see cref="ComponentBuilder{TComponent, TBuilder}"/> to <see cref="TComponent"/>.
		/// </summary>
		/// <param name="builder">The builder.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator TComponent(ComponentBuilder<TComponent, TBuilder> builder)
        {
            return builder.ToComponent();
        }
    }
}
