using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IBasketDal Basket { get; }
        IBrandDal Brand { get; }
        ICategoryDal Category { get; }
        ICurrencyDal Currency { get; }
        IOrderDal Order { get; }
        IOrderBasketLogDal OrderBasketLog { get; }
        IProductDal Product { get; }
        IShelfDal Shelf { get; }
        ISubCategoryDal SubCategory { get; }
        ISubShelfDal SubShelf { get; }
        IOrderBasketDal OrderBasket { get; }
        IProductLogDal ProductLog { get; }
        IUnitDal Unit { get; }
        IFactoryDal Factory { get; }
        IProjectDal Project { get; }
        
        Task<int> SaveAsync();
    }
}
