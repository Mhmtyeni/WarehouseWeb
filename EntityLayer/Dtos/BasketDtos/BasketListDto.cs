using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.BasketDtos
{
    public class BasketListDto : DtoGetBase
    {
        public IList<Basket> Baskets { get; set; }
    }
}
