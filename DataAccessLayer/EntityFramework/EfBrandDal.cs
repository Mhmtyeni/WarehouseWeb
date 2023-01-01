using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBrandDal : EfGenericRepository<Brand>, IBrandDal
    {
        public EfBrandDal(DbContext _context) : base(_context)
        {
        }
    }
}