﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class PropertiesPage1 : ContentPage
    {
        Button firstButton;
        public PropertiesPage1()
        {
            Title = "First Properties Page";

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
                await Navigation.PushAsync(new PropertiesPage2());

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, firstButton }

            };

            this.Content = stackLayout;

            Application.Current.Properties["id"] = 12345;
        }

    }
}