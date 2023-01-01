using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.AppUserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WarehouseTracking.Models;

namespace WarehouseTracking.ViewComponents.NavBarViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IOrderService _orderManager;
        private readonly IMapper _mapper;

        public NavBarViewComponent(UserManager<AppUser> userManager, IMapper mapper, IOrderService orderManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _orderManager = orderManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            NavBarViewModel model = new NavBarViewModel();
            model.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _orderManager.GetAll();
            if (result.Data.Orders.Count > 0)
                model.IsOrderExist = true;
            return View("_navBar", model);
            
        }
    }
}
