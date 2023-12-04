using Application_Layer.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Validators
{
    // fluentvalidation validator for create entity command
    public class CreateEntityCommandValidator : AbstractValidator<CreateEntityCommand>
    {
        public CreateEntityCommandValidator() 
        {
            RuleFor(command => command.FirstName).NotEmpty().WithMessage("First name is required");
            RuleFor(command => command.LastName).MaximumLength(12);
            // other rules
        }
    }
}
