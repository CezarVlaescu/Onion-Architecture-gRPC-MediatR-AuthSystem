using Application_Layer.Commands.Auth;
using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Utils;
using Infrastructure_Layer.Repositories.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;


namespace WebAPI.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;

        private readonly IMediator _mediator;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IUserRepository userRepository ,IAuthService authService, IUserService userService, IRoleRepository roleRepository, IMediator mediator, ILogger<AuthController> logger)
        {
            _roleRepository = roleRepository;
            _authService = authService;
            _userService = userService;
            _userRepository = userRepository;
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterDto registerDto)
        {
            var result = await _userService.RegisterUserAsync(registerDto.Username, registerDto.Email, registerDto.Password, registerDto.Firstname, registerDto.Lastname);

            Console.WriteLine(result.Token);

            if (!result.Success)
            {
                return BadRequest(new { error = result.ErrorMessage });
            }
            return CreatedAtAction(nameof(_userService.GetUserAsync), new { id = result.User.Id }, new { user = result.User, token = result.Token });
        }

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] RoleAssignmentDto roleAssignmentDto)
        {
            var command = new RoleAssignmentCommand
            {
                UserId = roleAssignmentDto.UserId,
                Role = roleAssignmentDto.Role
            };

            var result = await _mediator.Send(command);

            if (result.Success) return Ok(new { message = "Role assigned successfully" });
            else return BadRequest(new { error = result.ErrorMessage });
        }

        // [HttpGet("login")]

    }
}
