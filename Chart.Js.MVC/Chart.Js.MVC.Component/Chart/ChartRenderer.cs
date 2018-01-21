using System.Text;
using System.Web.UI;
using System.Web.WebPages;
using Chart.Js.MVC.Helpers;

namespace Chart.Js.MVC.Component
{
	public class ChartRenderer<TComponent> : ComponentRenderer<TComponent>
		where TComponent : ChartComponent
	{
		protected override void WriteHtmlCore(HtmlTextWriter writer)
		{
			var chart = Component;

			if (chart.HasHeader)
			{
				writer.Write($"<div class=\"box box-{ComponentRendererUtils.ComponentStates[chart.State]}\">");

				RenderHeader(writer);
			}

			RenderBody(writer);

			if (chart.HasHeader)
				writer.Write("</div>");

			RenderScripts(writer);
		}

		protected virtual void RenderScripts(HtmlTextWriter writer)
		{
			var chart = Component;

			var script = new StringBuilder();

			script.AppendLine("<script>");
			script.AppendLine(" $(document).ready(function(){");
			script.AppendLine($"var chart = new Chart($(\"#{chart.Id}\").get(0).getContext(\"2d\"), {chart.ConvertToJson()});");
			script.AppendLine("});");
			script.AppendLine("	</script>");

			if (chart.LoadAjax)
				writer.Write(script);
			else
			{
				HtmlHelper.Script(o => new HelperResult(w => w.Write(script)));
			}
		}

		protected virtual void RenderHeader(HtmlTextWriter writer)
		{
			var chart = Component;
			writer.Write("<div class=\"box-header with-border\">");

			if (!chart.Title.IsNullOrEmpty())
				writer.Write($"<h3 class=\"box-title\">{chart.Title}</h3>");

			RenderHeaderBoxTools(writer);

			writer.Write("</div>");
		}

		protected virtual void RenderHeaderBoxTools(HtmlTextWriter writer)
		{
			var chart = Component;
			if (!chart.HasCollapseButton && !chart.HasRemoveButton) return;

			writer.Write("<div class=\"box-tools pull-right\">");

			if (chart.HasCollapseButton)
				writer.Write($"<button class=\"btn btn-box-tool\" data-widget=\"collapse\"><i class=\"{chart.IconClass} {chart.IconClass}-minus\"></i></button>");
			if (chart.HasRemoveButton)
				writer.Write($"<button class=\"btn btn-box-tool\" data-widget=\"remove\"><i class=\"{chart.IconClass} {chart.IconClass}-times\"></i></button>");

			writer.Write("</div>");
		}

		protected virtual void RenderBody(HtmlTextWriter writer)
		{
			var chart = Component;

			writer.Write("<div class=\"box-body\">");

			if (!chart.Height.IsNullOrEmpty())
				chart.HtmlAttributes.Add("height", chart.Height);
			if (!chart.Width.IsNullOrEmpty())
				chart.HtmlAttributes.Add("width", chart.Width);

			writer.Write("<div class=\"chart\">");
			writer.AddAttributes(chart.HtmlAttributes);
			writer.RenderBeginTag("canvas");
			writer.RenderEndTag();
			writer.Write("</div>"); //chart

			writer.Write("</div>"); //box-body
		}
	}
}
