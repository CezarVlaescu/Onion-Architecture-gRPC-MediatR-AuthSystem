using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Infrastructure_Layer.Repositories.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Services.Auth
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public Task<User> RegisterUserAsync(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
