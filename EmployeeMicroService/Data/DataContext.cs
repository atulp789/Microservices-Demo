using EmployeeMicroService.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMicroService.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
    }
}