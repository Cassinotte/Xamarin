using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Apress_SqlLite
{
    public partial class App : Application
    {

        static ItemDatabaseBasic database;

        public static ItemDatabaseBasic Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabaseBasic();
                }

                return database;
            }
        }

        static ItemRepository repository;

        public static ItemRepository Repository
        {
            get
            {
                if (repository == null)
                {
                    repository = new ItemRepository();
                }

                return repository;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
