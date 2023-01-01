using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : EfGenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(DbContext _context) : base(_context)
        {
        }
    }
}