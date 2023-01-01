using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.ViewComponents.SideBarViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;
        private readonly IMapper _mapper;

        public SideBarViewComponent(ICategoryService categoryService, IMapper mapper)
        {
            _categoryManager = categoryService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryManager.GetAll();
            return View("_sideBar", categories.Data);
        }
    }
}
