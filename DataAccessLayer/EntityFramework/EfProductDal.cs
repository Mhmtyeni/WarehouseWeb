using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : EfGenericRepository<Product>, IProductDal
    {
        public EfProductDal(DbContext _context) : base(_context)
        {
        }
    }
}