using System.Collections.Generic;
using System.Linq;

namespace Chart.Js.MVC.Component
{
	public class ItemsFactory<T>
	{
		private readonly List<T> _items;

		public ItemsFactory(List<T> items)
		{
			_items = items;
		}

		public virtual void Add(T item)
		{
			_items.Add(item);
		}

		public virtual void AddList(List<T> items)
		{
			if (items != null && items.Any())
				_items.AddRange(items);
		}

		public virtual void AddDynamicList(params T[] items)
		{
			if (items != null && items.Any())
				_items.AddRange(items);
		}
	}
}