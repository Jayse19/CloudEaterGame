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
            int i = 0;
            int moveUp = 20;
            int moveDown = 80;
            int moveRight = 40;
            int moveLeft = 100;
            for (i = 0; i < moveUp; i++)
            {
                await apiService.Move("up","pass");
            }
            for (i = 20; i < moveRight; i++)
            {
                await apiService.Move("right","pass");
            }
            for (i = 60; i < moveDown; i++)
            {
                await apiService.Move("down","pass");
            }
            for (i = 80; i < moveLeft; i++)
            {
                await apiService.Move("left", "pass");
                if (i == 99)
                {
                    i = 0;
                    moveUp = moveUp + 5;
                    moveDown = moveDown + 5;
                    moveRight = moveRight + 5;
                    moveLeft = moveLeft + 5;
                }
            }
            
        }
    }
    
}
