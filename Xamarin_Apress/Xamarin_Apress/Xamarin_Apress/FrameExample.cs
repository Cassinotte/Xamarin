using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress
{
    public class FrameExample : ContentPage
    {
        public FrameExample()
        {
            this.Padding = 20;
            this.Content = new Frame
            {
                Content = new Label
                {
                    Text = "Framed",
                    FontSize = 40
                },
                BorderColor = Color.Red
            };

        }
    }
}