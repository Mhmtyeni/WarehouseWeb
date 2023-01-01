using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfSubShelfDal : EfGenericRepository<SubShelf>, ISubShelfDal
    {
        public EfSubShelfDal(DbContext _context) : base(_context)
        {
        }
    }
}