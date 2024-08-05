
using EmployeeMicroService.Interfaces;

namespace EmployeeMicroService.Data
{
    /// <summary>
    /// Account Repository
    /// </summary>
    public class AccountRepository(DataContext context) : IAccountRepository
    {
        private readonly DataContext _context = context;
    }
}