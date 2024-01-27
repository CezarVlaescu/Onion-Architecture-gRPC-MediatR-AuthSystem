using Application_Layer.Commands.Auth;
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
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, RoleAssignmentResult>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserCommandHandler(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        Task<RoleAssignmentResult> IRequestHandler<DeleteUserCommand, RoleAssignmentResult>.Handle(DeleteUserCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
