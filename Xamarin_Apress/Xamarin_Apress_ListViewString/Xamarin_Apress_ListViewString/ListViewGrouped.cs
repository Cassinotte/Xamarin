using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_ListViewString
{
    public class ListViewGrouped : ContentPage
    {

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public ListViewGrouped()
        {

            List<Group> itemsGrouped = new List<Group>
            {
                new Group("Important", new List<ListItem>
                {
                    new ListItem { Title = "First", Description = "1st item" },
                    new ListItem { Title = "Second", Description = "2st item" }
                }),
                new Group("Less Important", new List<ListItem>
                {
                    new ListItem { Title = "Third", Description = "3rd item" }
                })
            };

            ListView listView = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        { TextCell.TextProperty, new Binding("Title") },
                        { TextCell.DetailProperty, new Binding("Description")}
                    }
                }
            };

            listView.ItemsSource = itemsGrouped;

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);


            Content = new StackLayout
            {
                Children = {
                    listView
                }
            };
        }

        public class Group: List<ListItem>
        {
            public String Key { get; private set; }

            public Group(String key, List<ListItem> items)
            {
                Key = key;
                foreach (var item in items)
                {
                    this.Add(item);
                }
            }
        }
    }
}