using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductLog : EntityBase, IEntity
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } 
        public int FirstQuantity { get; set; }
        public int LastQuantity { get; set; }
    }
}
