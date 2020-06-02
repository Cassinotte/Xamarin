using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            this.Title = "TabbedPage";

            this.Children.Add(new HomePage());
            this.Children.Add(new SecondPage());
            this.Children.Add(new ThirdPage());
        }
    }
}
