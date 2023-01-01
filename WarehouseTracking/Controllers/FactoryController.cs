using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDtos;
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
    public class FactoryController : BaseController
    {
        private readonly IFactoryService _factoryManager;
        public FactoryController(UserManager<AppUser> userManager, IFactoryService factoryService, IMapper mapper) : base(userManager, mapper)
        {
            _factoryManager = factoryService;
        }

        
        public async Task<JsonResult> GetAll()
        {
            var result = await _factoryManager.GetAll();
            return Json(result.Data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _factoryManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(FactoryAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _factoryManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(FactoryUpdateDto p)
        {
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _factoryManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
