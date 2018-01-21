using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	public static class RendererFactory
	{
		public static object ResolveRenderer(Component componentrendrar)
		{
			if (componentrendrar is Pie || componentrendrar is Doughnut)
				return new PieRenderer();
			if (componentrendrar is Line)
				return new LineRenderer();
			if (componentrendrar is Bar || componentrendrar is HorizontalBar)
				return new BarRenderer();
			if (componentrendrar is Radar)
				return new RadarRenderer();
			if (componentrendrar is Polar)
				return new PolarRenderer();
			if (componentrendrar is Bubble)
				return new BubbleRenderer();
			return null;

		}
	}
}
