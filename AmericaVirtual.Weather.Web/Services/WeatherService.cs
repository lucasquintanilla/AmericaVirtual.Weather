using AmericaVirtual.Weather.Web.Data;
using AmericaVirtual.Weather.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Weather.Web.Services
{
    public class WeatherService
    {
        private IWeatherRepository _weatherRepository;
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<IEnumerable<WeatherForecast>> GetNext5DaysWeather()
        {
            List<WeatherForecast> weather = new List<WeatherForecast>();

            weather.Add(new WeatherForecast { Date = DateTime.Now, TemperatureC = 30, Summary = "Lunes" });
            weather.Add(new WeatherForecast { Date = DateTime.Now, TemperatureC = 30, Summary = "Martes" });
            weather.Add(new WeatherForecast { Date = DateTime.Now, TemperatureC = 30, Summary = "Miercoles" });
            weather.Add(new WeatherForecast { Date = DateTime.Now, TemperatureC = 30, Summary = "Jueves" });
            weather.Add(new WeatherForecast { Date = DateTime.Now, TemperatureC = 30, Summary = "Viernes" });

            //await _weatherRepository.GetAsync(5);
            return weather;
        }
    }
}
