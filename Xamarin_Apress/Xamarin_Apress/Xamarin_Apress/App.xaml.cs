﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Apress
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ContentPageExample();
            //MainPage = new StackLayoutVertical();
            MainPage = new StackLayoutHorizontal();
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
