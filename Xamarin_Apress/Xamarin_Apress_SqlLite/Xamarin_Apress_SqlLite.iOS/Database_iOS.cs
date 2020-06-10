using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(Xamarin_Apress_SqlLite.iOS.Database_iOS))]
namespace Xamarin_Apress_SqlLite.iOS
{
    public class Database_iOS : IDatabase
    {
        public SQLiteConnection DBConnect()
        {
            var filename = "ItemSQLite.db3";

            string folder =
                Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string libraryFolder = Path.Combine(folder, "..", "Library");
            var path = Path.Combine(libraryFolder, filename);

            var connection = new SQLiteConnection(path);

            return connection;
        }
    }
}