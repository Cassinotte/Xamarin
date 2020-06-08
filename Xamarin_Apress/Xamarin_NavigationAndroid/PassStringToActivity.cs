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
    [Activity(Label = "DetailActivity")]
    public class PassStringToActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PassTo);

            TextView text1 = FindViewById<TextView>(Resource.Id.textPassed1);

            String text = Intent.GetStringExtra("MyData") ?? "No Data";
            text1.Text = text;
        }
    }
}