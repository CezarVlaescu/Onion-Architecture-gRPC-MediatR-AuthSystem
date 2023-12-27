using Core_Layer.Entities;
using Core_Layer.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Services
{
    // Encapsulate the business logic, validations, CRUD model 
    public interface IEntityService
    {
        Task<Entity> CreateEntityAsync(string entityFirstName, string entityLastName);
        Task<Entity> GetEntityByIdAsync(int id);
    }

    /*public interface IUserService
    {
        Task<User> RegisterUserAsync(EntityDto registration);
        Task<bool> ValidateUserCredentialsAsync(string username, string password);
        // Other methods related to handling users that involve business logic
    }*/
}
