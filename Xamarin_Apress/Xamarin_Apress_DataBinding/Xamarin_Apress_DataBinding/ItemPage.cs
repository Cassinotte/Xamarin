using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_DataBinding
{
    public class ItemPage : ContentPage
    {
        public ItemPage()
        {
            var item = new Item { Title = "First", Description = "1st item" };
            this.BindingContext = item;
            //titleEntry.BindingContext = item;

            var titleEntry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            titleEntry.SetBinding(Entry.TextProperty, "Title");

            Button buttonDisplay = new Button
            {
                Text = "Display Item Value",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            buttonDisplay.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Item Object", "Title property:" + item.Title.ToString(), "OK");
            };

           
            Content = new StackLayout
            {
                Children = { titleEntry, buttonDisplay }
            };

        }
    }
}