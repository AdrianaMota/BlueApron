using System;
using BlueApronApp.Models;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class PlanDetailsViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public Command BackButton { get; set; }
        public Command Continue { get; set; }
        public string Name { get; set; }
        public string Serves { get; set; }
        public string ImageUrl { get; set; }
        public Double Option1 { get; set; }
        public Double Option2 { get; set; }
        public Double Option3 { get; set; }

        public PlanDetailsViewModel(Plan plan, INavigation navigation)
        {
            Name = plan.Name;
            Serves = plan.Serves;
            ImageUrl = plan.ImageUrl;
            Option1 = plan.Option1;
            Option2 = plan.Option2;
            Option3 = plan.Option3;

            Navigation = navigation;

            BackButton = new Command(async () => {

                await navigation.PopAsync();

            });
            Continue = new Command(async () => {

                await navigation.PushAsync(new DeliveryView());

            });

        }
    }
}

