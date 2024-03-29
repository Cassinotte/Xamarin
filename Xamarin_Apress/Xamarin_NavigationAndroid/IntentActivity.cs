﻿using System;
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
    [Activity(Label = "IntentActivity")]
    public class IntentActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Intent);

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate {
                Intent intent = new Intent(this, typeof(IntentToActivity));
                StartActivity(intent);
                //StartActivity(typeof(IntentToActivity));  // this abbreviated statement replaces the previous two lines
            };
        }
    }
}