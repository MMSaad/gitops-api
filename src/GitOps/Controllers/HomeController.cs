using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitOps.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var version = await System.IO.File.ReadAllTextAsync("VERSION");
        return Ok(version);
    }

    //public async Task<IActionResult> Config()
    //{

    //}
}

