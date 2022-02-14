using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileCloudEaterApp.Services
{
    public class ApiService : IAPIService
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string ServerUrl = "https://eateateateater.azurewebsites.net";
        //private const string ServerUrl = "http://localhost:5149";
        public async Task<string> JoinGameAsync(string playerName)
        {
            return await httpClient.GetStringAsync($"{ServerUrl}/join?name={playerName}");
        }

        public async Task<string> Move(string moveToken, string password)
        {
            try
            {
                return await httpClient.GetStringAsync($"{ServerUrl}/Move?moveToken={moveToken}&password=pass");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
