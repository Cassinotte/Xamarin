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
    [Activity(Label = "DrilldownListActivity")]
    public class DrilldownListActivity : ListActivity
    {
        List<ListItem> listItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            listItems = new List<ListItem>
            {
                new ListItem { Title = "First Page", PageType = typeof(DrilldownActivity1) },
                new ListItem { Title = "Second Page", PageType = typeof(DrilldownActivity2) },
                new ListItem { Title = "Third Page", PageType = typeof(DrilldownActivity3) }
            };

            ListAdapter = new ListItemAdapter(this, listItems);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }
    }
}