using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin_Apress_DataBinding
{
    public class ListViewModel
    {
        private ObservableCollection<ObservableItem> items;

        public ListViewModel()
        {
            items = new ObservableCollection<ObservableItem>()
            {
                new ObservableItem { Title = "First", Description="1st item" },
                new ObservableItem { Title = "Second", Description="2nd item" },
                new ObservableItem { Title = "Third", Description="3rd item" },
            };
        }

        public ObservableCollection<ObservableItem> Items
        {
            set
            {
                if( value != items)
                {
                    items = value;
                }
            }
            get
            {
                return items;
            }
        }

    }
}
