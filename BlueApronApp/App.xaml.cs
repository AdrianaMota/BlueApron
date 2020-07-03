using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApronApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Views.MenuView());
            //MainPage = new NavigationPage(new Views.RecipesView());
            //MainPage = new NavigationPage(new Views.MoreView());
            MainPage = new MainShell();
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
