using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class PageService : IPageService
    {
        public async Task PushAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
