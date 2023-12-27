using Auth0.ManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Services.Auth
{
    public interface IAuthService
    {
        Task<string> GenerateJwtToken(User user, CancellationToken cancellationToken);
        Task<bool> ValidateUserCredentialAsync(string username, string password, CancellationToken cancellationToken);
    }
}
