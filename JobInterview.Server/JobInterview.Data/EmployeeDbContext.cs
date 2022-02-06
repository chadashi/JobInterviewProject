using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JobInterview.Data
{
    internal class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Employee>().HasData(SeedData());
        }

        private static List<Employee> SeedData()
        {
            string jsonData = @"[
    {
        'id': 1,
        'name': 'Tiger Nixon',
        'salary': 320800,
        'age': 61,
        'department': 'Manager'
    },
    {
        'id': 2,
        'name': 'Garrett Winters',
        'salary': 170750,
        'age': 63,
        'department': 'Manager'
    },
    {
        'id': 3,
        'name': 'Ashton Cox',
        'salary': 86000,
        'age': 66,
        'department': 'Manager'
    },
    {
        'id': 4,
        'name': 'Cedric Kelly',
        'salary': 433060,
        'age': 22,
        'department': 'Programmer'
    },
    {
        'id': 5,
        'name': 'Airi Satou',
        'salary': 162700,
        'age': 33,
        'department': 'Team Leader'
    },
    {
        'id': 6,
        'name': 'Brielle Williamson',
        'salary': 372000,
        'age': 61,
        'department': 'Team Leader'
    },
    {
        'id': 7,
        'name': 'Herrod Chandler',
        'salary': 137500,
        'age': 59,
        'department': 'Team Leader'
    },
    {
        'id': 8,
        'name': 'Rhona Davidson',
        'salary': 327900,
        'age': 55,
        'department': 'Team Leader'
    },
    {
        'id': 9,
        'name': 'Colleen Hurst',
        'salary': 205500,
        'age': 39,
        'department': 'Programmer'
    },
    {
        'id': 10,
        'name': 'Sonya Frost',
        'salary': 103600,
        'age': 23,
        'department': 'Programmer'
    },
    {
        'id': 11,
        'name': 'Jena Gaines',
        'salary': 90560,
        'age': 30,
        'department': 'Programmer'
    },
    {
        'id': 12,
        'name': 'Quinn Flynn',
        'salary': 342000,
        'age': 22,
        'department': 'Programmer'
    },
    {
        'id': 13,
        'name': 'Charde Marshall',
        'salary': 470600,
        'age': 36,
        'department': 'Programmer'
    },
    {
        'id': 14,
        'name': 'Haley Kennedy',
        'salary': 313500,
        'age': 43,
        'department': 'Programmer'
    },
    {
        'id': 15,
        'name': 'Tatyana Fitzpatrick',
        'salary': 385750,
        'age': 19,
        'department': 'Programmer'
    },
    {
        'id': 16,
        'name': 'Michael Silva',
        'salary': 198500,
        'age': 66,
        'department': 'Manager'
    },
    {
        'id': 17,
        'name': 'Paul Byrd',
        'salary': 725000,
        'age': 64,
        'department': 'Team Leader'
    },
    {
        'id': 18,
        'name': 'Gloria Little',
        'salary': 237500,
        'age': 59,
        'department': 'Team Leader'
    },
    {
        'id': 19,
        'name': 'Bradley Greer',
        'salary': 132000,
        'age': 41,
        'department': 'Programmer'
    },
    {
        'id': 20,
        'name': 'Dai Rios',
        'salary': 217500,
        'age': 35,
        'department': 'Programmer'
    },
    {
        'id': 21,
        'name': 'Jenette Caldwell',
        'salary': 345000,
        'age': 30,
        'department': 'Programmer'
    },
    {
        'id': 22,
        'name': 'Yuri Berry',
        'salary': 675000,
        'age': 40,
        'department': 'Programmer'
    },
    {
        'id': 23,
        'name': 'Caesar Vance',
        'salary': 106450,
        'age': 21,
        'department': 'Programmer'
    },
    {
        'id': 24,
        'name': 'Doris Wilder',
        'salary': 85600,
        'age': 23,
        'department': 'Programmer'
    }
]".Replace("'", "\"");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new JsonStringEnumConverter());

            var employees = JsonSerializer
                .Deserialize<List<Employee>>(jsonData, options)
                .ToList();

            return employees;
        }
    }
}
