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
    [Activity(Label = "PassObjectToActivity")]
    public class PassObjectToActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PassTo);
            TextView text1 = FindViewById<TextView>(Resource.Id.textPassed1);
            TextView text2 = FindViewById<TextView>(Resource.Id.textPassed2);

            String json = Intent.GetStringExtra("MyData") ?? "No Data";
            DataModel data = Newtonsoft.Json.JsonConvert.DeserializeObject<DataModel>(json);
            text1.Text = data.Id.ToString();
            text2.Text = data.Info;
        }
    }
}