using System;
using System.Collections.ObjectModel;
using BlueApronApp.Models;

namespace BlueApronApp.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
      //public ObservableCollection<Setting> Title { get; set; }
       public ObservableCollection<ProfileGroup> ProfileSettings { get; set; }

        public ProfileViewModel()
        {
            ProfileSettings = new ObservableCollection<ProfileGroup>()
            {
                new ProfileGroup("MY FOOD PICS")
                {
                    new Setting { Name = "Saved Recipes" },
                    new Setting { Name = "Manage Push Notification" }
                },
                new ProfileGroup("BLUE APRON")
                {
                    new Setting { Name = "Report Order Issue"},
                    new Setting { Name = "Freshness Guarantee"},
                    new Setting { Name = "Contact & FAQ"},
                    new Setting { Name = "Rate this App"},
                    new Setting { Name = "Send App Feedback"},
                    new Setting { Name = "Acknowledgements"}
                }
            };

        }
    }
}
