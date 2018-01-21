// ***********************************************************************
// Assembly         : Chart.Js.MVC.Helpers
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Extentions.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;
using Chart.Js.MVC.Helpers.ComponentModel;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Helpers
{
	/// <summary>
	/// Class Extentions.
	/// </summary>
	public static class Extentions
	{
		/// <summary>
		/// Adds the attributes.
		/// </summary>
		/// <param name="writer">The writer.</param>
		/// <param name="attributes">The attributes.</param>
		public static void AddAttributes(this HtmlTextWriter writer, IDictionary<string, object> attributes)
		{
			if (attributes.Any())
			{
				foreach (var pair in attributes)
				{
					if (pair.Value != null)
						writer.AddAttribute(pair.Key, pair.Value.ToString(), true);
				}
			}
		}
		/// <summary>
		/// Determines whether [is null or empty] [the specified s].
		/// </summary>
		/// <param name="s">The s.</param>
		/// <returns><c>true</c> if [is null or empty] [the specified s]; otherwise, <c>false</c>.</returns>
		[DebuggerStepThrough]
		public static bool IsNullOrEmpty(this string s)
		{
			return string.IsNullOrEmpty(s) && string.IsNullOrWhiteSpace(s);
		}
		/// <summary>
		/// Scripts the specified template.
		/// </summary>
		/// <param name="htmlHelper">The HTML helper.</param>
		/// <param name="template">The template.</param>
		/// <returns>MvcHtmlString.</returns>
		public static MvcHtmlString Script(this HtmlHelper htmlHelper, Func<object, HelperResult> template)
		{
			htmlHelper.ViewContext.HttpContext.Items["_script_" + Guid.NewGuid()] = template;
			return MvcHtmlString.Empty;
		}

		/// <summary>
		/// Renders the scripts.
		/// </summary>
		/// <param name="htmlHelper">The HTML helper.</param>
		/// <returns>IHtmlString.</returns>
		public static IHtmlString RenderScripts(this HtmlHelper htmlHelper)
		{
			foreach (object key in htmlHelper.ViewContext.HttpContext.Items.Keys)
			{
				if (key.ToString().StartsWith("_script_"))
				{
					var template = htmlHelper.ViewContext.HttpContext.Items[key] as Func<object, HelperResult>;
					if (template != null)
					{
						htmlHelper.ViewContext.Writer.Write(template(null));
					}
				}
			}
			return MvcHtmlString.Empty;
		}

		/// <summary>
		/// Appends the in value.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="key">The key.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="value">The value.</param>
		public static void AppendInValue(this IDictionary<string, object> instance, string key, string separator, object value)
		{
			instance[key] = !instance.ContainsKey(key) ? value.ToString() : (instance[key] + separator + value);
		}

		/// <summary>
		/// Prepends the in value.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="key">The key.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="value">The value.</param>
		public static void PrependInValue(this IDictionary<string, object> instance, string key, string separator, object value)
		{
			instance[key] = !instance.ContainsKey(key) ? value.ToString() : (value + separator + instance[key]);
		}

		/// <summary>
		/// Determines whether the specified value has value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
		[DebuggerStepThrough]
		public static bool HasValue(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		/// <summary>
		/// Sanitizes the HTML identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>System.String.</returns>
		public static string SanitizeHtmlId(this string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			var builder = new StringBuilder(value.Length);
			var index = value.IndexOf("#", StringComparison.Ordinal);
			var num2 = value.LastIndexOf("#", StringComparison.Ordinal);
			if (num2 > index)
			{
				ReplaceInvalidHtmlIdCharacters(value.Substring(0, index), builder);
				builder.Append(value.Substring(index, (num2 - index) + 1));
				ReplaceInvalidHtmlIdCharacters(value.Substring(num2 + 1), builder);
			}
			else
			{
				ReplaceInvalidHtmlIdCharacters(value, builder);
			}
			return builder.ToString();
		}

		/// <summary>
		/// Replaces the invalid HTML identifier characters.
		/// </summary>
		/// <param name="part">The part.</param>
		/// <param name="builder">The builder.</param>
		private static void ReplaceInvalidHtmlIdCharacters(string part, StringBuilder builder)
		{
			foreach (var c in part)
			{
				builder.Append(IsValidHtmlIdCharacter(c) ? c : '_');
			}
		}

		/// <summary>
		/// Determines whether [is valid HTML identifier character] [the specified c].
		/// </summary>
		/// <param name="c">The c.</param>
		/// <returns><c>true</c> if [is valid HTML identifier character] [the specified c]; otherwise, <c>false</c>.</returns>
		private static bool IsValidHtmlIdCharacter(char c)
		{
			var invalid = (c == '?' || c == '!' || c == '#' || c == '.' || c == ' ' || c == ';' || c == ':');
			return !invalid;
		}
		/// <summary>
		/// Objects to dictionary.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
		/// <exception cref="System.ArgumentNullException">obj</exception>
		public static IDictionary<string, object> ObjectToDictionary(object obj)
		{
			if (obj == null) throw new ArgumentNullException(nameof(obj));

			return FastProperty.ObjectToDictionary(
				obj,
				key => key.Replace("_", "-"));
		}
		/// <summary>
		/// Extracts the property information.
		/// </summary>
		/// <param name="propertyAccessor">The property accessor.</param>
		/// <returns>PropertyInfo.</returns>
		public static PropertyInfo ExtractPropertyInfo(this LambdaExpression propertyAccessor)
		{
			return propertyAccessor.ExtractMemberInfo() as PropertyInfo;
		}

		/// <summary>
		/// Formats a string to an invariant culture
		/// </summary>
		/// <param name="format">The format.</param>
		/// <param name="objects">The objects.</param>
		/// <returns>System.String.</returns>
		[DebuggerStepThrough]
		public static string FormatInvariant(this string format, params object[] objects)
		{
			return string.Format(CultureInfo.InvariantCulture, format, objects);
		}
		/// <summary>
		/// Extracts the member information.
		/// </summary>
		/// <param name="propertyAccessor">The property accessor.</param>
		/// <returns>MemberInfo.</returns>
		/// <exception cref="System.ArgumentNullException">propertyAccessor</exception>
		/// <exception cref="System.ArgumentException">The property or field accessor expression is not in the expected format 'o =&gt; o.PropertyOrField'.</exception>
		[SuppressMessage("ReSharper", "CanBeReplacedWithTryCastAndCheckForNull")]
		public static MemberInfo ExtractMemberInfo(this LambdaExpression propertyAccessor)
		{
			if (propertyAccessor == null)
				throw new ArgumentNullException(nameof(propertyAccessor));

			MemberInfo info;
			try
			{
				MemberExpression operand;
				// o => o.PropertyOrField
				LambdaExpression expression = propertyAccessor;

				if (expression.Body is UnaryExpression)
				{
					// If the property is not an Object, then the member access expression will be wrapped in a conversion expression
					// (object)o.PropertyOrField
					UnaryExpression body = (UnaryExpression)expression.Body;
					// o.PropertyOrField
					operand = (MemberExpression)body.Operand;
				}
				else
				{
					// o.PropertyOrField
					operand = (MemberExpression)expression.Body;
				}

				// Member
				MemberInfo member = operand.Member;
				info = member;
			}
			catch (Exception e)
			{
				throw new ArgumentException("The property or field accessor expression is not in the expected format 'o => o.PropertyOrField'.", e);
			}

			return info;
		}

		/// <summary>
		/// Determines whether [is sub class] [the specified check].
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="check">The check.</param>
		/// <returns><c>true</c> if [is sub class] [the specified check]; otherwise, <c>false</c>.</returns>
		public static bool IsSubClass(this Type type, Type check)
		{
			Type implementingType;
			return IsSubClass(type, check, out implementingType);
		}

		/// <summary>
		/// Determines whether [is sub class] [the specified check].
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="check">The check.</param>
		/// <param name="implementingType">Type of the implementing.</param>
		/// <returns><c>true</c> if [is sub class] [the specified check]; otherwise, <c>false</c>.</returns>
		/// <exception cref="System.ArgumentNullException">
		/// type
		/// or
		/// check
		/// </exception>
		public static bool IsSubClass(this Type type, Type check, out Type implementingType)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));
			if (check == null)
				throw new ArgumentNullException(nameof(check));

			return IsSubClassInternal(type, type, check, out implementingType);
		}

		/// <summary>
		/// Determines whether [is sub class internal] [the specified initial type].
		/// </summary>
		/// <param name="initialType">The initial type.</param>
		/// <param name="currentType">Type of the current.</param>
		/// <param name="check">The check.</param>
		/// <param name="implementingType">Type of the implementing.</param>
		/// <returns><c>true</c> if [is sub class internal] [the specified initial type]; otherwise, <c>false</c>.</returns>
		private static bool IsSubClassInternal(Type initialType, Type currentType, Type check, out Type implementingType)
		{
			if (currentType == check)
			{
				implementingType = currentType;
				return true;
			}

			// don't get interfaces for an interface unless the initial type is an interface
			if (check.IsInterface && (initialType.IsInterface || currentType == initialType))
			{
				foreach (Type t in currentType.GetInterfaces())
				{
					if (IsSubClassInternal(initialType, t, check, out implementingType))
					{
						// don't return the interface itself, return it's implementor
						if (check == implementingType)
							implementingType = currentType;

						return true;
					}
				}
			}

			if (currentType.IsGenericType && !currentType.IsGenericTypeDefinition)
			{
				if (IsSubClassInternal(initialType, currentType.GetGenericTypeDefinition(), check, out implementingType))
				{
					implementingType = currentType;
					return true;
				}
			}

			if (currentType.BaseType == null)
			{
				implementingType = null;
				return false;
			}

			return IsSubClassInternal(initialType, currentType.BaseType, check, out implementingType);
		}

		/// <summary>
		/// Adds the range.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="values">The values.</param>
		/// <param name="other">The other.</param>
		/// <exception cref="System.ArgumentException">An item with the same key has already been added.</exception>
		public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> values, IEnumerable<KeyValuePair<TKey, TValue>> other)
		{
			foreach (var kvp in other)
			{
				if (values.ContainsKey(kvp.Key))
				{
					throw new ArgumentException("An item with the same key has already been added.");
				}
				values.Add(kvp);
			}
		}

		/// <summary>
		/// Merges the specified key.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <param name="replaceExisting">if set to <c>true</c> [replace existing].</param>
		public static void Merge(this IDictionary<string, object> instance, string key, object value, bool replaceExisting = true)
		{
			if (replaceExisting || !instance.ContainsKey(key))
			{
				instance[key] = value;
			}
		}

		/// <summary>
		/// Merges the specified values.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="values">The values.</param>
		/// <param name="replaceExisting">if set to <c>true</c> [replace existing].</param>
		public static void Merge(this IDictionary<string, object> instance, object values, bool replaceExisting = true)
		{
			instance.Merge(ObjectToDictionary(values), replaceExisting);
		}

		/// <summary>
		/// Merges the specified from.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="instance">The instance.</param>
		/// <param name="from">From.</param>
		/// <param name="replaceExisting">if set to <c>true</c> [replace existing].</param>
		public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> instance, IDictionary<TKey, TValue> from, bool replaceExisting = true)
		{
			foreach (var kvp in from)
			{
				if (replaceExisting || !instance.ContainsKey(kvp.Key))
				{
					instance[kvp.Key] = kvp.Value;
				}
			}
		}

		/// <summary>
		/// Converts to json.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="ignoreNullValue">if set to <c>true</c> [ignore null value].</param>
		/// <returns>System.String.</returns>
		public static string ConvertToJson(this object obj, bool ignoreNullValue = true)
		{
			if (obj == null)
				return "[]";

			var serializer = new JsonSerializer();
			//serializer.Converters.Add();
			if (ignoreNullValue)
				serializer.NullValueHandling = NullValueHandling.Ignore;

			using (var stringWriter = new StringWriter())
			{
				using (var writer = new JsonTextWriter(stringWriter))
				{
					writer.QuoteName = false;
					serializer.Serialize(writer, obj);
				}
				var json = stringWriter.ToString();
				return json;
			}
		}
	}
}
