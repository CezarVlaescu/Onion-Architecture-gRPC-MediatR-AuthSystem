using Core_Layer.Entities.Auth;
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
        Task<bool> CheckUserRoleAsync(User user, Roles role);
        Task<Roles> GetUserRoleAsync(User user);
    }
}
