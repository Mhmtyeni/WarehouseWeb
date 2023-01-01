using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubShelfDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class SubShelfProfile : Profile
    {
        public SubShelfProfile()
        {
            CreateMap<SubShelfAddDto, SubShelf>();
            CreateMap<SubShelfUpdateDto, SubShelf>();
        }
    }
}
