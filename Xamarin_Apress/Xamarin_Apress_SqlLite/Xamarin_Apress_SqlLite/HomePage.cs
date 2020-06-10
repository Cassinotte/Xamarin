using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_SqlLite
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "SQLite.NET: Chapter 7";

            var listView = new ListView();
            listView.ItemsSource = new ListItemPage[] {
                new ListItemPage {Title = "Basic Repository", PageType= typeof(DataAccessPageDatabase)},
                new ListItemPage {Title = "Advanced Repository", PageType= typeof(DataAccessPageRepository)},
                new ListItemPage {Title = "Access the Person Table", PageType= typeof(DataAccessPagePerson)}
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

            Content = listView;

        }

        public class ListItemPage
        {
            public string Title { get; set; }
            public Type PageType { get; set; }
        }

    }
}