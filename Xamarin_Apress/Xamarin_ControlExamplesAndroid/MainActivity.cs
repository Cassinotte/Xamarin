using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;

namespace Xamarin_ControlExamplesAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> {
                new ListItem {Title = "Spinner", PageType= typeof(SpinnerActivity)},
                //new ListItem {Title = "Selection Controls", PageType= typeof(SelectionActivity)},
                //new ListItem {Title = "Date Picker", PageType= typeof(DatePickerActivity)},
                //new ListItem {Title = "Time Picker", PageType= typeof(TimePickerActivity)},
                //new ListItem {Title = "Date/Time Picker", PageType= typeof(DateTimeActivity)}
            };

            ListAdapter = new ListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }
    }
}