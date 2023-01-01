using EntityLayer.Concrete;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Dtos.BasketDtos
{
    public class BasketAddDto
    {
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
