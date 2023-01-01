using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.FactoryDtos
{
    public class FactoryDto : DtoGetBase
    {
        public Factory Factory { get; set; }
    }
}
