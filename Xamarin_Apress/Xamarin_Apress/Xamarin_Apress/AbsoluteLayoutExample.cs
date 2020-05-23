using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress
{
    public class AbsoluteLayoutExample : ContentPage
    {
        public AbsoluteLayoutExample()
        {
            Label firstLabel = new Label
            {
                Text = "FirstLabel"
            };

            Label secondLabel = new Label
            {
                Text = "SecontLabel"
            };


            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            absoluteLayout.Children.Add(firstLabel,
                new Rectangle(0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize),
                AbsoluteLayoutFlags.PositionProportional);

            absoluteLayout.Children.Add(secondLabel,
              new Rectangle(0, 1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize),
              AbsoluteLayoutFlags.PositionProportional);

            this.Content = absoluteLayout;
        }
    }
}