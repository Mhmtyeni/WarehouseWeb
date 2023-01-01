using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.UnitDtos
{
    public class UnitDto: DtoGetBase
    {
        public Unit Unit { get; set; }
    }
}
