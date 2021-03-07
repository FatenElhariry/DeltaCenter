using DeltaCenter.Core.Interfaces;
using DeltaCenter.Infrastructure.Dtos;
using DeltaCenter.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenClaimsService _tokenClaimsService;
        private readonly IAppLogger<AuthController> _logger;
        public AuthController(SignInManager<ApplicationUser> signInManager,
            ITokenClaimsService tokenClaimsService, 
            IAppLogger<AuthController> logger,
            UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenClaimsService = tokenClaimsService;
            _logger = logger;
            _logger.LogInformation("AuthController Lodded ");
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Authenticates a user",
            Description = "Authenticates a user",
            OperationId = "auth.authenticate",
            Tags = new[] { "AuthEndpoints" })
        ]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            // var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
            // var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false, true);
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user != null && ! await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return Unauthorized();
            string Token = await _tokenClaimsService.GetTokenAsync(loginDto.UserName);
            return Ok( new { Token, User = user });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            _logger.LogInformation($"User {User.Identity.Name}");
            await _signInManager.SignOutAsync();
            return Ok();
        }

    }
}
