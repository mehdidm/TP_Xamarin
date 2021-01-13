using System;
using System.IO;
using TP.Models;
using TP.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Environment;

namespace TP
{
    public partial class App : Application
    {



        static Data dataBase;
        public static Data DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new Data(Path.Combine(System.Environment.GetFolderPath(SpecialFolder.LocalApplicationData), "users.db3"));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
