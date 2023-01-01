using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ProductDtos
{
    public class ProductDto : DtoGetBase
    {
        public Product Product { get; set; }
    }
}
