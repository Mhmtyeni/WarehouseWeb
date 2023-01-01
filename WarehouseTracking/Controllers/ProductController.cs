using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Dtos.ProductLogDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    [Authorize]
    public class ProductController : BaseController
    {
        IProductService _productManager;
        IProductLogService _productLogManager;
        public ProductController(IProductService productManager, UserManager<AppUser> userManager, IMapper mapper, IProductLogService productLogManager) : base(userManager, mapper)
        {
            _productManager = productManager;
            _productLogManager = productLogManager;
        }
        public async Task<IActionResult> Index(int id)
        {
            var result = await _productManager.GetBySubCategoryId(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            else
                return View();
        }
        public async Task<IActionResult> AllProducts()
        {
            var result = await _productManager.GetAll();
            return View(result.Data);
        }
        public async Task<IActionResult> Archive()
        {
            var result = await _productManager.GetAllDeleted();
            return View(result.Data);
        }
        public async Task<IActionResult> CriticalStock()
        {
            var result = await _productManager.GetAllCriticalStock();
            return View(result.Data);
        }
        public async Task<IActionResult> Search(string searchKey)
        {
            if (searchKey != "" && searchKey != " " && searchKey != null)
            {
                var result = await _productManager.SearchByKeyword(searchKey);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
            }
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Add(ProductAddDto p)
        {
            bool bIsExist = await _productManager.CheckCodeExist(p.Code);
            if (!bIsExist)
            {
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _productManager.Add(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);

        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _productManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Edit(ProductUpdateDto p)
        {

            var product = await _productManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _productManager.Update(p);
            if (product.Data.Product.Stock != p.Stock)
            {
                ProductLogAddDto productLog = new ProductLogAddDto
                {
                    ProductId = p.Id,
                    CreatedDate = DateTime.Now,
                    CreatedByName = LoggedInUser.UserName,
                    FirstQuantity = product.Data.Product.Stock,
                    LastQuantity = p.Stock
                };
                await _productLogManager.Add(productLog);
            }
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _productManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> RemoveDelete(int id)
        {
            var result = await _productManager.RemoveDeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ExportExcel()
        {

            var result = await _productManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.Products);
                dataTable.TableName = "AMBAR TÜM MALZEMELER";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20.0;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateTime.Now.ToShortDateString()} Tüm-Malzemeler.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProducts");

        }
        public DataTable DataTableSave(IList<Product> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sap Kodu");
            table.Columns.Add("Marka Adı");
            table.Columns.Add("Malzeme Tanımı");
            table.Columns.Add("Birim");
            table.Columns.Add("Stok");
            table.Columns.Add("Fiyat");
            table.Columns.Add("Raf");
            table.Columns.Add("Raf Numarası");
            foreach (Product item in products)
            {
                DataRow row = table.NewRow();
                row["Sap Kodu"] = item.Code;
                row["Marka Adı"] = item.Brand.Name;
                row["Malzeme Tanımı"] = item.Name;
                row["Birim"] = item.Unit.Name;
                row["Stok"] = item.Stock;
                row["Fiyat"] = item.Price;
                row["Raf"] = item.SubShelf.Shelf.Name;
                row["Raf Numarası"] = item.SubShelf.Number;
                table.Rows.Add(row);
            }
            return table;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CriticalExportExcel()
        {

            var result = await _productManager.GetAllCriticalStock();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveCritical(result.Data.Products);
                dataTable.TableName = "AMBAR KRİTİK STOK MALZEMELER";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20.0;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateTime.Now.ToShortDateString()} Kritik Stok Malzemeler.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("CriticalStock");

        }
        public DataTable DataTableSaveCritical(IList<Product> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sap Kodu");
            table.Columns.Add("Marka Adı");
            table.Columns.Add("Malzeme Tanımı");
            table.Columns.Add("Stok");
            table.Columns.Add("Fiyat");
            table.Columns.Add("Raf");
            table.Columns.Add("Raf Numarası");
            foreach (Product item in products)
            {
                DataRow row = table.NewRow();
                row["Sap Kodu"] = item.Code;
                row["Marka Adı"] = item.Brand.Name;
                row["Malzeme Tanımı"] = item.Name;
                row["Stok"] = item.Stock;
                row["Fiyat"] = item.Price;
                row["Raf"] = item.SubShelf.Shelf.Name;
                row["Raf Numarası"] = item.SubShelf.Number;
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
