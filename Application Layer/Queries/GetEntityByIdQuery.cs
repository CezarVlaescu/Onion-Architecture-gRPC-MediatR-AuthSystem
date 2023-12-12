using Application_Layer.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Queries
{
    // Implement the query to get the entity by ID
    public class GetEntityByIdQuery : IRequest<IEnumerable<EntityDto>>
    {

    }
}
