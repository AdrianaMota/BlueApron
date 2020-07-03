using System;
using System.Collections.Generic;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class LogInView : Xamarin.Forms.ContentPage
    {
        public LogInView()
        {
            InitializeComponent();
            BindingContext = new PlansViewModel(Navigation);

        }
    }
}
