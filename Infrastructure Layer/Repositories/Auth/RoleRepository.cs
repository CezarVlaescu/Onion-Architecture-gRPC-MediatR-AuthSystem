using Auth0.ManagementApi.Models;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repositories.Auth
{
    public class RoleRepository : IRoleRepository
    {
        public Task AssignRoleToUserAsync(User user, Roles role)
        {
            throw new NotImplementedException();
        }

        public Task<Roles> GetRoleByNameAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task UnassignRoleFromUserAsync(User user, Roles role)
        {
            throw new NotImplementedException();
        }
    }
}
