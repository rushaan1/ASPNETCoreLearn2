using ASPNETCoreLearn2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreLearn2.Controllers
{
    public class WeatherController : Controller
    {
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
            List<CityWeather> cw = new List<CityWeather>()
            {
                new CityWeather(){
                    CityUniqueCode = "LDN",
                    CityName = "London",
                    DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
                    TemperatureFahrenheit = 33
                },
                new CityWeather(){
                    CityUniqueCode = "NYC", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60
                },
                new CityWeather(){CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
            };
            
            return View(cw.Where(c => c.CityUniqueCode.ToLower() == cityCode).First());
        }
    }
}
