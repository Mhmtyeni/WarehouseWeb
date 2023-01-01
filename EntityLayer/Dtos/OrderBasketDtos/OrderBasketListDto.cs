﻿using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.OrderBasketDtos
{
    public class OrderBasketListDto : DtoGetBase
    {
        public IList<OrderBasket> OrderBaskets { get; set; }
    }
}
