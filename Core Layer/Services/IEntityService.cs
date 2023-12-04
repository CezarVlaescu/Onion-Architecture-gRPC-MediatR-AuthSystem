using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Services
{
    public interface IEntityService
    {
        Task<Entity> CreateEntityAsync(string entityFirstName, string entityLastName);
        Task<Entity> GetEntityByIdAsync(int id);
    }
}
