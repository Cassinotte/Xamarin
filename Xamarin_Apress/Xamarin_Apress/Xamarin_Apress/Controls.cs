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
            eventValue.FontSize = 10;

            pageValue = new Label();
            pageValue.Text = "Value in Page";
            eventValue.FontSize = 10;

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

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
            };

            datePicker.MaximumDate = Convert.ToDateTime("1/1/2019");
            datePicker.MinimumDate = Convert.ToDateTime("1/1/2014");

            TimePicker timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            timePicker.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
                eventValue.Text = stepper.Value.ToString();
            };

            Slider slider = new Slider()
            {
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300
            };

            slider.ValueChanged += (sender, e) =>
            {
                eventValue.Text = String.Format("Slider value is {0:F1}", e.NewValue);
                pageValue.Text = slider.Value.ToString();
            };

            Switch switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            switcher.Toggled += (sender, e) =>
            {
                eventValue.Text = String.Format("Switch is now {0}", e.Value);
                pageValue.Text = switcher.IsToggled.ToString();
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    eventValue,
                    pageValue,
                    picker,
                    datePicker,
                    timePicker,
                    stepper,
                    slider,
                    switcher
                }
            };
        }
    }
}