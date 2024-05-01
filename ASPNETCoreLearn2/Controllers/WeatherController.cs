using ASPNETCoreLearn2.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace ASPNETCoreLearn2.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService) 
        {
            _weatherService = weatherService;
        }  
        [Route("/Weather/{cityCode}")]
        public IActionResult Weather(string cityCode)
        {
            switch (cityCode) 
            {
                case "ldn":
                    break;
                case "nyc":
                    break;
                case "par":
                    break;
                default:
                    return new ContentResult() { Content="Invalid City Code", ContentType="text/plain", StatusCode=400 };
            } // Custom attribute can be used for this as well.
            CityWeather? weather = _weatherService.GetWeatherByCityCode(cityCode);
            
            return View(weather);
        }
    }
}
