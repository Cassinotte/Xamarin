using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class Carousel : CarouselPage
    {
        public Carousel()
        {
            Title = "Carousel Using CarouselPage";

            this.Children.Add(new FirstPage());
            this.Children.Add(new SecondPage());
            this.Children.Add(new ThirdPage());

        }
    }
}