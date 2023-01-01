using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class SubCategoryProfile : Profile
    {
        public SubCategoryProfile()
        {
            CreateMap<SubCategoryAddDto, SubCategory>();
            CreateMap<SubCategoryUpdateDto, SubCategory>();
        }
    }
}
