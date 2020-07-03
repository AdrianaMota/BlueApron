using System;
using System.Collections.Generic;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class MoreView : ContentPage
    {
        public MoreView()
        {
            InitializeComponent();
            BindingContext = new LearnMoreViewModel(Navigation);

        }
    }
}
