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
    public class TabSecondFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);

            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(
                        Resource.Layout.TabFirst, container, false);
            var text =
                        view.FindViewById<TextView>(Resource.Id.text);
            text.Text = "This is the second tab page.";
            return view;
        }
    }
}