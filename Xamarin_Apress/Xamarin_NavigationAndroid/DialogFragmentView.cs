using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Xamarin_NavigationAndroid
{
    public class DialogFragmentView : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            base.OnCreate(savedInstanceState);


            var view = inflater.Inflate(Resource.Layout.Modal, container, false);


            view.FindViewById<Button>(Resource.Id.submitButton).Click +=
                (sender, args) => Dismiss();


            return view;


            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}