using AutoMapper;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(UserManager<AppUser> userManager, IMapper mapper)
        {
            UserManager = userManager;
            Mapper = mapper;
        }

        protected UserManager<AppUser> UserManager { get; }
        protected IMapper Mapper { get; }
        protected AppUser LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;
    }
}
