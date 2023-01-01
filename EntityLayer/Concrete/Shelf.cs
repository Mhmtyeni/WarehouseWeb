using SharedLayer.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Shelf : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<SubShelf> SubShelves { get; set; }
    }
}
