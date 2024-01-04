using Core_Layer.Entities.Auth;
using Core_Layer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Repository.Auth
{
    public interface IRoleRepository
    {
        Task<Roles> GetRoleByNameAsync(string roleName);
        Task AssignRoleToUserAsync(User user, Roles role);
        Task UnassignRoleFromUserAsync(User user, Roles role);
    }
}
