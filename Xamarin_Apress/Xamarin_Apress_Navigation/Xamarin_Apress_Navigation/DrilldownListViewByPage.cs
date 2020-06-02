using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class DrilldownListViewByPage : ContentPage
    {
        public DrilldownListViewByPage()
        {
            Title = "Drilldown List using ListView";

            var listView = new ListView();

            listView.ItemsSource = new ListItemPage[]
            {
                new ListItemPage { Title = "First", PageType = typeof(FirstPage) },
                new ListItemPage { Title= "Second", PageType = typeof(SecondPage) },
                new ListItemPage { Title = "Third", PageType = typeof(ThirdPage) }
            };

            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItemPage;
                if (item == null) return;
                Page page = (Page)Activator.CreateInstance(item.PageType);

                await Navigation.PushAsync(page);
                listView.SelectedItem = null;
            };


            Content = new StackLayout
            {
                Children = {
                    listView
                }
            };
        }
    }
}