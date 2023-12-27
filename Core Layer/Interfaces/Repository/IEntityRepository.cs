using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Interfaces.Repository
{
    // Create your interface for entity repository, methods for Add, Remove, Update
    public interface IEntityRepository
    {
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<dynamic>> GetAllAsync();
        Task<Entity> AddAsync(Entity entity);

        // Other CRUD operations
    }

    /*public interface IRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }*/
}
