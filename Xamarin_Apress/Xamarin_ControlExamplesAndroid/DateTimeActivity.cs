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

namespace Xamarin_ControlExamplesAndroid
{
    [Activity(Label = "DateTimeActivity")]
    public class DateTimeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.DateTime);

            //DatePicker datePicker = FindViewById<DatePicker>(Resource.Id.edu);
            TimePicker timePicker = FindViewById<TimePicker>(Resource.Id.timePicker);

            timePicker.TimeChanged += delegate (object sender, TimePicker.TimeChangedEventArgs e)
            {
                Toast.MakeText(this, "Hour: " + e.HourOfDay + " Minute: " + e.Minute, ToastLength.Short).Show();
            };
        }

    }
}