using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class TabPageDatabound : TabbedPage
    {
        public TabPageDatabound()
        {
            this.Title = "Data-bound TabbedPage";

            this.ItemsSource = new TabItem[]
            {
                new TabItem("First", 1),
                new TabItem("Second", 2),
                new TabItem("Third", 3),
                new TabItem("Fourth", 4),
                new TabItem("Fifth", 5),
                new TabItem("Sixth", 6)

            };

            this.ItemTemplate = new DataTemplate(() =>
            {
                return new NumberPage();
            });

       }
    }

    public class NumberPage: ContentPage
    {
        public NumberPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");

            Label label = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 40
            };

            label.SetBinding(Label.TextProperty, "Number");
            this.Content = label;
        }
    }
}