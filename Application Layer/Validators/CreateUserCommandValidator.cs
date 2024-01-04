using Application_Layer.Commands.Auth;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator() 
        {
            RuleFor(x => x.RegisterData.Username).NotEmpty();
            RuleFor(x => x.RegisterData.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.RegisterData.Password).NotEmpty().MinimumLength(6);
        }
    }
}
