using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;
using Xamarin_Apress_SqlLite.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Database_Android))]
namespace Xamarin_Apress_SqlLite.Droid
{
    public class Database_Android : IDatabase
    {
        public SQLiteConnection DBConnect()
        {
            var filename = "ItemSQLite.db3";
            string folder =
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(folder, filename);

            var connection = new SQLiteConnection(path);

            return connection;

        }
    }
}