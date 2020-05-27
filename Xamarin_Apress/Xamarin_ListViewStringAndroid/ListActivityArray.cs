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

namespace Xamarin_ListViewStringAndroid
{
    [Activity(Label = "ListActivityArray")]
    public class ListActivityArray : ListActivity
    {

        string[] listItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            listItems = new string[] { "First", "Second", "Third" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, listItems);

            //ListView.ChoiceMode = Android.Widget.ChoiceMode.Multiple;
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            String SelectedItem = listItems[position];
            Android.Widget.Toast.MakeText(this, SelectedItem, Android.Widget.ToastLength.Short).Show();
        }
    }
}