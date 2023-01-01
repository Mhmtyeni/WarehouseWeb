using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ProductDtos
{
   public class ProductListDto : DtoGetBase
    {
        public IList<Product> Products { get; set; }
    }
}
