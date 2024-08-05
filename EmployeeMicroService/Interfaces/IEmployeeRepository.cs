using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMicroService.Entities;

namespace EmployeeMicroService.Interfaces
{
    /// <summary>
    /// IEmployeeRepository
    /// </summary>
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeesAsync(int id);
        Task AddEmployeeAsync(Employee employee);
    }
}