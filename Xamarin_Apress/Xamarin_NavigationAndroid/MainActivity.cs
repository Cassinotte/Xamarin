using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;

namespace Xamarin_NavigationAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {

        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> {
                //new ListItem {Title = "Starting Activities Using Intents", PageType= typeof(IntentActivity)},
                new ListItem {Title = "Hierarchical Navigation Using Toolbar", PageType= typeof(ToolbarActivity)},
                new ListItem {Title = "Fragments", PageType= typeof(FragmentsActivity)},
                //new ListItem {Title = "Modal Using DialogFragment", PageType= typeof(DialogViewActivity)},
                //new ListItem {Title = "Alert Using DialogFragment", PageType= typeof(DialogAlertActivity)},
                //new ListItem {Title = "Modal Using AlertDialog", PageType= typeof(ModalAlertActivity)},
                //new ListItem {Title = "Popup Menu", PageType= typeof(PopupActivity)},
                //new ListItem {Title = "Passing Strings Using Intent", PageType= typeof(PassStringActivity)},
                //new ListItem {Title = "Passing Objects Using Intent", PageType= typeof(PassObjectActivity)},
                //new ListItem {Title = "Passing Data Using a Bundle", PageType= typeof(PassBundleActivity)},
                //new ListItem {Title = "Drilldown List by Page", PageType= typeof(DrilldownListActivity)},
                //new ListItem {Title = "Tabs Using ActionBar", PageType= typeof(TabMenuActivity)}
            };

            ListAdapter = new ListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}