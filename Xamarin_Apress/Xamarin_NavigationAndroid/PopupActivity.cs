using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin_NavigationAndroid
{
    [Activity(Label = "PopupActivity")]
    public class PopupActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Popuplayout);
            Button button = FindViewById<Button>(Resource.Id.button);

            button.Click += (s, e) => {

                PopupMenu menu = new PopupMenu(this, button);
                menu.Inflate(Resource.Menu.popupmenu);

                menu.MenuItemClick += (s1, e2) =>
                {
                    Console.WriteLine("{0} Selected", e2.Item.TitleCondensedFormatted);
                };

                menu.Show();

            };

            
        }
    }
}