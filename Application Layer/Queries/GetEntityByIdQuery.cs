using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Dtos;

namespace Application_Layer.Queries
{
    // Implement the query to get the entity by ID
    public class GetEntityByIdQuery : IRequest<IEnumerable<EntityDto>>
    {

    }
}
