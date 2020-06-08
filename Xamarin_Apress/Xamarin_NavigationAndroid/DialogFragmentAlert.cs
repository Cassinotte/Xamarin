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
    public class DialogFragmentAlert : DialogFragment
    {
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {

            var builder = new AlertDialog.Builder(Activity)
                .SetMessage("This is an AlertDialog.")
                .SetPositiveButton("OK", (sender, e) =>
                {
                    // Manipula o clicle no botão
                })
                .SetTitle("DialogFragment");



            return builder.Create();

        }
    }
}