using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            Title = "Third Page";

            Label homeLabel = new Label
            {
                Text = "Third Page",
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = { homeLabel }
            };

            this.Content = stackLayout;
        }
    }
}