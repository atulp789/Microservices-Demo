
namespace EmployeeMicroService.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Complete();
        bool HasChanges();
        IEmployeeRepository EmployeeRepository { get; }
        IAccountRepository AccountRepository { get; }
    }
}