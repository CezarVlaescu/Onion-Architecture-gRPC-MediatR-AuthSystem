using Auth0.ManagementApi.Models;
using Core_Layer.Interfaces.Repository.Auth;
using Core_Layer.Utils;
using Infrastructure_Layer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repositories.Auth
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RoleRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext; // TO DO : throw an exception 
        }
        public async Task AssignRoleToUserAsync(User user, Roles role)
        {
            var userEntity = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email) ?? throw new Exception("User not found");
            userEntity.Role = role;
            await _dbContext.SaveChangesAsync();
        }

        public Task<Roles> GetRoleByNameAsync(string roleName) => 
            Enum.TryParse(roleName, out Roles result) ? Task.FromResult(result) : throw new ArgumentException("Invalid role name");

        public async Task UnassignRoleFromUserAsync(User user, Roles role)
        {
            var userEntity = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email) ?? throw new Exception("User not found");
            userEntity.Role = Roles.Empty;
            await _dbContext.SaveChangesAsync();
        }
    }
}
