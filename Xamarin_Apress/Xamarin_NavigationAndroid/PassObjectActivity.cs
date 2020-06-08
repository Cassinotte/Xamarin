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
    [Activity(Label = "PassObjectActivity")]
    public class PassObjectActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PassFrom);

            DataModel data = new DataModel();
            data.Id = 1;
            data.Info = "First";

            //Use JSON.NET Xamarin component to pass instance of DataModel 
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            var intent = new Intent(this, typeof(PassObjectToActivity));
            intent.PutExtra("MyData", json);

            StartActivity(intent);
        }
    }
}