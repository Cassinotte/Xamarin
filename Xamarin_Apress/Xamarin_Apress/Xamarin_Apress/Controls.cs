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
            eventValue.FontSize = 20;

            pageValue = new Label();
            pageValue.Text = "Value in Page";
            eventValue.FontSize = 20;

            Picker picker = new Picker
            {
                Title = "Option",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<string> { "Firts", "Second", "Third", "Fourth" };

            foreach (var optionName in options)
            {
                picker.Items.Add(optionName);
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    eventValue,
                    pageValue,
                    picker
                }
            };
        }
    }
}