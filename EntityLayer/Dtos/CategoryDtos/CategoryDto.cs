using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.CategoryDtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
