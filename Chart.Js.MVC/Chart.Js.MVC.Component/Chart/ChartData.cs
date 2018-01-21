using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chart.Js.MVC.Component
{
	public class ChartData<T>
	{
		[JsonProperty(PropertyName = "labels")]
		public List<string> Labels { get; } = new List<string>();

		[JsonProperty(PropertyName = "datasets")]
		public List<T> Datasets { get; } = new List<T>();
	}
}