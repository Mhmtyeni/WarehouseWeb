using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfCurrencyDal : EfGenericRepository<Currency>, ICurrencyDal
    {
        public EfCurrencyDal(DbContext _context) : base(_context)
        {
        }
    }
}