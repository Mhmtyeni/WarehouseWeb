using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Unit : EntityBase, IEntity
    {
        public string Name { get; set; }
        ICollection<Product> Products { get; set; }  
    }
}
