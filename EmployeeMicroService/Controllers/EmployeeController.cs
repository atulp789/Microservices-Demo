using EmployeeMicroService.Data;
using EmployeeMicroService.Entities;
using EmployeeMicroService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMicroService;

/// <summary>
/// Employee Controller
/// </summary>
/// <seealso cref="BaseApiController"/>
public class EmployeeController : BaseApiController
{
    /// <summary>
    /// ILogger of Employee controller
    /// </summary>
    private readonly ILogger<EmployeeController> _logger;

    /// <summary>
    /// IEmployeeRepository
    /// </summary>
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// EmployeeController
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="context"></param>
    public EmployeeController(ILogger<EmployeeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    [HttpGet] // api/Get
    public async Task<ActionResult<IEnumerable<Employee>>> Get()
    {
        var list = await _unitOfWork.EmployeeRepository.GetEmployeesAsync();
        return Ok(list);
    }

    [HttpGet("{id}")] // api/Get/1
    public async Task<ActionResult<Employee>> Get(int id)
    {
        var employee = await _unitOfWork.EmployeeRepository.GetEmployeesAsync(id);

        if (employee == null) return NotFound();

        return Ok(employee);
    }

    [HttpPost] // api/Post
    public async Task<ActionResult<string>> Post(Employee employee)
    {
        await _unitOfWork.EmployeeRepository.AddEmployeeAsync(employee);

        if (await _unitOfWork.Complete()) return Ok("Employee added suceefully!");

        return BadRequest("Failed to add employee!");
    }
}
