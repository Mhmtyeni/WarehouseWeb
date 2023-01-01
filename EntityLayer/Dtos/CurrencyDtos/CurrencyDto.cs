using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.CurrencyDtos
{
    public class CurrencyDto : DtoGetBase
    {
        public Currency Currency { get; set; }
    }
}
