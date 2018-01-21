using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chart.Js.MVC.Component
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartType
	{
		[EnumMember(Value = "line")]
		Line,
		[EnumMember(Value = "bar")]
		Bar,
		[EnumMember(Value = "horizontalBar")]
		HorizontalBar,
		[EnumMember(Value = "pie")]
		Pie,
		[EnumMember(Value = "doughnut")]
		Doughnut,
		[EnumMember(Value = "radar")]
		Radar,
		[EnumMember(Value = "polarArea")]
		Polar,
		[EnumMember(Value = "bubble")]
		Bubble
	}
}