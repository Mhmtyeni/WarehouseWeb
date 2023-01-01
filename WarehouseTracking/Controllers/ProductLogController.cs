using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class ProductLogController : BaseController
    {
        private readonly IProductLogService _productLogManager;
        public ProductLogController(UserManager<AppUser> userManager, IProductLogService productLogManager, IMapper mapper) : base(userManager, mapper)
        {
            _productLogManager = productLogManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            var result = await _productLogManager.GetAllByProductId(id);
            return View(result.Data);
        }
        public async Task<IActionResult> AllLogProducts()
        {
            var result = await _productLogManager.GetAll();
            return View(result.Data);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ExportExcel(int id)
        {
            var result = await _productLogManager.GetAllByProductId(id);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.ProductLogs);
                dataTable.TableName = "AMBAR TÜM MALZEMELER";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateTime.Now.ToShortDateString()} Ürün Rapor.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("Archive");

        }
        public DataTable DataTableSave(IList<ProductLog> orders)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ürün İsmi");
            table.Columns.Add("Ürün Sap Kodu");
            table.Columns.Add("İşlem Öncesi Stok");
            table.Columns.Add("İşlem Sonrası Stok");
            table.Columns.Add("İşlem Yapılan Stok Değeri");
            table.Columns.Add("Tarih");
            foreach (ProductLog item in orders)
            {
                DataRow row = table.NewRow();
                row["Ürün İsmi"] = item.Product.Name;
                row["Ürün Sap Kodu"] = item.Product.Code;
                row["İşlem Öncesi Stok"] = item.FirstQuantity.ToString() + " " + item.Product.Unit.Name;
                row["İşlem Sonrası Stok"] = item.LastQuantity.ToString() + " " + item.Product.Unit.Name;
                row["İşlem Yapılan Stok Değeri"] = (item.LastQuantity - item.FirstQuantity).ToString() + " " + item.Product.Unit.Name;
                row["Tarih"] = item.CreatedDate;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
