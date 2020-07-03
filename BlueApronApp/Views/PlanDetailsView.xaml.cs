using System;
using System.Collections.Generic;
using BlueApronApp.Models;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class PlanDetailsView : Xamarin.Forms.ContentPage
    {
        public PlanDetailsView(Plan plan)
        {
            InitializeComponent();
            BindingContext = new PlanDetailsViewModel(plan, Navigation);

        }
    }
}
