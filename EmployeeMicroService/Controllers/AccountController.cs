using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMicroService.Interfaces;

namespace EmployeeMicroService.Controllers
{
    /// <summary>
    /// Account Controller
    /// </summary>
    /// <seealso cref="BaseApiController"/>
    public class AccountController : BaseApiController
    {
        /// <summary>
        /// ILogger of Employee controller
        /// </summary>
        private readonly ILogger<AccountController> _logger;

        /// <summary>
        /// IEmployeeRepository
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// EmployeeController
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="context"></param>
        public AccountController(ILogger<AccountController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
    }
}