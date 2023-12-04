using Core_Layer.Entities;
using Core_Layer.Interfaces;
using Infrastructure_Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure_Layer.Repositories
{
    // Implementation of IEntityRepository
    public class EntityRepository : IEntityRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public EntityRepository(ApplicationDbContext applicationDbContext)
        {
            _dbcontext = applicationDbContext;
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            _dbcontext.EntityContext.Add(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            return (IEnumerable<T>) await _dbcontext.EntityContext.ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(Guid id) => await _dbcontext.EntityContext.FindAsync(id);
    }
}
