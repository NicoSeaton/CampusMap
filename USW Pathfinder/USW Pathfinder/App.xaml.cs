using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using USW_Pathfinder.Services;
using USW_Pathfinder.Views;

namespace USW_Pathfinder
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            MainPage = new NavigationPage(new AboutPage());


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
