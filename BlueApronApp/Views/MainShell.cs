using System;

using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public class MainShell : ContentPage
    {
        public MainShell()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

