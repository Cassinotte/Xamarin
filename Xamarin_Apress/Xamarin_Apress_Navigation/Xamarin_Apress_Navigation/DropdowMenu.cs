using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class DropdowMenu : ContentPage
    {
        public DropdowMenu()
        {
            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Home",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                    Navigation.PushAsync(new NavigationPage1()))
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Second",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                    Navigation.PushAsync(new NavigationPage2()))
            });
        }
    }
}