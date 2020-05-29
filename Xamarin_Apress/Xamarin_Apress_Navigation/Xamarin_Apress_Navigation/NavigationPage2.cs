using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class NavigationPage2 : ContentPage
    {
        public NavigationPage2()
        {
            Title = "Hierarchical Navigation";

            Label homeLabel = new Label
            {
                Text = "Second Page",
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