using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.SubShelfDtos
{
    public class SubShelfListDto : DtoGetBase
    {
        public IList<SubShelf> SubShelves { get; set; }
    }
}
