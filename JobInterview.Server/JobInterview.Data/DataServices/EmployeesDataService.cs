using JobInterview.Data.DataServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace JobInterview.Data.DataServices
{
    internal class EmployeesDataService : IEmployeesDataService
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeesDataService(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
            _employeeDbContext.Database.EnsureCreated();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }
    }
}
