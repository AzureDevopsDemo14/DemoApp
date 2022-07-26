using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private List<Employee> EmployeeList = new List<Employee>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var data = new List<Employee>().ToArray();

            EmployeeList.Add(new Employee
            {
                EmployeeId = 1,
                EmployeeNo = "001",
                FirstName = "Jason",
                MiddleName = "",
                LastName = "Gange"
            });

            EmployeeList.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeNo = "002",
                FirstName = "Jason2",
                MiddleName = "",
                LastName = "Gange2"
            });

            data = EmployeeList.ToArray();
            return data;
        }
    }
}   
