using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Core_Layer.Interfaces.Utils;
using Core_Layer.Utils;
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
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAuthService _authService;
        public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher, IAuthService authService) 
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _authService = authService;
        }

        public async Task<User> GetUserAsync(string username) => await _userRepository.GetByUsernameAsync(username);

        public async Task<UserRegistrationResult> RegisterUserAsync(string username, string email, string password, string firstname, string lastname)
        {
            var existingUser = await _userRepository.GetByUsernameAsync(username);

            if (existingUser != null) return new UserRegistrationResult { Success = false, ErrorMessage = "User already exists" };

            byte[] passwordHash, passwordSalt;
            _passwordHasher.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var newUser = new User
            {
                Username = username,
                Email = email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            await _userRepository.AddAsync(newUser);

            string token = await _authService.GenerateJwtToken(newUser, CancellationToken.None);

            return new UserRegistrationResult
            {
                Success = true,
                User = newUser, 
                Token = token
            };

        }
    }
}
