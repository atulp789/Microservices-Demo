using Microsoft.AspNetCore.Mvc;

namespace EmployeeMicroService;

[ApiController]
[Route("api/[controller]/[action]")]
public class BaseApiController : ControllerBase
{
    public BaseApiController()
    {
    }
}
