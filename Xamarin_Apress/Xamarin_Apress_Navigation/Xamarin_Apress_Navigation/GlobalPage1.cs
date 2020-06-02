using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class GlobalPage1 : ContentPage
    {
        Button firstButton;
        public GlobalPage1()
        {
            Title = "First Global Page";

            Label homeLabel = new Label
            {
                Text = "Assigning id = 12345",
                FontSize = 40
            };

            firstButton = new Button
            {
                Text = "Go to Second Page"
            };

            firstButton.Clicked += async (sendernav, args) =>
                await Navigation.PushAsync(new GlobalPage2());

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, firstButton }

            };

            this.Content = stackLayout;

            Global.Instance.myData = "12345";
        }
    }
}