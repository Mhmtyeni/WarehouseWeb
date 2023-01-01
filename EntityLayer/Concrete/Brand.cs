using SharedLayer.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Brand : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
