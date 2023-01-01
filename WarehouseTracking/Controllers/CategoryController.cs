using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CategoryDtos;
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
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(UserManager<AppUser> userManager, ICategoryService categoryService, IMapper mapper) : base(userManager, mapper)
        {
            _categoryManager = categoryService;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _categoryManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(CategoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _categoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(CategoryUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _categoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        public async Task<JsonResult> GetAll()
        {
            var result = await _categoryManager.GetAll();
            return Json(result.Data);
        }
    }
}
