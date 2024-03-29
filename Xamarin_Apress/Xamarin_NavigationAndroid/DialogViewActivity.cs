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
    [Activity(Label = "DialogViewActivity")]
    public class DialogViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var transaction = FragmentManager.BeginTransaction();
            var dialogFragment = new DialogFragmentView();
            dialogFragment.Show(transaction, "dialog_fragment");
        }
    }
}