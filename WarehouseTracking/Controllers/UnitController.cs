using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.UnitDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class UnitController : BaseController
    {
        private readonly IUnitService _unitManager;
        public UnitController(UserManager<AppUser> userManager, IMapper mapper, IUnitService unitManager) : base(userManager, mapper)
        {
            _unitManager = unitManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _unitManager.GetAll();
            return Json(result.Data);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _unitManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(UnitUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _unitManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(UnitAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _unitManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
