using System;
using System.IO;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class App : Application
    {
        static BaseDeDatos database;

        public static BaseDeDatos BaseDeDatos
        {
            get
            {
                if (database == null)
                {
                   database = new BaseDeDatos("server=192.168.1.7;uid=testapp;port=1434;pwd=lbwebs1234;database=Empleados");
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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