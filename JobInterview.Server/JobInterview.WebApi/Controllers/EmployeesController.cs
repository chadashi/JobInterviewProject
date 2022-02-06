using JobInterview.Data;
using JobInterview.Data.DataServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace JobInterview.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeesDataService _employeesDataService;

        public EmployeesController(
            ILogger<EmployeesController> logger,
            IEmployeesDataService employeesDataService)
        {
            _logger = logger;
            _employeesDataService = employeesDataService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            _logger.LogInformation("Get all employees method was called.");
            return _employeesDataService.GetAllEmployees();
        }
    }
}
