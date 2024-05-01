using ASPNETCoreLearn2.Models;
namespace ServiceContracts
{
    public interface IWeatherService
    {
        public List<CityWeather> GetWeatherDetails();
        public CityWeather? GetWeatherByCityCode(string cityCode);
    }
}
