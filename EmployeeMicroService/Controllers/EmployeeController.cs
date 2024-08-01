using EmployeeMicroService.Data;
using EmployeeMicroService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMicroService;

/// <summary>
/// Employee Controller
/// </summary>
public class EmployeeController : BaseApiController
{
    /// <summary>
    /// 
    /// </summary>
    private readonly ILogger<EmployeeController> _logger;

    /// <summary>
    /// 
    /// </summary>
    private readonly DataContext _context;

    /// <summary>
    /// EmployeeController
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="context"></param>
    public EmployeeController(ILogger<EmployeeController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet] // api/GetEmployees
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        var list = await _context.Employees.ToListAsync();
        return list;
    }

    [HttpGet("{id:int}")] // api/GetEmployee/1
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _context.Employees.FindAsync(id);

        if (employee == null) return NotFound();

        return employee;
    }
}
