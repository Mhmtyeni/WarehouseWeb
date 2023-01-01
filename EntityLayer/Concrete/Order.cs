using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Order : EntityBase, IEntity
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<OrderBasket> OrderBaskets { get; set; }
        public ICollection<OrderBasketLog> OrderBasketLogs { get; set; }

    }
}
