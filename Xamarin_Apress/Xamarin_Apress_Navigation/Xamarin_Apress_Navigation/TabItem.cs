using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Apress_Navigation
{
    public class TabItem
    {
        public TabItem(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }

        public int Number { get; set; }
    }
}
