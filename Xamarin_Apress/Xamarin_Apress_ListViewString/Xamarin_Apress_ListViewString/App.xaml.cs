﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Apress_ListViewString
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ListViewString();
            //MainPage = new ListViewDataModel();
            //MainPage = new ListViewImageCell();
            //MainPage = new ListViewCustom();
            //MainPage = new ListViewGrouped();
            MainPage = new ListViewGroupingTemplate();
            //MainPage = new ListViewScroll();
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
