using Core_Layer.Entities.Auth;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Utils;
using Infrastructure_Layer.Repositories.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Services.Auth
{
    public class RoleService : IRoleService
    {
        private readonly IUserRepository _userRepository;
        public RoleService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public async Task<bool> CheckUserRoleAsync(User user, Roles role)
        {
            var foundUser = await _userRepository.GetByUsernameAsync(user.Username);

            if(foundUser.Role == null || foundUser == null)
            {
                return false;
            }

            return foundUser.Role == role;
        }

        public async Task<Roles> GetUserRoleAsync(User user)
        {
            var foundUser = await _userRepository.GetByUsernameAsync(user.Username);

            if (foundUser == null)
            {
                throw new KeyNotFoundException($"User with username '{user.Username}' not found.");
            }

            if (foundUser.Role == null)
            {
                throw new InvalidOperationException("User does not have a role assigned.");
            }

            return foundUser.Role;

        }
    }
}
