using ASPNETCoreLearn2.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Microsoft.VisualBasic;

namespace ASPNETCoreLearn2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;
        public HomeController(IWeatherService weatherService) 
        {
            _weatherService = weatherService;
        }
        [Route("/")]
        [Route("/Weather")]
        public IActionResult Index()
        {
            List<CityWeather> cw = _weatherService.GetWeatherDetails();
            return View(cw);
        }
    }
}
