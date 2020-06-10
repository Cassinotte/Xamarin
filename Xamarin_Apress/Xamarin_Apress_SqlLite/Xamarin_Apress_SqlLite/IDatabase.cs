using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Apress_SqlLite
{
    public interface IDatabase
    {
        SQLiteConnection DBConnect();
    }
}
