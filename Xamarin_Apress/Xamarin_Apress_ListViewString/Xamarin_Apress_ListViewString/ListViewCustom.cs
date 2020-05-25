using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_ListViewString
{
    public class ListViewCustom : ContentPage
    {

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }

            public string Description { get; set; }

            public string Price { get; set; }
        }


        public ListViewCustom()
        {

            var listView = new ListView();

            listView.ItemsSource = new ListItem[]
            {
                new ListItem { Title = "First", Description = "1st item", Price="$100.00" },
                new ListItem { Title = "Second", Description = "2st item", Price="$200.00" },
                new ListItem { Title = "Third", Description = "3st item", Price="$300.00" },
            };

            listView.RowHeight = 80;
            listView.BackgroundColor = Color.Black;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemCell));


            Content = new StackLayout
            {
                Children = {
                    listView
                }
            };

            listView.ItemTapped += as
        }
    }
}