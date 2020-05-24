using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress
{
    public class Controls : ContentPage
    {
        Label eventValue;
        Label pageValue;

        public Controls()
        {

            eventValue = new Label();
            eventValue.Text = "Value in Handler";

            pageValue = new Label();
            pageValue.Text = "Value in Page";

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    eventValue,
                    pageValue
                }
            };
        }
    }
}