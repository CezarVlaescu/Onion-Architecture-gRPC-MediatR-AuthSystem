using Auth0.ManagementApi.Models;
using Core_Layer.Interfaces.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Services.Auth
{
    public class AuthService : IAuthService
    {
        public Task<string> GenerateJwtToken(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUserCredentialAsync(string username, string password, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
