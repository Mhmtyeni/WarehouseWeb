using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubCategoryDtos;
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
    public class SubCategoryController : BaseController
    {
        private readonly ISubCategoryService _subCategoryManager;

        public SubCategoryController(UserManager<AppUser> userManager, ISubCategoryService subCategoryService, IMapper mapper):base(userManager, mapper)
        {
            _subCategoryManager = subCategoryService;
        }
        public async Task<JsonResult> GetByCategory(int categoryId)
        {
            var result = await _subCategoryManager.GetByCategoryId(categoryId);
            return Json(result.Data);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _subCategoryManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(SubCategoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _subCategoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(SubCategoryUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _subCategoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
