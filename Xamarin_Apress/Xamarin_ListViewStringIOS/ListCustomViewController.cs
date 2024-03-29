﻿using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace Xamarin_ListViewStringIOS
{
    [Register("ListCustomViewController")]
    public class ListCustomViewController : UIViewController
    {
		public ListCustomViewController()
		{
		}

		List<ListItem> listItems;

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UITableView table = new UITableView(View.Bounds);
			listItems = new List<ListItem> {
				new ListItem {Title = "First", Description="1st item"},
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"}
			};

			table.Source = new ListSourceFromCustomCell(listItems);
			Add(table);
		}
	}
}