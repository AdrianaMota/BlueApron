using System;
using System.Collections.Generic;
using BlueApronApp.Models;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class RecipesView : Xamarin.Forms.ContentPage
    {
        public RecipesView()
        {
            InitializeComponent();
            BindingContext = new RecipesViewModel(Navigation);
        }
        private async void OnRecipeSelected (object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await Navigation.PushAsync(new RecipeDetailView(details.Name, details.Description, details.ImageUrl, details.Details, details.Time, details.Calories, details.Servings));
        }
        
    }
}
