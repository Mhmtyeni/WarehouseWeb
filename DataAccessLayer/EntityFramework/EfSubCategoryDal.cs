using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfSubCategoryDal : EfGenericRepository<SubCategory>, ISubCategoryDal
    {
        public EfSubCategoryDal(DbContext _context) : base(_context)
        {
        }
    }
}