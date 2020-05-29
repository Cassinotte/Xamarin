using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class HomePage : ContentPage
    {
        Button homeButton;

        public HomePage()
        {
            Title = "Hierarchical Navigation";

            Label homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };

            homeButton = new Button
            {
                Text = "Go to Second Page"
            };

            homeButton.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new SecondPage());

            StackLayout stackLayout = new StackLayout
            {
                Children = {
                    homeLabel, homeButton
                }
            };

            this.Content = stackLayout;
        }
    }
}