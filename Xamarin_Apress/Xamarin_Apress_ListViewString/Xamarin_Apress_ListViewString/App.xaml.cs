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
            MainPage = new ListViewString();
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
