﻿using DocShifting.Services;
using DocShifting.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DocShifting
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new LoginUI();
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