using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ProductLogDtos
{
    public class ProductLogDto : DtoGetBase
    {
        public ProductLog ProductLog { get; set; }
    }
}
