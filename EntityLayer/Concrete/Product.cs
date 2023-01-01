using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Product : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Stock { get; set; }
        public int CriticalStock { get; set; }
        public float Price { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int SubShelfId { get; set; }
        public SubShelf SubShelf { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public ICollection<OrderBasket> OrderBaskets { get; set; }
        public ICollection<OrderBasketLog> OrderBasketLogs { get; set; }
        public ICollection<ProductLog> ProductLogs { get; set; }

    }
}
