﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_SqlLite
{
    public class DataAccessPageRepository : ContentPage
    {
        public DataAccessPageRepository()
        {
            var label = new Label { Text = "Database Created Using SQLLite.Net\n" };

            label.Text += " Using an Advanced Repository\n\n";

            App.Repository.DeleteAllItems(); // limpa a tabela para iniciar renovada

            var item = new Item { Name = "First", Description = "This is the fisrt item" };
            App.Repository.SaveItem(item);

            var firstItem = App.Repository.GetFirstItems();
            label.Text += firstItem.First().Name + " item added.\n";

            var id = 1;
            item = App.Repository.GetItem(id);
            label.Text += item.Name + " item at ID " + id.ToString() + "\n\n";

            App.Repository.DeleteItem(id);
            label.Text += "Deleted item at ID " + id.ToString() + "\n\n";

            item = new Item { Name = "First", Description = "This is the first item" };
            App.Repository.SaveItem(item);

            item = new Item { Name = "Second", Description = "This is the second item" };
            App.Repository.SaveItem(item);

            item = new Item { Name = "Third", Description = "This is the furd item" };
            App.Repository.SaveItem(item);

            var items = App.Repository.GetItems();

            foreach (var i in items)
            {
                label.Text += i.Name + ": " + i.Description + "\n";
            }

            label.Text += "\n Oops, I meant: ";

            item.Description = "This is the third item";
            App.Repository.SaveItem(item);

            id = 4;
            item = App.Repository.GetItem(id);

            label.Text += item.Name + ": " + item.Description + "\n";

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = new StackLayout
            {
                Children = { label }
            };


        }
    }
}