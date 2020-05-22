using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress
{
    public class StackLayoutHorizontal : ContentPage
    {
        public StackLayoutHorizontal()
        {
            StackLayout stackLayoutHorizontal = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text = "Start------"
                    },
                    new Label
                    {
                        Text= "-----Center----",
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    new Label
                    {
                        Text="-----End"
                    }
                }
            };

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Children =
                {
                    new Label
                    {
                        Text = "Start in flush left",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "Start 2",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "Center",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "Center2",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "End1",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "End is flush right",
                        HorizontalOptions = LayoutOptions.End
                    }
                }
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            this.Content = new StackLayout
            {
                Children =
                {
                    stackLayout,
                    stackLayoutHorizontal
                }
            };
        }
    }
}