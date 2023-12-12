using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces
{
    // Create your interface for entity repository
    public interface IEntityRepository
    {
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<dynamic>> GetAllAsync();
        Task<Entity> AddAsync(Entity entity);

        // Other CRUD operations
    }
}
