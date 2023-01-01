using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBasketDal : EfGenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(DbContext _context) : base(_context)
        {
        }
    }
}
