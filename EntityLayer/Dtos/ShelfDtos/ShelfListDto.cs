using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ShelfDtos
{
    public class ShelfListDto : DtoGetBase
    {
        public IList<Shelf> Shelves { get; set; }
    }
}
