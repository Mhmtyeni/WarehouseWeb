using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ProductDtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Stock { get; set; }
        public int CriticalStock { get; set; }
        public float Price { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int SubShelfId { get; set; }
        public SubShelf SubShelf { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual string Note { get; set; }
    }
}
