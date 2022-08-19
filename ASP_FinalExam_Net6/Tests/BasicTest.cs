using Microsoft.EntityFrameworkCore;
using ASP_FinalExam_Net6.Data;
using ASP_FinalExam_Net6.Models;

namespace ASP_FinalExam_Net6.Tests
{
    public class BasicTest
    {
        protected readonly DbContextOptions<ApplicationDbContext> _opts;

        public BasicTest()
        {
            _opts = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "ASP_FinalExam_Net6").Options;
        }

        protected List<Employee> MakeFakeEmployees(int i)
        {
            var employees = new List<Employee>();

            for (int j = 0; j < i; j++)
            {
                employees.Add(new Employee
                {
                    Id = j + 1,
                    Name = $"testTable{j + 2}",
                    IsManager = true,
                });
            }
            return employees;
        }
    }
}
