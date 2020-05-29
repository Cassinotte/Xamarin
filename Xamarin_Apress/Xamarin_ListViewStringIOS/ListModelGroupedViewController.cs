using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace Xamarin_ListViewStringIOS
{

    [Register("ListModelGroupedViewController")]
    public class ListModelGroupedViewController : UIViewController
    {
        List<Group> itemsGrouped;

        public ListModelGroupedViewController()
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
            UITableView table = new UITableView(View.Bounds);

            itemsGrouped = new List<Group>
            {
                new Group("Important", new List<ListItem>
                {
                    new ListItem { Title = "First", Description = "1st item"},
                    new ListItem { Title = "Second", Description = "2nd item"}
                }),
                new Group("Less Important", new List<ListItem>
                {
                    new ListItem() { Title = "Third", Description = "3rd item" }
                })
            };

            table.Source = new ListSourceFromModelGrouped(itemsGrouped);
            Add(table);
        }
    }
}