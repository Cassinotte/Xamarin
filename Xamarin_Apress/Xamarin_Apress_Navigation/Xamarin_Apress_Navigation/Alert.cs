using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class Alert : ContentPage
    {
        public Alert()
        {
            Title = "Alerts Using DisplayAlert";

            Button button = new Button { Text = "Show Alert" };
            button.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Hey", "You really should know about this.", "OK");
                //Boolean answer = await DisplayAlert("Start", "Are you ready to begin?", "Yes", "No");
            };

            StackLayout stackLayout = new StackLayout
            {
                Children = { button }

            };

            this.Content = stackLayout;

        }
    }
}