// ***********************************************************************
// Assembly         : Chart.Js.MVC.Component
// Author           : saber.fathollahi
// Created          : 11-01-1396
//
// Last Modified By : saber.fathollahi
// Last Modified On : 11-01-1396
// ***********************************************************************
// <copyright file="EasingAnimation.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chart.Js.MVC.Component
{
	/// <summary>
	/// Enum EasingAnimation
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EasingAnimation
	{

		/// <summary>
		/// The linear
		/// </summary>
		[EnumMember(Value = "linear")]
		Linear,
		/// <summary>
		/// The ease in quad
		/// </summary>
		[EnumMember(Value = "easeInQuad")]
		EaseInQuad,
		/// <summary>
		/// The ease out quad
		/// </summary>
		[EnumMember(Value = "easeOutQuad")]
		EaseOutQuad,
		/// <summary>
		/// The ease in out quad
		/// </summary>
		[EnumMember(Value = "easeInOutQuad")]
		EaseInOutQuad,
		/// <summary>
		/// The ease in cubic
		/// </summary>
		[EnumMember(Value = "easeInCubic")]
		EaseInCubic,
		/// <summary>
		/// The ease out cubic
		/// </summary>
		[EnumMember(Value = "easeOutCubic")]
		EaseOutCubic,
		/// <summary>
		/// The ease in out cubic
		/// </summary>
		[EnumMember(Value = "easeInOutCubic")]
		EaseInOutCubic,
		/// <summary>
		/// The ease in quart
		/// </summary>
		[EnumMember(Value = "easeInQuart")]
		EaseInQuart,
		/// <summary>
		/// The ease out quart
		/// </summary>
		[EnumMember(Value = "easeOutQuart")]
		EaseOutQuart,
		/// <summary>
		/// The ease in out quart
		/// </summary>
		[EnumMember(Value = "easeInOutQuart")]
		EaseInOutQuart,
		/// <summary>
		/// The ease in quint
		/// </summary>
		[EnumMember(Value = "easeInQuint")]
		EaseInQuint,
		/// <summary>
		/// The ease out quint
		/// </summary>
		[EnumMember(Value = "easeOutQuint")]
		EaseOutQuint,
		/// <summary>
		/// The ease in out quint
		/// </summary>
		[EnumMember(Value = "easeInOutQuint")]
		EaseInOutQuint,
		/// <summary>
		/// The ease in sine
		/// </summary>
		[EnumMember(Value = "easeInSine")]
		EaseInSine,
		/// <summary>
		/// The ease out sine
		/// </summary>
		[EnumMember(Value = "easeOutSine")]
		EaseOutSine,
		/// <summary>
		/// The ease in out sine
		/// </summary>
		[EnumMember(Value = "easeInOutSine")]
		EaseInOutSine,
		/// <summary>
		/// The ease in expo
		/// </summary>
		[EnumMember(Value = "easeInExpo")]
		EaseInExpo,
		/// <summary>
		/// The ease out expo
		/// </summary>
		[EnumMember(Value = "easeOutExpo")]
		EaseOutExpo,
		/// <summary>
		/// The ease in out expo
		/// </summary>
		[EnumMember(Value = "easeInOutExpo")]
		EaseInOutExpo,
		/// <summary>
		/// The ease in circ
		/// </summary>
		[EnumMember(Value = "easeInCirc")]
		EaseInCirc,
		/// <summary>
		/// The ease out circ
		/// </summary>
		[EnumMember(Value = "easeOutCirc")]
		EaseOutCirc,
		/// <summary>
		/// The ease in out circ
		/// </summary>
		[EnumMember(Value = "easeInOutCirc")]
		EaseInOutCirc,
		/// <summary>
		/// The ease in elastic
		/// </summary>
		[EnumMember(Value = "easeInElastic")]
		EaseInElastic,
		/// <summary>
		/// The ease out elastic
		/// </summary>
		[EnumMember(Value = "easeOutElastic")]
		EaseOutElastic,
		/// <summary>
		/// The ease in out elastic
		/// </summary>
		[EnumMember(Value = "easeInOutElastic")]
		EaseInOutElastic,
		/// <summary>
		/// The ease in back
		/// </summary>
		[EnumMember(Value = "easeInBack")]
		EaseInBack,
		/// <summary>
		/// The ease out back
		/// </summary>
		[EnumMember(Value = "easeOutBack")]
		EaseOutBack,
		/// <summary>
		/// The ease in out back
		/// </summary>
		[EnumMember(Value = "easeInOutBack")]
		EaseInOutBack,
		/// <summary>
		/// The ease in bounce
		/// </summary>
		[EnumMember(Value = "easeInBounce")]
		EaseInBounce,
		/// <summary>
		/// The ease out bounce
		/// </summary>
		[EnumMember(Value = "easeOutBounce")]
		EaseOutBounce,
		/// <summary>
		/// The ease in out bounce
		/// </summary>
		[EnumMember(Value = "easeInOutBounce")]
		EaseInOutBounce,
	}
}