using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

namespace DataAccessLayer.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private EfBasketDal _basketDal;
        private EfOrderBasketDal _orderBasketDal;
        private EfBrandDal _brandDal;
        private EfCategoryDal _categoryDal;
        private EfCurrencyDal _currencyDal;
        private EfOrderDal _orderDal;
        private EfOrderBasketLogDal _orderBasketLogDal;
        private EfProductDal _productDal;
        private EfShelfDal _shelfDal;
        private EfSubCategoryDal _subCategoryDal;
        private EfSubShelfDal _subShelfDal;
        private EfProductLogDal _productLogDal;
        private EfUnitDal _unitDal;
        private EfFactoryDal _factoryDal;
        private EfProjectDal _projectDal;
        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IBasketDal Basket => _basketDal ?? new EfBasketDal(_context);
        public IOrderBasketDal OrderBasket => _orderBasketDal ?? new EfOrderBasketDal(_context);

        public IBrandDal Brand => _brandDal ?? new EfBrandDal(_context);

        public ICategoryDal Category => _categoryDal ?? new EfCategoryDal(_context);

        public ICurrencyDal Currency => _currencyDal ?? new EfCurrencyDal(_context);

        public IOrderDal Order => _orderDal ?? new EfOrderDal(_context);

        public IOrderBasketLogDal OrderBasketLog => _orderBasketLogDal ?? new EfOrderBasketLogDal(_context);

        public IProductDal Product => _productDal ?? new EfProductDal(_context);

        public IShelfDal Shelf => _shelfDal ?? new EfShelfDal(_context);

        public ISubCategoryDal SubCategory => _subCategoryDal ?? new EfSubCategoryDal(_context);

        public ISubShelfDal SubShelf => _subShelfDal ?? new EfSubShelfDal(_context);
        public IUnitDal Unit => _unitDal ?? new EfUnitDal(_context);
        public IProductLogDal ProductLog => _productLogDal ?? new EfProductLogDal(_context);

        public IFactoryDal Factory => _factoryDal ?? new EfFactoryDal(_context);

        public IProjectDal Project => _projectDal ?? new EfProjectDal(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
