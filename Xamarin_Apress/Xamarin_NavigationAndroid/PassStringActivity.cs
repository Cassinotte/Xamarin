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
    [Activity(Label = "PassStringActivity")]
    public class PassStringActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PassFrom);

            // Create your application here
            var intent = new Intent(this, typeof(PassStringToActivity));

            intent.PutExtra("MyData", "A string of data");
            StartActivity(intent);


        }
    }
}