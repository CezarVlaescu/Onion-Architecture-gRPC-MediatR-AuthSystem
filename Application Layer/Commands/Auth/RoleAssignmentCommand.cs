using Application_Layer.Dtos.Auth;
using Core_Layer.Utils;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Commands.Auth
{
    public class RoleAssignmentCommand : IRequest<RoleAssignmentResult>
    {
        public int UserId { get; set; }
        public string Role { get; set; }
    }
}
