using Auth0.ManagementApi.Models;
using Core_Layer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Services.Auth
{
    public interface IRoleService
    {
        Task<bool> CheckUserRoleAsync(User user, Role role);
        Task<IEnumerable<Roles>> GetUserRolesAsync(User user);
    }
}
