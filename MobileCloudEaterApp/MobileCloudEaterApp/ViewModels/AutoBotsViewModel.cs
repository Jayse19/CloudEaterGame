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
            int moveUp = 2;
            int moveDown = 6;
            int moveRight = 4;
            int moveLeft = 8;
            while (i < 100)
            {
                
                for (i = moveUp; i < moveRight; i++)
                {
                    await apiService.Move("right", "pass");
                }
                for (i = moveRight; i < moveDown; i++)
                {
                    await apiService.Move("down", "pass");
                }
                for (i = moveDown; i < moveLeft; i++)
                {
                    await apiService.Move("left", "pass");
                 
                }
                for (i = moveLeft; i < moveUp; i++)
                {
                    await apiService.Move("up", "pass");
                }
                if (i == moveLeft)
                {
                    i = 0;
                    moveUp += 1;
                    moveDown += 1;
                    moveRight += 1;
                    moveLeft += 1;
                }
            }
            
        }
    }
    
}
