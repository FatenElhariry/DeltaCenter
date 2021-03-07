using DeltaCenter.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class HomeController : ControllerBase
    {
        private readonly IAppLogger<HomeController> _logger;
        private readonly ICurrentUserProvider _currentUserProvider;
        public HomeController(IAppLogger<HomeController> logger, ICurrentUserProvider currentUserProvider)
        {
            _logger = logger;
            _currentUserProvider = currentUserProvider;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Enter the get Action in Home controller");
            return Ok(_currentUserProvider.UserId);
        }
    }
}
