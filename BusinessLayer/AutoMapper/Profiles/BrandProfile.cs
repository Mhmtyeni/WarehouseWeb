using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandAddDto, Brand>();
            CreateMap<BrandUpdateDto, Brand>();
        }
    }
}
