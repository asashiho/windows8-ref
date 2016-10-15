using System;
using System.Collections.ObjectModel;

namespace Common.DataModel
{
    public class SampleGroupDataSource
    {
        public string Title { get; private set; }

        public SampleGroupDataSource(String title)
        {
            this.Title = title;
        }


        private ObservableCollection<SampleDataSource> _items = new ObservableCollection<SampleDataSource>();

        public ObservableCollection<SampleDataSource> Items
        {
            get { return this._items; }
        }
    }
}