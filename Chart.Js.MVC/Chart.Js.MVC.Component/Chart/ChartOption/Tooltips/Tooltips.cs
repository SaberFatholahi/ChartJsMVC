// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="Tooltips.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web.WebPages;
using Chart.Js.MVC.Helpers;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Class Tooltips.
	/// </summary>
	public class Tooltips
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Tooltips"/> is enabled.
		/// </summary>
		/// <value><c>null</c> if [enabled] contains no value, <c>true</c> if [enabled]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "enabled")]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Gets or sets the mode.
		/// </summary>
		/// <value>The mode.</value>
		[JsonProperty(PropertyName = "mode")]
		public InteractionModes? Mode { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Tooltips"/> is intersect.
		/// </summary>
		/// <value><c>null</c> if [intersect] contains no value, <c>true</c> if [intersect]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "intersect")]
		public bool? Intersect { get; set; }

		/// <summary>
		/// Gets or sets the position.
		/// </summary>
		/// <value>The position.</value>
		[JsonProperty(PropertyName = "position")]
		public PositionModes? Position { get; set; }

		/// <summary>
		/// Gets or sets the color of the background.
		/// </summary>
		/// <value>The color of the background.</value>
		[JsonProperty(PropertyName = "backgroundColor")]
		public string BackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the title font family.
		/// </summary>
		/// <value>The title font family.</value>
		[JsonProperty(PropertyName = "titleFontFamily")]
		public string TitleFontFamily { get; set; }

		/// <summary>
		/// Gets or sets the size of the title font.
		/// </summary>
		/// <value>The size of the title font.</value>
		[JsonProperty(PropertyName = "titleFontSize")]
		public int? TitleFontSize { get; set; }

		/// <summary>
		/// Gets or sets the title font style.
		/// </summary>
		/// <value>The title font style.</value>
		[JsonProperty(PropertyName = "titleFontStyle")]
		public FontStyle? TitleFontStyle { get; set; }

		/// <summary>
		/// Gets or sets the color of the title font.
		/// </summary>
		/// <value>The color of the title font.</value>
		[JsonProperty(PropertyName = "titleFontColor")]
		public string TitleFontColor { get; set; }

		/// <summary>
		/// Gets or sets the title spacing.
		/// </summary>
		/// <value>The title spacing.</value>
		[JsonProperty(PropertyName = "titleSpacing")]
		public int? TitleSpacing { get; set; }

		/// <summary>
		/// Gets or sets the title margin bottom.
		/// </summary>
		/// <value>The title margin bottom.</value>
		[JsonProperty(PropertyName = "titleMarginBottom")]
		public int? TitleMarginBottom { get; set; }

		/// <summary>
		/// Gets or sets the body font family.
		/// </summary>
		/// <value>The body font family.</value>
		[JsonProperty(PropertyName = "bodyFontFamily")]
		public string BodyFontFamily { get; set; }

		/// <summary>
		/// Gets or sets the size of the body font.
		/// </summary>
		/// <value>The size of the body font.</value>
		[JsonProperty(PropertyName = "bodyFontSize")]
		public int? BodyFontSize { get; set; }

		/// <summary>
		/// Gets or sets the body font style.
		/// </summary>
		/// <value>The body font style.</value>
		[JsonProperty(PropertyName = "bodyFontStyle")]
		public FontStyle? BodyFontStyle { get; set; }

		/// <summary>
		/// Gets or sets the color of the body font.
		/// </summary>
		/// <value>The color of the body font.</value>
		[JsonProperty(PropertyName = "bodyFontColor")]
		public string BodyFontColor { get; set; }

		/// <summary>
		/// Gets or sets the body spacing.
		/// </summary>
		/// <value>The body spacing.</value>
		[JsonProperty(PropertyName = "bodySpacing")]
		public int? BodySpacing { get; set; }

		/// <summary>
		/// Gets or sets the footer font family.
		/// </summary>
		/// <value>The footer font family.</value>
		[JsonProperty(PropertyName = "footerFontFamily")]
		public string FooterFontFamily { get; set; }

		/// <summary>
		/// Gets or sets the size of the footer font.
		/// </summary>
		/// <value>The size of the footer font.</value>
		[JsonProperty(PropertyName = "footerFontSize")]
		public int? FooterFontSize { get; set; }

		/// <summary>
		/// Gets or sets the footer font style.
		/// </summary>
		/// <value>The footer font style.</value>
		[JsonProperty(PropertyName = "footerFontStyle")]
		public FontStyle? FooterFontStyle { get; set; }

		/// <summary>
		/// Gets or sets the color of the footer font.
		/// </summary>
		/// <value>The color of the footer font.</value>
		[JsonProperty(PropertyName = "footerFontColor")]
		public string FooterFontColor { get; set; }

		/// <summary>
		/// Gets or sets the footer spacing.
		/// </summary>
		/// <value>The footer spacing.</value>
		[JsonProperty(PropertyName = "footerSpacing")]
		public int? FooterSpacing { get; set; }

		/// <summary>
		/// Gets or sets the footer margin top.
		/// </summary>
		/// <value>The footer margin top.</value>
		[JsonProperty(PropertyName = "footerMarginTop")]
		public int? FooterMarginTop { get; set; }

		/// <summary>
		/// Gets or sets the x padding.
		/// </summary>
		/// <value>The x padding.</value>
		[JsonProperty(PropertyName = "xPadding")]
		public int? XPadding { get; set; }

		/// <summary>
		/// Gets or sets the y padding.
		/// </summary>
		/// <value>The y padding.</value>
		[JsonProperty(PropertyName = "yPadding")]
		public int? YPadding { get; set; }

		/// <summary>
		/// Gets or sets the caret padding.
		/// </summary>
		/// <value>The caret padding.</value>
		[JsonProperty(PropertyName = "caretPadding")]
		public int? CaretPadding { get; set; }

		/// <summary>
		/// Gets or sets the size of the caret.
		/// </summary>
		/// <value>The size of the caret.</value>
		[JsonProperty(PropertyName = "caretSize")]
		public int? CaretSize { get; set; }

		/// <summary>
		/// Gets or sets the corner radius.
		/// </summary>
		/// <value>The corner radius.</value>
		[JsonProperty(PropertyName = "cornerRadius")]
		public int? CornerRadius { get; set; }

		/// <summary>
		/// Gets or sets the multi key background.
		/// </summary>
		/// <value>The multi key background.</value>
		[JsonProperty(PropertyName = "multiKeyBackground")]
		public string MultiKeyBackground { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [display colors].
		/// </summary>
		/// <value><c>null</c> if [display colors] contains no value, <c>true</c> if [display colors]; otherwise, <c>false</c>.</value>
		[JsonProperty(PropertyName = "displayColors")]
		public bool? DisplayColors { get; set; }

		/// <summary>
		/// Gets or sets the color of the border.
		/// </summary>
		/// <value>The color of the border.</value>
		[JsonProperty(PropertyName = "borderColor")]
		public string BorderColor { get; set; }

		/// <summary>
		/// Gets or sets the width of the border.
		/// </summary>
		/// <value>The width of the border.</value>
		[JsonProperty(PropertyName = "borderWidth")]
		public int? BorderWidth { get; set; }

		/// <summary>
		/// Gets or sets the callbacks.
		/// </summary>
		/// <value>The callbacks.</value>
		[JsonProperty(PropertyName = "callbacks")]
		public Callbacks Callbacks { get; set; }

		/// <summary>
		/// Gets or sets the on item sort.
		/// </summary>
		/// <value>The on item sort.</value>
		[JsonProperty(PropertyName = "itemSort")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnItemSort { get; set; }

		/// <summary>
		/// Gets or sets the on filter.
		/// </summary>
		/// <value>The on filter.</value>
		[JsonProperty(PropertyName = "filter")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> OnFilter { get; set; }

		/// <summary>
		/// Gets or sets the custom.
		/// </summary>
		/// <value>The custom.</value>
		[JsonProperty(PropertyName = "custom")]
		[JsonConverter(typeof(FunctionConverter))]
		public Func<object, HelperResult> Custom { get; set; }
	}
}