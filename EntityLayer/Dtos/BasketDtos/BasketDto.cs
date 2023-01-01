using EntityLayer.Abstract;
using EntityLayer.Concrete;

namespace EntityLayer.Dtos.BasketDtos
{
    public class BasketDto : DtoGetBase
    {
        public Basket Basket { get; set; }
    }
}
