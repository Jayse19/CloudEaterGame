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
        public async Task JoinBot()
        {
            Result = await apiService.JoinGameAsync(DesiredPlayerName);
            await apiService.MoveBot();
            //int i = 0;
            //int movePosition = 2;
            //while (i < 100)
            //{
                
            //    for (i = 0; i < movePosition; i++)
            //    {
            //        await apiService.Move("up", "pass");
            //    }
            //    for (i = 0; i < movePosition; i++)
            //    {
            //        await apiService.Move("right", "pass");
            //    }
            //    movePosition++;
            //    for (i = 0; i < movePosition; i++)
            //    {
            //        await apiService.Move("down", "pass");
                 
            //    }
            //    for (i = 0; i < movePosition; i++)
            //    {
            //        await apiService.Move("left", "pass");
            //    }
            //    movePosition++;
            //}
            
        }
    }
    
}
