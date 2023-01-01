using SharedLayer.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
