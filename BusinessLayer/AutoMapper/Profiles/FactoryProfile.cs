using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class FactoryProfile : Profile
    {
        public FactoryProfile()
        {
            CreateMap<FactoryAddDto, Factory>();
            CreateMap<FactoryUpdateDto, Factory>();
        }
    }
}
