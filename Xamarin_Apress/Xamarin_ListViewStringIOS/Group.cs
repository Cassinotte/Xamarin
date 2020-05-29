using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Foundation;
using UIKit;

namespace Xamarin_ListViewStringIOS
{
    public class Group : List<ListItem>
    {
        public string Key { get; private set; }

        public Group(String key, List<ListItem> items)
        {
            Key = key;
            foreach (var item in items)
            {
                this.Add(item);
            }
        }
    }
}