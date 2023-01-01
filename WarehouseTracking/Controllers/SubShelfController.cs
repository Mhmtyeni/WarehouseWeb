using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubShelfDtos;
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
    [Authorize]
    public class SubShelfController : BaseController
    {
        private readonly ISubShelfService _subShelfManager;

        public SubShelfController(UserManager<AppUser> userManager, ISubShelfService subShelfService, IMapper mapper) : base(userManager, mapper)
        {
            _subShelfManager = subShelfService;
        }
        public async Task<JsonResult> GetByShelfId(int shelfId)
        {
            var result = await _subShelfManager.GetByShelfId(shelfId);
            return Json(result.Data);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _subShelfManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(SubShelfAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _subShelfManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(SubShelfUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _subShelfManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
