using System;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class RecipeDetailsViewModel
    {
        private INavigation navigation;
        public Command BackButton { get; set; }
        public Command GetStarted { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public string Calories { get; set; }
        public string Servings { get; set; }


        public RecipeDetailsViewModel(string name, string description, string imageUrl, string details, string time, string calories, string servings, INavigation _navigation)
        {
            navigation = _navigation;

            BackButton = new Command(async() => {

                await navigation.PopAsync();

            });
            GetStarted = new Command(async () =>
            {

                await navigation.PushAsync(new PlansView());

            });

            Name = name;
            Details = details;
            ImageUrl = imageUrl;
            Description = description;
            Time = time;
            Calories = calories;
            Servings = servings;

        }
    }
}
