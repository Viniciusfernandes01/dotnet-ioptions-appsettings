using IOptionsAppSettingsDotnet.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOptionsAppSettingsDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IOptions<ApiSettings> _apiSettings;

        public WeatherForecastController(IOptions<ApiSettings> apiSettings)
        {
            _apiSettings = apiSettings;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_apiSettings);
        }
    }
}
