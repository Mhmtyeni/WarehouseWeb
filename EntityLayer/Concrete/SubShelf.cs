using SharedLayer.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SubShelf : EntityBase, IEntity
    {
        public int Number { get; set; }
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
