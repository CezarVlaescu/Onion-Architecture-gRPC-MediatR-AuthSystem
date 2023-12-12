using Application_Layer.Dtos;
using Application_Layer.Queries;
using AutoMapper;
using Core_Layer.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Handlers
{
    public class GetEntityByQueryHandler : IRequestHandler<GetEntityByIdQuery, IEnumerable<EntityDto>>
    {
        private readonly IEntityRepository _entityRepository;
        private IMapper _mapper;

        public GetEntityByQueryHandler(IEntityRepository entityRepository, IMapper mapper) 
        {
            _entityRepository = entityRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EntityDto>> Handle(GetEntityByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _entityRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EntityDto>>(entity);
        }
    }
}
