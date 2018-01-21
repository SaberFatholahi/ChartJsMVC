using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	public abstract class Dataset
	{
		[JsonProperty(PropertyName = "label")]
		public dynamic Label { get; set; }

		[JsonProperty(PropertyName = "backgroundColor")]
		public dynamic BackgroundColor { get; set; }

		[JsonProperty(PropertyName = "borderColor")]
		public dynamic BorderColor { get; set; }

		[JsonProperty(PropertyName = "borderWidth")]
		public dynamic BorderWidth { get; set; }

		[JsonProperty(PropertyName = "pointHoverBackgroundColor")]
		public virtual dynamic HoverBackgroundColor { get; set; }

		[JsonProperty(PropertyName = "pointHoverBorderColor")]
		public virtual dynamic HoverBorderColor { get; set; }

		[JsonProperty(PropertyName = "pointHoverBorderWidth")]
		public virtual dynamic HoverBorderWidth { get; set; }

		[JsonProperty(PropertyName = "data")]
		public dynamic Data { get; set; }

		[JsonProperty(PropertyName = "type")]
		public ChartType? ChartType { get; set; }
	}
}
