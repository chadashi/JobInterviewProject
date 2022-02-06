using JobInterview.Data.DataServices;
using JobInterview.Data.DataServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobInterview.Data
{
    public static class ServiceCollectionExtension
    {
        public static void AddDataLayerServicesCollection(this IServiceCollection service)
        {
            service.AddDbContext<EmployeeDbContext>(opt => opt.UseInMemoryDatabase("appData"));

            service.AddTransient<IEmployeesDataService, EmployeesDataService>();
        }
    }
}
