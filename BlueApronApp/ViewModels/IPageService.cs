using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public interface IPageService
    {
        Task PushAsync(Page page);
    }
}
