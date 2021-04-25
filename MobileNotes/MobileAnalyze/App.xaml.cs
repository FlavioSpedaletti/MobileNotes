﻿using MobileNotes.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileNotes
{
    public partial class App : Application
    {
        public static string FolderPath { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
