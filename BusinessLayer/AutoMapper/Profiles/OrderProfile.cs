using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderAddDto, Order>();
            CreateMap<OrderUpdateDto, Order>();
        }
    }
}
