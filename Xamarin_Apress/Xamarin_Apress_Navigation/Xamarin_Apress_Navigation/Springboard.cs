using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class Springboard : ContentPage
    {
        public Springboard()
        {

            Title = "Springboard Using Grid";

            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowSpacing = 65,
                ColumnSpacing = 65,
                Padding = 60,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            var firstImage = new Image
            {
                Source = "first.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            grid.Children.Add(firstImage, 0, 0);

            var secondImage = new Image
            {
                Source = "second.png"
            };

            grid.Children.Add(secondImage, 0, 1);

            var thirdImage = new Image
            {
                Source = "third.png"
            };

            grid.Children.Add(thirdImage, 0, 2);


            var tapFirst = new TapGestureRecognizer();

            tapFirst.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new FirstPage());
            };

            firstImage.GestureRecognizers.Add(tapFirst);


            var tapSecond = new TapGestureRecognizer();
            tapSecond.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new SecondPage());
            };

            secondImage.GestureRecognizers.Add(tapSecond);

            var tapthird = new TapGestureRecognizer();
            tapthird.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new ThirdPage());
            };


            thirdImage.GestureRecognizers.Add(tapFirst);

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = grid;
        }
    }
}