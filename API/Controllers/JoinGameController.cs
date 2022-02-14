using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JoinController : ControllerBase
    {
        private ILogger<WeatherForecastController> _logger;
        private readonly HttpClient httpClient;
        private readonly IToken token;

        public JoinController(ILogger<WeatherForecastController> logger, HttpClient httpClient, IToken token)
        {
            _logger = logger;
            this.httpClient = httpClient;
            this.token = token;
        }

        [HttpGet(Name = "JoinGame")]
        public async Task<string> Get(string name)
        {
            token.Token = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/join?playerName={name}");
            return "You joined the game!";
        }

        




    }

   
}
