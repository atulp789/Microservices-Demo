using Microsoft.AspNetCore.Mvc;

namespace EmployeeMicroService;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    public BaseApiController()
    {
    }
}
