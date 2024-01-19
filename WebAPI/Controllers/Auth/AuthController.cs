using Application_Layer.Dtos.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace WebAPI.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, IUserService userService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterDto registerDto)
        {
            var result = await _userService.RegisterUserAsync(registerDto.Username, registerDto.Email, registerDto.Password, registerDto.Firstname, registerDto.Lastname);

            if (!result.Success)
            {
                return BadRequest(new { error = result.ErrorMessage });
            }

            // Adjust the response as needed. You might want to include the token in the response.
            return CreatedAtAction(nameof(_userService.GetUserAsync), new { id = result.User.Id }, new { user = result.User, token = result.Token });
        }
    }
}
