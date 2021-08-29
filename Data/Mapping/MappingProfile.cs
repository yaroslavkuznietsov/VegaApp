using AutoMapper;
using Data.Models;
using Data.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Source -> Target
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}
