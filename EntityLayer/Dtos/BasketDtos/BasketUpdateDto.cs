using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.BasketDtos
{
    public class BasketUpdateDto
    {
        public int ProductId { get; set; }
        public int AppUserId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
