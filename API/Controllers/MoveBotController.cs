using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoveBotController : ControllerBase
    {
        //private ILogger<WeatherForecastController> _logger;
        private readonly HttpClient httpClient;
        private readonly IToken token;

        public MoveBotController(HttpClient httpClient, IToken token)
        {
            this.httpClient = httpClient;
            this.token = token;
        }
        [HttpGet(Name = "MoveBot")]
        public async Task<string> MoveBot()
        {
            int i = 0;
            int movePosition = 2;
            while (i < 10)
            {

                for (i = 0; i < movePosition; i++)
                {
                    string moveToEatPills = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/up?token={token.Token}");
                    if (moveToEatPills.Contains("true"))
                    {
                        token.EatenPills += 1;
                        
                    }
                }
                for (i = 0; i < movePosition; i++)
                {
                    string moveToEatPills = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/right?token={token.Token}");
                    if (moveToEatPills.Contains("true"))
                    {
                        token.EatenPills += 1;
                        
                    }
                }
                movePosition++;
                for (i = 0; i < movePosition; i++)
                {
                    string moveToEatPills = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/down?token={token.Token}");
                    if (moveToEatPills.Contains("true"))
                    {
                        token.EatenPills += 1;
                        
                    }
                }
                for (i = 0; i < movePosition; i++)
                {
                    string moveToEatPills = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/left?token={token.Token}");
                    if (moveToEatPills.Contains("true"))
                    {
                        token.EatenPills += 1;
                        
                    }
                }
                movePosition++;
            }

            return token.EatenPills.ToString();
                
        }

    }
}