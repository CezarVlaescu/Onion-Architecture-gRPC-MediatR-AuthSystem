using Core_Layer.Entities.Auth;
using Infrastructure_Layer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repositories.Auth
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<User> AddAsync(User user)
        {
            var addUser = new User
            {
                CreatedAt = DateTime.UtcNow,
                Username = user.Username,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt,
            };

            _dbContext.Users.Add(addUser);
            await _dbContext.SaveChangesAsync();
            return addUser;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);

            if(user == null)
            {
                throw new KeyNotFoundException("User with ID not found");
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetByIdAsync(int id) =>
            await _dbContext.Users.FindAsync(id) ?? throw new KeyNotFoundException("User not found");


        public async Task<User> GetByUsernameAsync(string username) =>
            await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);

        public async Task UpdateAsync(User user)
        {
            var existingUser = await _dbContext.Users.FindAsync(user.Id);
            if (existingUser != null)
            {
                throw new KeyNotFoundException($"{user.Username} not found");
            }

            existingUser.Username = user.Username;
            existingUser.Email = user.Email;
            existingUser.PasswordHash = user.PasswordHash;
            existingUser.PasswordSalt = user.PasswordSalt;
            existingUser.Role = user.Role;

            _dbContext.Users.Update(existingUser);

            await _dbContext.SaveChangesAsync();
        }
    }
}
