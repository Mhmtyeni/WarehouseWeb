using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfOrderDal : EfGenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(DbContext _context) : base(_context)
        {
        }
    }
}