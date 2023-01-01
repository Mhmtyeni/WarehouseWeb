using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.BrandDtos
{
    public class BrandListDto:DtoGetBase
    {
        public IList<Brand> Brands { get; set; }

    }
}
