using System;
using System.Web.WebPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chart.Js.MVC.Helpers
{
	public class FunctionConverter : CustomCreationConverter<Func<object, HelperResult>>
	{
		public override bool CanWrite => true;
		public override bool CanRead => false;
		public override Func<object, HelperResult> Create(Type objectType)
		{
			return null;
		}
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var function = value as Func<object, HelperResult>;
			if (function == null)
				return;

			var str = function(null).ToHtmlString().Replace("<script>", "").Replace("</script>","").Replace("<text>", "").Replace("</text>", "");
			writer.WriteRawValue(str);
		}
	}
}