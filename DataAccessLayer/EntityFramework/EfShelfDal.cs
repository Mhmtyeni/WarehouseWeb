using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfShelfDal : EfGenericRepository<Shelf>, IShelfDal
    {
        public EfShelfDal(DbContext _context) : base(_context)
        {
        }
    }
}