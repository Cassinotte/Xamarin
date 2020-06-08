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
//using Android.Support.V7.App;
//using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Xamarin_NavigationAndroid
{
    [Activity(Label = "ToolbarActivity")]
    public class ToolbarActivity : Activity
    {
        //stackoverflow.com/questions/30382709/android-support-v7-app-actionbaractivity-is-deprecated/32177721
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainToolbar);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetActionBar(toolbar);

            ActionBar.Title = "Toolbar Home";

            var nextPageButton = FindViewById<Button>(Resource.Id.nextPageButton);

            nextPageButton.Click += (sender, e) =>
            {
                StartActivity(typeof(ToolbarActivitySecond));
            };

        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch(item.ItemId)
            {
                case Resource.Id.item1:
                    Toast.MakeText(this, "Item1 tapped", ToastLength.Short).Show();

                    return true;

                case Resource.Id.item2:
                    Toast.MakeText(this, "Item2 tapped", ToastLength.Short).Show();

                    return true;

                case Resource.Id.item3:
                    Toast.MakeText(this, "Item3 tapped", ToastLength.Short).Show();

                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.popupmenu, menu);

            return base.OnCreateOptionsMenu(menu);
        }

    }
}