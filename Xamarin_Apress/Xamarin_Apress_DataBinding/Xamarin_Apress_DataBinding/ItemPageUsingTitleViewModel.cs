using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_DataBinding
{
    public class ItemPageUsingTitleViewModel : ContentPage
    {
        public ItemPageUsingTitleViewModel()
        {
            var titleViewModel = new TitleViewModel();
            titleViewModel.Title = "First";
            this.BindingContext = titleViewModel;

            var titleEntry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            titleEntry.SetBinding(Entry.TextProperty, new Binding("Title"));

            Button buttonDisplay = new Button
            {
                Text = "Display Item Value",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            buttonDisplay.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
            };

            Button buttonUpdate = new Button
            {
                Text = "Update the Data Model",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            buttonUpdate.Clicked += async (sender, args) =>
            {
                titleViewModel.Title = "Data Model Updated";
                await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
            };


            Content = new StackLayout
            {
                Children = { titleEntry, buttonDisplay, buttonUpdate }
            };


        }
    }
}