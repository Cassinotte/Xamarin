using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_ListViewString
{
    public class ListViewString : ContentPage
    {
        public ListViewString()
        {
            ListView listView = new ListView();

            List<string> items = new List<string>() { "First", "Second", "Third" };

            listView.ItemsSource = items;

            listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Tapped", e.Item.ToString() + "was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;

                await DisplayAlert("Selected", e.SelectedItem.ToString() + "was selected.", "OK");
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            this.Content = new StackLayout {
                Children = { listView }
            
            };
        }
    }
}