using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductLogDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProductLogProfile : Profile
    {
        public ProductLogProfile()
        {
            CreateMap<ProductLogAddDto, ProductLog>();
            CreateMap<ProductLogUpdateDto, ProductLog>();

        }
    }
}
