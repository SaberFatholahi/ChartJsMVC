using System;
using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	public abstract class DatasetBuilder<TDataset, TDatasetBuilder> 
		where TDataset : Dataset
		where TDatasetBuilder: DatasetBuilder<TDataset, TDatasetBuilder>
	{
		public TDataset Dataset;

		/// <summary>
		/// Labels the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder Label(string value)
		{
			Dataset.Label = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Labelses the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder Labels(params string[] value)
		{
			Dataset.Label = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public TDatasetBuilder BackgroundColor(string value)
		{
			Dataset.BackgroundColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Borders the color.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder BorderColor(string value)
		{
			Dataset.BorderColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Borders the width.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder BorderWidth(int value)
		{
			Dataset.BorderWidth = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the color of the background.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBackgroundColor(string value)
		{
			Dataset.HoverBackgroundColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the background colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBackgroundColors(params string[] value)
		{
			Dataset.HoverBackgroundColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the color of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBorderColor(string value)
		{
			Dataset.HoverBorderColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the border colors.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBorderColors(params string[] value)
		{
			Dataset.HoverBorderColor = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the width of the border.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBorderWidth(long value)
		{
			Dataset.HoverBorderWidth = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Hovers the border widths.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder HoverBorderWidths(params long[] value)
		{
			Dataset.HoverBorderWidth = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Charts the type.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder ChartType(ChartType value)
		{
			Dataset.ChartType = value;
			return this as TDatasetBuilder;
		}
		/// <summary>
		/// Datas the specified add action.
		/// </summary>
		/// <param name="addAction">The add action.</param>
		/// <returns>TDatasetBuilder.</returns>
		public TDatasetBuilder Data(Action<ItemsFactory<object>> addAction)
		{
			Dataset.Data = Dataset.Data ?? new List<object>();
			var factory = new ItemsFactory<object>(Dataset.Data);
			addAction(factory);
			return this as TDatasetBuilder;
		}
	}
}
