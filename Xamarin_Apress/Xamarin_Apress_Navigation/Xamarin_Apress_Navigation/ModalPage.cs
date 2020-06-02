using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class ModalPage : ContentPage
    {
        Button firstButton;
        public ModalPage()
        {
            Title = "Modal Navigation";

            Label homeLabel = new Label
            {
                Text = "First Page",
                FontSize = 40
            };

            firstButton = new Button
            {
                Text = "Go to Second Page Modally"
            };

            firstButton.Clicked += async (sendernav, args) =>
                await Navigation.PushModalAsync(new ModalSecondPage(), false);

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, firstButton }

            };

            this.Content = stackLayout;
        }
    }
}