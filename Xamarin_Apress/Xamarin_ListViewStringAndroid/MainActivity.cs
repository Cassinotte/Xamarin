using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;

namespace Xamarin_ListViewStringAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        List<MenuListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<MenuListItem> {
                new MenuListItem {Title = "Bind to Array of Strings", PageType= typeof(ListActivityArray)},
                new MenuListItem {Title = "Bind to Data Model", PageType= typeof(ListActivityDataModel)},
                new MenuListItem {Title = "Customize List", PageType= typeof(MainCustomListActivity)},
                new MenuListItem {Title = "Grouping a list", PageType= typeof(MainActivityGrouped)}
            };

            ListAdapter = new MenuListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}