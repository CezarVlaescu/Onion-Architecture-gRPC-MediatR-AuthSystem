using Application_Layer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Layer.Dtos;
using AutoMapper;

namespace Application_Layer.Mapping
{
    // Automapper configuration profile
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //CreateMap<Entity, EntityDto>();
            //CreateMap<CreateEntityCommand, Entity>();
        }
    }
}
