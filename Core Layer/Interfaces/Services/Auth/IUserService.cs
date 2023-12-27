using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Services.Auth
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(RegisterDto registerDto, CancellationToken cancellationToken);
        Task<User> GetUserAsync(string username);
    }
}
