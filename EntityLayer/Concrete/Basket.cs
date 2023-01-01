using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Basket
    {
        [Key]
        [Column(Order = 1)]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
