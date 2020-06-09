using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_DataBinding
{
    public class ListPageUsingListViewModel : ContentPage
    {
        public ListPageUsingListViewModel()
        {
            var listView = new ListView();

            var items = new ListViewModel();
            listView.ItemsSource = items.Items;

            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");


            listView.ItemTapped += async (sender, e) =>
            {
                ObservableItem item = (ObservableItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Button buttonEdid = new Button
            {
                Text = "Edit Row"
            }
        }
    }
}