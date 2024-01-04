using Application_Layer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Layer.Dtos;
using AutoMapper;
using Application_Layer.Dtos.Auth;
using Core_Layer.Entities.Auth;

namespace Application_Layer.Mapping
{
    // Automapper configuration profile
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<RegisterDto, User>().ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username));
        }
    }
}
