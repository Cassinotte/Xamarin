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
    [Activity(Label = "ModalAlertActivity")]
    public class ModalAlertActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            // AlertDialog
            var alert = new AlertDialog.Builder(this);
            //var button = FindViewById<Button>(Resource.Id.submitButton);
            //button.Click += (o, e) => { alert.Create().Cancel(); };
            alert.SetView(LayoutInflater.Inflate(Resource.Layout.Modal, null));
            alert.Create().Show();
        }
    }
}