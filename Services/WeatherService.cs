﻿using ASPNETCoreLearn2.Models;
using ServiceContracts;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        public CityWeather? GetWeatherByCityCode(string cityCode)
        {
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

            return cw.Where(c => c.CityUniqueCode.ToLower() == cityCode).First();
        }

        public List<CityWeather> GetWeatherDetails()
        {
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
            return cw;
        }
    }
}
