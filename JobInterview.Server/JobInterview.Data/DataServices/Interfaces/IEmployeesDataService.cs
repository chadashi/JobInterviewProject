using System.Collections.Generic;

namespace JobInterview.Data.DataServices.Interfaces
{
    public interface IEmployeesDataService
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
