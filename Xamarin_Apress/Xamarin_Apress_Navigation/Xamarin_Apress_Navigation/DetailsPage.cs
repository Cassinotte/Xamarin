using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(ListItem item)
        {
            Label titleLabel = new Label
            {
                Text = item.Title,
                FontSize = 40
            };

            Label descLabel = new Label
            {
                Text = item.Description,
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = {
                   titleLabel, descLabel
                }
            };

            this.Content = stackLayout;
        }
    }
}