using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Apress
{
    public class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {

            Label labelLarge = new Label
            {
                Text = "Label",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Center
            };

            Label labelSmall = new Label
            {
                Text = "This control is great for\n" +
                       "displaying one or more\n" +
                       "lines of text.",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Button button = new Button
            {
                Text = "Make It So",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            button.Clicked += (sender, args) =>
            {
                button.Text = "It is so!";
            };

            Entry entry = new Entry
            {
                Placeholder = "Username",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            BoxView boxView = new BoxView
            {
                Color = Color.Silver,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Fill
            };

            Image image = new Image
            {
                Source = "monkey.jpeg",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                image.Opacity = .5;
            };

            //image.GestureRecognizers.Add(tapGestureRecognizer);

            /*image.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { image.Opacity = .5; }),
            });*/

            var tapGestureRecognizer2 = new TapGestureRecognizer();

            tapGestureRecognizer2.Tapped += async (sender, e) =>
            {
                image.Opacity = .5;
                await Task.Delay(200);
                image.Opacity = 1;
            };

            image.GestureRecognizers.Add(tapGestureRecognizer2);

            StackLayout stackLayout = new StackLayout
            {
                Children = {
                   labelLarge,
                   labelSmall,
                   button,
                   entry,
                   boxView,
                   image
                },
                HeightRequest = 1500
                
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout
                
            };

            //Acomoda a barra de status do iphone
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            this.Content = scrollView;
        }
    }
}