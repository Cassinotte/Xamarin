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
    [Activity(Label = "ListActivityDataModel")]
    public class ListActivityDataModel : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            List<ListItem> listItems = new List<ListItem>
            {
                new ListItem { Title = "First", Description = "1st item" },
                new ListItem { Title = "Second", Description = "2nd item" },
                new ListItem { Title = "Third", Description = "3rd item" }
            };

            ListAdapter = new ListItemAdapter(this, listItems);
        }
    }
}