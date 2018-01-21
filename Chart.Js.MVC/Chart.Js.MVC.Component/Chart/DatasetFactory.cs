using System.Collections.Generic;

namespace Chart.Js.MVC.Component
{
	public abstract class DatasetFactory <TDataset, TDatasetBuilder>
		where TDataset: Dataset, new()
		where TDatasetBuilder: DatasetBuilder<TDataset, TDatasetBuilder>, new()
	{
        private readonly IList<TDataset> _items;

		protected DatasetFactory(IList<TDataset> items)
        {
            _items = items;
        }

        public virtual TDatasetBuilder Add()
        {
            var item = new TDataset();
            _items.Add(item);
	        var datasetBuilder = new TDatasetBuilder {Dataset = item};
	        return datasetBuilder;
        }
    }
}
