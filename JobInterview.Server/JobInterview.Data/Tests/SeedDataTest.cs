using JobInterview.Data.DataServices;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace JobInterview.Data.Tests
{
    public class SeedDataTest
    {
        [Fact]
        public void SeedData_EmployeesList_Any_ShouldBeTrue()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<EmployeeDbContext>()
                .UseInMemoryDatabase("tests").Options;

            using var employeeDbContext = new EmployeeDbContext(options);
            employeeDbContext.Database.EnsureCreated();

            var sut = new EmployeesDataService(employeeDbContext);

            // Act
            var employees = sut.GetAllEmployees();

            // Assert
            Assert.True(employees.Any());
        }
    }
}
