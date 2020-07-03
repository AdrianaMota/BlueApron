using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BlueApronApp.Models;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class PlansViewModel : BaseViewModel
    {
        public ObservableCollection<Plan> Plans { get; set; }
        public INavigation navigation { get; set; }
        public ICommand BackButton { get; set; }

        public PlansViewModel(INavigation _navigation)
        {
            navigation = _navigation;


            BackButton = new Command(async () => {

                await navigation.PopAsync();

            });
            Plans = new ObservableCollection<Plan>()
            {
                new Plan
                {
                    Name = "Two-Person",
                    Serves = "Serves 2 ∙",
                    ImageUrl = "https://images.unsplash.com/photo-1556910103-1c02745aae4d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80",
                    Option1 = 9.99,
                    Option2 = 8.99,
                    Option3 = 8.49
                },
                new Plan
                {
                    Name = "Family",
                    Serves = "Serves 4 ∙",
                    ImageUrl = "https://images.unsplash.com/photo-1577896850715-ed0b7e3ece57?ixlib=rb-1.2.1&auto=format&fit=crop&w=1953&q=80",
                    Option1 = 8.99,
                    Option2 = 7.99,
                    Option3 = 7.49
                }
            };
        }
       
    }
}
