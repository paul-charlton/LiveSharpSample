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
            Device.SetFlags(new string[] { "Markup_Experimental" });

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