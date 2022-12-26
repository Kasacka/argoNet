using Microsoft.AspNetCore.Mvc;

namespace argoNet.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet]
    public decimal Get() =>
        1.1m;
}
