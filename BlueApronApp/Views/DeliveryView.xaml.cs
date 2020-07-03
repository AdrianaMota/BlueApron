using System;
using System.Collections.Generic;
using BlueApronApp.ViewModels;
using Xamarin.Forms;

namespace BlueApronApp.Views
{
    public partial class DeliveryView : Xamarin.Forms.ContentPage
    {
        public DeliveryView()
        {
            InitializeComponent();

            BindingContext = new DeliveryViewModel(Navigation);

        }
    }
}
