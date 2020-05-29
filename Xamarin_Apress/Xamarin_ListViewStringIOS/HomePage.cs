using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace Xamarin_ListViewStringIOS
{
    [Register("HomePage")]
    public class HomePage : UIViewController
    {
		protected List<ListMenuItem> listItems;

		public HomePage()
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UITableView table = new UITableView(View.Bounds);
			listItems = new List<ListMenuItem> {
				new ListMenuItem {Title = "List Bound to an Array", PageType = typeof(ListArrayViewController)},
				new ListMenuItem {Title = "List Bound to a Data Model", PageType = typeof(ListModelViewController)},
				new ListMenuItem {Title = "Custom List", PageType =typeof(ListCustomViewController)},
				new ListMenuItem {Title = "List with Grouping", PageType = typeof(ListModelGroupedViewController)},
				new ListMenuItem {Title = "List with New Cell Reuse", PageType = typeof(ListModelViewControllerCellReuse)}
			};

			table.Source = new ListMenuSource(listItems, this);
			Add(table);

			this.Title = "iOS UITableView - Chapter 5";
		}
	}
}
