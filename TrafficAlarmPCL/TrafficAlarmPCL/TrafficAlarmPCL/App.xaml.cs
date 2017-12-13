﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TrafficAlarmPCL.Database;
using TrafficAlarmPCL.Helper;

namespace TrafficAlarmPCL
{
    public partial class App : Application
    {
        static AlarmDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            

        }

        public static AlarmDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AlarmDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
