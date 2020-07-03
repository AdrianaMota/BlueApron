using System;
using System.Collections.ObjectModel;

namespace BlueApronApp.Models
{
    public class ProfileGroup : ObservableCollection<Setting>
    {
        public string Title { get; set; }

		public ProfileGroup(string title)
		{
            Title = title;
		}
    }
}
