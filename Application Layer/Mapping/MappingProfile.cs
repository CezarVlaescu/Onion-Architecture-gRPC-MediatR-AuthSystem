using Application_Layer.Commands;
using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Dtos;
using AutoMapper;

namespace Application_Layer.Mapping
{
    // Automapper configuration profile
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Entity, EntityDto>();
            CreateMap<CreateEntityCommand, Entity>();
        }
    }
}
