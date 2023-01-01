using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CurrencyDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyAddDto, Currency>();
            CreateMap<CurrencyUpdateDto, Currency>();
        }
    }
}
