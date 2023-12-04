using Core_Layer.Entities;
using Core_Layer.Exceptions;
using Core_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Services
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _entityRepository;

        public EntityService(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public async Task<Entity> CreateEntityAsync(string entityFirstName, string entityLastName)
        {
            var entity = new Entity
            {
                FirstName = entityFirstName,
                LastName = entityLastName
            };

            return await _entityRepository.AddAsync(entity);
        }

        public async Task<Entity> GetEntityByIdAsync(Guid id)
        {
            var entity = await _entityRepository.GetByIdAsync(id);

            return entity == null ? throw new NotFoundException(nameof(Entity), id) : entity;
        }


    }
}
