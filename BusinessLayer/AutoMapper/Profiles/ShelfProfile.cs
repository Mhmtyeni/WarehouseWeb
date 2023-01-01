using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ShelfDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ShelfProfile : Profile
    {
        public ShelfProfile()
        {
            CreateMap<ShelfAddDto, Shelf>();
            CreateMap<ShelfUpdateDto, Shelf>();
        }
    }
}
