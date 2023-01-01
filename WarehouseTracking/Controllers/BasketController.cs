using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class BasketController : BaseController
    {
        private readonly IBasketService _basketManager;
        public BasketController(UserManager<AppUser> userManager, IMapper mapper, IBasketService basketManager) : base(userManager, mapper)
        {
            _basketManager = basketManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _basketManager.GetAllByUserId(LoggedInUser.Id);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(int productId)
        {
            var products = await _basketManager.GetAllByUserId(LoggedInUser.Id);
            if (products.Data.Baskets.Where(x => x.ProductId == productId).Any())
                return Json("exist");
            BasketAddDto basket = new BasketAddDto
            {
                AppUserId = LoggedInUser.Id,
                ProductId = productId,
                Quantity = 1,
                Date = DateTime.Now
            };
            var result = await _basketManager.Add(basket);
            if (result.ResultStatus == ResultStatus.Success)
                return Json("done");
            else
                return Json("error");
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int productId, int userId)
        {
            var result = await _basketManager.Delete(productId,userId);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(BasketUpdateDto p)
        {
            p.AppUserId = LoggedInUser.Id;
            p.Date = DateTime.Now;            
            var result = await _basketManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
