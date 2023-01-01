using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class OrderBasketProfile : Profile
    {
        public OrderBasketProfile()
        {
            CreateMap<OrderBasketAddDto, OrderBasket>();
            CreateMap<OrderBasketUpdateDto, OrderBasket>();
        }
    }
}
