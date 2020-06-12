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
using DependencyServiceExample.Droid;
using Xamarin_DependencyService;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_Android))]

namespace DependencyServiceExample.Droid
{
    class CustomClass_Android : ICustomClass
    {
        public CustomClass_Android() { }

        public string GoNative(string param)
        {
            return "Android " + param;
        }
    }
}