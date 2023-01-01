using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Models
{
    public class HomeIndexViewModel
    {
        public int WarehouseOccupancy { get; set; }
        public int TotalOrders { get; set; }
        public int TotalProducts { get; set; }
        public float TotalWarehouseValue { get; set; }
        public string[] FirstName = new string[10];
        public string[] LastName = new string[10];
        public string[] Note = new string[10];
        public string[] Date = new string[10];
        public int[] Id = new int[10];
        public string[] Order = new string[1];
        public int[] OrderSayac = new int[1];
        
    }
}

