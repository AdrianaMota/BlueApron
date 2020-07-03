using System;
using System.Collections.Generic;
using BlueApronApp.Models;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class RecipeDetailView : Xamarin.Forms.ContentPage
    {
        public RecipeDetailView(string Name, string Details, string ImageUrl, string Description, string Time, string Calories, string Servings)
        {
            InitializeComponent();
            BindingContext = new RecipeDetailsViewModel(Name, Details, ImageUrl, Description, Time, Calories, Servings, Navigation);
        }
    }
}
