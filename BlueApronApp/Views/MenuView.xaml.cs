using System;
using System.Collections.Generic;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class MenuView : Xamarin.Forms.ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
            BindingContext = new RecipesViewModel(Navigation);
        }

    }
}
