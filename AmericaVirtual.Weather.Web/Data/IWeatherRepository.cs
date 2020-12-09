using AmericaVirtual.Weather.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Weather.Web.Data
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherForecast>> GetAsync(int id);
    }
}
