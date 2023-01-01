using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using EntityLayer.Dtos.BasketDtos;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketAddDto, Basket>();
            CreateMap<BasketUpdateDto, Basket>();
        }
    }
}
