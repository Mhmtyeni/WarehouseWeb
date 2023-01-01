using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.OrderBasketDtos
{
    public class OrderBasketUpdateDto
    {
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
