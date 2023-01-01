using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class OrderBasketController : BaseController
    {
        private readonly IOrderBasketService _orderBasketManager;
        public OrderBasketController(UserManager<AppUser> userManager, IMapper mapper, IOrderBasketService orderBasketManager) : base(userManager, mapper)
        {
            _orderBasketManager = orderBasketManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
