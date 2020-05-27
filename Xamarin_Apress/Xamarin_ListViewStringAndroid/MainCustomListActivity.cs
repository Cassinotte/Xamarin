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
    [Activity(Label = "MainCustomListActivity")]
    public class MainCustomListActivity : Activity
    {
        List<ListItem> listItems;
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            listItems = new List<ListItem>
            {
                new ListItem { Title = "First", Description="1st item" },
                new ListItem { Title = "Second", Description= "2nd item" },
                new ListItem { Title = "Third", Description = "3rd item"}
            };

            SetContentView(Resource.Layout.HomeLayout);
            listView = FindViewById<ListView>(Resource.Id.listItems);
            listView.Adapter = new ListCustomAdapter(this, listItems);
            listView.ItemClick += OnListItemClick;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            String SelectedItem = listItems[e.Position].Title;
            Android.Widget.Toast.MakeText(this, SelectedItem, Android.Widget.ToastLength.Short)
                .Show();
        }
    }
}