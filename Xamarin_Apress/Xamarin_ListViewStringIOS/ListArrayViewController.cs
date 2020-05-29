using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Xamarin_ListViewStringIOS
{
   
    [Register("ListArrayViewController")]
    public class ListArrayViewController : UIViewController
    {
        public ListArrayViewController()
        {
        }

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
            UITableView tableView = new UITableView(View.Bounds);

            string[] tableItems = new string[] { "First", "Second", "Third", "Fourth", "Fifth" };
            tableView.Source = new ListSourceFromArray(tableItems);

            Add(tableView);

        }
    }
}