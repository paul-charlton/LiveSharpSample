using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LiveSharpSample.Views;

namespace LiveSharpSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }
    }
}