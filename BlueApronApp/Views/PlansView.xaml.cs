using System;
using System.Collections.Generic;
using BlueApronApp.Models;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class PlansView : Xamarin.Forms.ContentPage
    {
        public PlansView()
        {
            InitializeComponent();
            BindingContext = new PlansViewModel(Navigation);
        }
        private async void OnPlanSelected(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Plan;
            await Navigation.PushAsync(new PlanDetailsView(details));
        }
    }
}
