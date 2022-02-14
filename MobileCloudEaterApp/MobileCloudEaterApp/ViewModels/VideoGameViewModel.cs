using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobileCloudEaterApp.Services;
using MobileCloudEaterApp.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels;

public partial class VideoGameViewModel : ObservableObject
{
    private IAPIService apiService;
    public Command AutoBotsCommand { get; }

    public VideoGameViewModel(IAPIService apiService = null)
    {
        this.apiService = apiService ?? DependencyService.Get<IAPIService>();
        areGameButtonsVisible = false;
        isJoinButtonVisible = true;
        AutoBotsCommand = new Command(OnBotClicked);
          
    }

    private async void OnBotClicked()
    {
        await Shell.Current.GoToAsync($"//{nameof(AutoBots)}");
    }

    [ObservableProperty]
    private string desiredPlayerName;

    [ObservableProperty]
    private string result;

    [ObservableProperty]
    private bool areGameButtonsVisible;

    [ObservableProperty]
    private bool isJoinButtonVisible;

    [ObservableProperty]
    private string password;

    [ICommand]
    public async Task JoinGame()
    {
        if (Password == "pass")
        {
            Result = await apiService.JoinGameAsync(DesiredPlayerName);
            AreGameButtonsVisible = true;
            IsJoinButtonVisible = false;
        }
        else
        {
            Result = "Password is invalid or empty, Try again";
        }
    }
    [ICommand]
    public async Task RightMove()
    {
        await apiService.Move("right", "pass");
    }
    [ICommand]
    public async Task LeftMove()
    {
        await apiService.Move("left", "pass");
        
    }
    [ICommand]
    public async Task UpMove()
    {
        await apiService.Move("up", "pass");
        

    }
    [ICommand]
    public async Task DownMove()
    {
        await apiService.Move("down", "pass");
        
    }

}
