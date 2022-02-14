using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobileCloudEaterApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCloudEaterApp.ViewModels
{
    public partial class AutoBotsViewModel : ObservableObject
    {
        private IAPIService apiService;
        public AutoBotsViewModel(IAPIService apiService = null)
        {
            this.apiService = apiService ?? DependencyService.Get<IAPIService>();
        }
        [ObservableProperty]
        private string result;
        [ObservableProperty]
        private string desiredPlayerName;

        [ICommand]
        public async Task JoinGame()
        {
            Result = await apiService.JoinGameAsync(DesiredPlayerName);
        }
    }
    
}
