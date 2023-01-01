using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketLogDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class OrderBasketLogProfile : Profile
    {
        public OrderBasketLogProfile()
        {
            CreateMap<OrderBasketLogAddDto, OrderBasketLog>();
        }
    }
}
