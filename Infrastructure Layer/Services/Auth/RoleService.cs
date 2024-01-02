using Auth0.ManagementApi.Models;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Services.Auth
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository) 
        {
            _roleRepository = roleRepository;
        }
        public Task<bool> CheckUserRoleAsync(User user, Role role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Roles>> GetUserRolesAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
