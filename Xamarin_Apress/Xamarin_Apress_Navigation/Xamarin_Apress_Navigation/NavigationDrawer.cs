using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class NavigationDrawer : MasterDetailPage
    {

        public NavigationDrawer()
        {
            Title = "Navigation Drawer Using MasterDetailsPage";

            string[] myPageNames = { "Home", "Second", "Third", "HomeCustom" };

            ListView listView = new ListView
            {
                ItemsSource = myPageNames
            };

            this.Master = new ContentPage
            {
                Title = "Options",
                Content = listView,
                IconImageSource = "hamburger.png"
            };

            listView.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                
                switch(e.Item.ToString())
                {
                    case "Home":
                        gotoPage = new HomePage();
                        break;

                    case "Second":
                        gotoPage = new SecondPage();
                        break;

                    case "Third":
                        gotoPage = new ThirdPage();
                        break;

                    case "HomeCustom":
                        gotoPage = new HomePageCustom();
                        break;

                    default:
                        gotoPage = new NavigationPage1();
                        break;

                }

                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new HomePage());

        }
    }
}
