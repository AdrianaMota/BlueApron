using System;

using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public class RecipesView : ContentPage
    {
        public RecipesView()
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

