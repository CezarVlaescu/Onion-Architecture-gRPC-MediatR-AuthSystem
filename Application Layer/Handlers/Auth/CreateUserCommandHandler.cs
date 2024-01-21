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
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserRegistrationResult>
    {
        private readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService) 
        {
            _userService = userService;
        }

        public async Task<UserRegistrationResult> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();   

            RegisterDto registerDto = command.RegisterData;

            UserRegistrationResult registrationResult = await _userService.RegisterUserAsync(
                registerDto.Username,
                registerDto.Email,
                registerDto.Password,
                registerDto.Firstname,
                registerDto.Lastname
            );

            return registrationResult;
        }
    }
}
