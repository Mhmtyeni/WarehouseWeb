using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfOrderBasketLogDal : EfGenericRepository<OrderBasketLog>, IOrderBasketLogDal
    {
        public EfOrderBasketLogDal(DbContext _context) : base(_context)
        {
        }
    }
}