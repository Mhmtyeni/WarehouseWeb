using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUnitDal : EfGenericRepository<Unit>, IUnitDal
    {
        public EfUnitDal(DbContext _context) : base(_context)
        {
        }
    }
}
