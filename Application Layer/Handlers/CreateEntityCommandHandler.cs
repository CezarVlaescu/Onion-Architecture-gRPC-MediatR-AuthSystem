using Application_Layer.Commands;
using Core_Layer.Entities;
using Core_Layer.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Dtos;

namespace Application_Layer.Handlers
{
    // Handler for command
    public class CreateEntityCommandHandler : IRequestHandler<CreateEntityCommand, EntityDto>
    {
        // Inject services or reposs as needed

        private readonly IEntityRepository _entityRepository;

        public CreateEntityCommandHandler(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task<EntityDto> Handle(CreateEntityCommand request, CancellationToken cancellationToken)
        {
            // your logic here

            var entity = new Entity
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
            };

            await _entityRepository.AddAsync(entity);

            return new EntityDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,

            };
        }
    }
}
