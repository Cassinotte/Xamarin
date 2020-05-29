using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Xamarin_ListViewStringIOS
{
    public class ListSourceFromArray : UITableViewSource
    {
        protected string[] listItems;
        protected string CellId = "TableCell";

        public ListSourceFromArray(string[] items)
        {
            listItems = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return listItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellId);
            if (cell == null) cell = new UITableViewCell(UITableViewCellStyle.Default, CellId);
            cell.TextLabel.Text = listItems[indexPath.Row];
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            new UIAlertView("Row Selected", listItems[indexPath.Row],
                null, "OK", null).Show();

            tableView.DeselectRow(indexPath, true);
        }
    }
}