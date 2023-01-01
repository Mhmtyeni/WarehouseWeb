using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Models
{
    public class NavBarViewModel
    {
        public AppUser AppUser { get; set; }
        public bool IsOrderExist { get; set; }
    }
}
