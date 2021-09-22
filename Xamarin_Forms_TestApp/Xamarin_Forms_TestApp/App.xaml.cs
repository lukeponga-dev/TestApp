using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Forms_TestApp.Services;
using Xamarin_Forms_TestApp.Views;

namespace Xamarin_Forms_TestApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
