using Application_Layer.Commands.Auth;
using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Utils;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Handlers.Auth
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, UserLoginResult>
    {
        private readonly IUserService _userService;
        public LoginUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserLoginResult> Handle(LoginUserCommand command, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            LoginDto loginDto = command.RegisterData;

            UserLoginResult loginResult = await _userService.LoginUserAsync(
                loginDto.Username,
                loginDto.Password
            );

            return loginResult;
        }
    }
}
