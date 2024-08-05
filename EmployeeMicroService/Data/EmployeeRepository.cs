using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMicroService.Entities;
using EmployeeMicroService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMicroService.Data
{
    /// <summary>
    /// Employee Repository
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Employees Async method
        /// </summary>
        /// <returns>List of employee</returns>
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        /// <summary>
        /// Get Employees by id Async method
        /// </summary>
        /// <returns>Employee</returns>
        public async Task<Employee> GetEmployeesAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        /// <summary>
        /// Add Employee method
        /// </summary>
        /// <returns>void</returns>
        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }
    }
}