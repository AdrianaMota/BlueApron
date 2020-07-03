using System;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class LearnMoreViewModel
    {
        public Command GetStarted { get; set; }
        public Command LogIn { get; set; }

        public LearnMoreViewModel(INavigation navigation)
        {
            GetStarted = new Command(async () => {

                await navigation.PushAsync(new PlansView());

            });
            LogIn = new Command(async () => {

                await navigation.PushAsync(new LogInView());

            });
        }
    }
}
