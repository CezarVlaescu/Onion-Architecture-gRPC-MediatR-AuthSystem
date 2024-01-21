using Application_Layer.Commands.Auth;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Utils;
using Infrastructure_Layer.Repositories.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Handlers.Auth
{
    public class RoleAssignmentCommandHandler : IRequestHandler<RoleAssignmentCommand, RoleAssignmentResult>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        public RoleAssignmentCommandHandler(IRoleRepository roleService, IUserRepository userRepository) 
        {
            _roleRepository = roleService;
            _userRepository = userRepository;
        }

        public async Task<RoleAssignmentResult> Handle(RoleAssignmentCommand command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(command.UserId);

            if (user == null) return new RoleAssignmentResult
            {
                Success = false,
                ErrorMessage = "User not found"
            };

            if (!Enum.TryParse<Roles>(command.Role, out var roleEnum)) return new RoleAssignmentResult
            {
                Success = false,
                ErrorMessage = "Invalid role specified"
            };

            bool assigned = await _roleRepository.AssignRoleToUserAsync(user, roleEnum);

            return new RoleAssignmentResult
            {
                Success = assigned,
                ErrorMessage = assigned ? null : "Role assignment failed"
            };
        }
    }
}
