using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileCloudEaterApp.Services
{
    public interface IAPIService
    {
        Task<string> JoinGameAsync(string playerName);
        Task<string> Move(string moveToken, string password);
        Task<string> MoveBot();
    }

    //public class BasicGameApiService : IAPIService
    //{
    //    private readonly HttpClient httpClient = new HttpClient();

    //    public async Task<string> JoinGameAsync(string playerName)
    //    {
    //        try { return await httpClient.GetStringAsync($"http://localhost:5149/join?name={playerName}"); }
    //        catch(Exception e) { throw; }
    //    }
    //    //public async Task<string> MoveRight(string moveToken)
    //    //{
    //    //    return await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/right?token={moveToken}");
    //    //}
    //    //public async Task<string> MoveUp(string moveToken)
    //    //{
    //    //    return await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/up?token={moveToken}");
    //    //}
    //    //public async Task<string> MoveDown(string moveToken)
    //    //{
    //    //    return await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/down?token={moveToken}");
    //    //}
    //    //public async Task<string> MoveLeft(string moveToken)
    //    //{
    //    //    return await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/left?token={moveToken}");
    //    //}
    //}
}
