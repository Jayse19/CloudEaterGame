﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<string> MoveBot(string moveToken)
        {
            while(moveToken != null)
            {
                string moveToEatPills = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/{moveToken}/?token={token.Token}");
                if (moveToEatPills.Contains("true"))
                {
                    token.EatenPills += 1;
                    return token.EatenPills.ToString();
                }
                else
                {
                    return moveToEatPills;
                }
            }
                
        }

    }
}