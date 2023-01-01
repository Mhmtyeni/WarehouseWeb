using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.UnitDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<UnitAddDto, Unit>();
            CreateMap<UnitUpdateDto, Unit>();
        }
    }
}
