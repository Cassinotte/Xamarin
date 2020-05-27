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
    public class ListCustomAdapter : BaseAdapter
    {
        private List<ListItem> itemList;
        private Activity context;

        public ListCustomAdapter(Activity context, List<ListItem> items) : base()
        {
            this.context = context;
            itemList = items;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomLayout, null);
            }

            view.FindViewById<TextView>(Resource.Id.title).Text =
                itemList[position].Title;

            view.FindViewById<TextView>(Resource.Id.description).Text =
                itemList[position].Description;

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return itemList.Count;
            }
        }

    }

    class ListCustomAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}