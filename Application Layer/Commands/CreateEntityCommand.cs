using Application_Layer.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Commands
{
    // A command to create a new Entity
    public class CreateEntityCommand : IRequest<EntityDto>
    {
        // Prop needed to create your entity ( id, pass, cnp for create a user for exemple )

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // other prop needed to create what you want
    }
}
