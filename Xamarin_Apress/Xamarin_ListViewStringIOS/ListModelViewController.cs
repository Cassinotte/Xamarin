using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace Xamarin_ListViewStringIOS
{
    [Register("ListModelViewController")]
    public class ListModelViewController : UIViewController
    {
        public ListModelViewController()
        {
        }

        List<ListItem> listItems;

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            UITableView table = new UITableView(View.Bounds);

            listItems = new List<ListItem>
            {
                new ListItem { Title = "First", Description = "1st item" },
                new ListItem { Title = "Second", Description = "2nd item" },
                new ListItem { Title = "Third", Description = "3rd item" }
            };

            table.Source = new ListSourceFromModel(listItems);
            Add(table);
        }
    }
}