using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using Core_Layer.Utils;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Commands.Auth
{
    public class CreateUserCommand : IRequest<UserRegistrationResult>
    {
        public RegisterDto? RegisterData { get; set; } // represents a change in state of the system
    }
}
