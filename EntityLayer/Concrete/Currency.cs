using SharedLayer.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Currency : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
