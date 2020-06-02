﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Apress_Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new HomePage());
            //MainPage = new NavigationPage(new DropdowMenu());
            //MainPage = new NavigationPage(new Alert());
            //MainPage = new NavigationPage(new PopupMenu());
            //MainPage = new NavigationPage(new DrilldownListViewByItem());
            //MainPage = new NavigationPage(new DrilldownListViewByPage());
            //MainPage = new NavigationPage(new DrilldownTableView());
            //MainPage = new NavigationDrawer();
            //MainPage = new NavigationPage(new TabPage());
            MainPage = new NavigationPage(new TabPageDatabound());
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
