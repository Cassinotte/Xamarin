using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class GlobalPage2 : ContentPage
    {
        public GlobalPage2()
        {
            Title = "Second Global Page";

            var myData = Global.Instance.myData;

            Label label = new Label
            {
                Text = "Persisted id: " + myData.ToString(),
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = { label }

            };

            this.Content = stackLayout;
        }
    }
}