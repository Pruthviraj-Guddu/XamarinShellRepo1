using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new MainShell();
            MainPage = new FlyoutMainShell();

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
