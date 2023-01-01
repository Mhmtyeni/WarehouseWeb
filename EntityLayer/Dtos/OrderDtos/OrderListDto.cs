using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.OrderDtos
{
    public class OrderListDto : DtoGetBase
    {
        public IList<Order> Orders { get; set; }
    }
}
