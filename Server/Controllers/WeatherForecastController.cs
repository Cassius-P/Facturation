using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Facturations.Shared;

namespace Facturations.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();

            var data = Enumerable.Range(1, 30).Select(index => new WeatherForecast
            {
                DateE = RandomDayFunc(),
                MontantR = rng.Next(1500, 5500),
                Client = Summaries[rng.Next(Summaries.Length)],
                NumFacture = index
            }).ToArray();

            return data;
        }

        DateTime RandomDayFunc()
        {
            DateTime start = new DateTime(2019, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
