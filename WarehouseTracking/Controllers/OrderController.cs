using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketDtos;
using EntityLayer.Dtos.OrderBasketLogDtos;
using EntityLayer.Dtos.OrderDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderManager;
        private readonly IOrderBasketService _orderBasketManager;
        private readonly IOrderBasketLogService _orderBasketLogManager;
        private readonly IBasketService _basketManager;
        private readonly IProductService _productManager;

        public OrderController(UserManager<AppUser> userManager, IMapper mapper, IOrderService orderManager, IBasketService basketManager, IOrderBasketService orderBasketManager, IProductService productManager, IOrderBasketLogService orderBasketLogManager) : base(userManager, mapper)
        {
            _orderManager = orderManager;
            _basketManager = basketManager;
            _orderBasketManager = orderBasketManager;
            _productManager = productManager;
            _orderBasketLogManager = orderBasketLogManager;
        }

        public async Task<IActionResult> Index()
        {
            dynamic result;
            if (User.IsInRole("Admin"))
                result = await _orderManager.GetAll();
            else
                result = await _orderManager.GetAllByUserId(LoggedInUser.Id);
            return View(result.Data);
        }
        public async Task<IActionResult> Archive()
        {
            var result = await _orderManager.GetAllDeleted();
            return View(result.Data);
        }
        public async Task<IActionResult> Receipt()
        {
            var result = await _orderManager.GetByUserId(LoggedInUser.Id);
            return PartialView(result.Data.Order);
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _orderManager.GetById(id);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(OrderAddDto p)
        {
            p.AppUserId = LoggedInUser.Id;
            p.CreatedByName = LoggedInUser.UserName;
            p.CreatedDate = DateTime.Now;
            var result = await _orderManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
            {
                var order = await _orderManager.GetByUserId(LoggedInUser.Id);
                var baskets = await _basketManager.GetAllByUserId(LoggedInUser.Id);
                foreach (var item in baskets.Data.Baskets)
                {
                    OrderBasketAddDto orderBasket = new OrderBasketAddDto
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Date = DateTime.Now,
                        OrderId = order.Data.Order.Id
                    };
                    var isDone = await _orderBasketManager.Add(orderBasket);
                    if (isDone.ResultStatus == ResultStatus.Success)
                    {
                        await _productManager.UpdateStockById(item.ProductId, item.Quantity, 0);
                        await _basketManager.DeleteByUserId(LoggedInUser.Id);
                    }
                }
            }
            return Json(true);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _orderManager.DeleteById(id);
            var baskets = await _orderBasketManager.GetAllByOrderId(id);
            foreach (var item in baskets.Data.OrderBaskets)
            {
                OrderBasketLogAddDto orderBasketLog = new OrderBasketLogAddDto
                {
                    OrderId = id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Date = item.Date
                };
                await _orderBasketLogManager.Add(orderBasketLog);
            }
            await _orderBasketManager.DeleteAllByOrderId(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> Cancel(int id)
        {
            var baskets = await _orderBasketManager.GetAllByOrderId(id);
            foreach (var item in baskets.Data.OrderBaskets)
                await _productManager.UpdateStockById(item.ProductId, item.Quantity, 1);

            var result = await _orderBasketManager.DeleteAllByOrderId(id);
            await _orderManager.DeleteById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ExportExcel()
        {
            var result = await _orderBasketLogManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.OrderBasketLogs);
                dataTable.TableName = "AMBAR GEÇMİŞ SİPARİŞLER";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateTime.Now.ToShortDateString()} Ambar Rapor.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("Archive");

        }
        public DataTable DataTableSave(IList<OrderBasketLog> orders)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sipariş Tarihi");
            table.Columns.Add("Ürün Sap Kodu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Ürün Adet");
            table.Columns.Add("Malzeme Açıklaması");
            table.Columns.Add("Sipariş Veren");
            foreach (OrderBasketLog item in orders)
            {
                DataRow row = table.NewRow();
                row["Sipariş Tarihi"] = item.Date;
                row["Ürün Sap Kodu"] = item.Product.Code;
                row["Açıklama"] = item.Order.Note;
                row["Ürün Adet"] = item.Quantity;
                row["Malzeme Açıklaması"] = item.Product.Name;
                row["Sipariş Veren"] = item.Order.AppUser.FirstName + " " + item.Order.AppUser.LastName;
                table.Rows.Add(row);
            }
            return table;
        }


    }
}
