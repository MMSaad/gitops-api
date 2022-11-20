using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitOps.Api.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public async Task<IActionResult> Index()
        {

        }

        public async Task<IActionResult> Config()
        {

        }
    }

