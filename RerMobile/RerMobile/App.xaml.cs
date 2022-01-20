﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RerMobile
{
    public partial class App : Application
    {
        internal static NavigationPage NavPage;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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