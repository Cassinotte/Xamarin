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
    [Activity(Label = "PassBundleActivity")]
    public class PassBundleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PassFrom);

            // using Bundles
            Bundle thisBundle = new Bundle();

            thisBundle.PutString("MyData", "A string of data.");
            thisBundle.PutString("MyData2", "Another string of data");

            var intent = new Intent(this, typeof(PassToBundleActivity));

            intent.PutExtras(thisBundle);

            StartActivity(intent);

        }
    }
}