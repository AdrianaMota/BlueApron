using System;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class DeliveryViewModel
    {
        public Command Continue { get; set; }
        public Command BackButton { get; set; }
        public DeliveryViewModel(INavigation navigation)
        {
            BackButton = new Command(async () => {

                await navigation.PopAsync();

            });
            Continue = new Command(async () => {

                await navigation.PopToRootAsync();

            });
        }
    }
}
