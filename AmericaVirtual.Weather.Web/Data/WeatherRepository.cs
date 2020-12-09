using AmericaVirtual.Weather.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Weather.Web.Data
{    
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _db;
        public WeatherRepository(WeatherContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAsync(int id)
        {
            return await _db.Weather.Where(weather => weather.TemperatureC == 20).ToListAsync();
        }
    }
}
