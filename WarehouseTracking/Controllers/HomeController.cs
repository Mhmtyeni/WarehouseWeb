using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Utilities.Results.ComplexTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using WarehouseTracking.Models;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Concrete;
using System;
using System.Xml;

namespace WarehouseTracking.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        IProductService _productManager;
        IOrderService _orderManager;
        IShelfService _shelfManager;
        ISubShelfService _subshelfManager;
        IOrderBasketLogService _orderBasketlogManager;
        public HomeController(UserManager<AppUser> userManager, IShelfService shelfManager, IOrderBasketLogService orderBasketlogManager, ISubShelfService subshelfManager, IProductService productManager, IMapper mapper, IOrderService orderManager) : base(userManager, mapper)
        {
            _productManager = productManager;
            _orderManager = orderManager;
            _shelfManager = shelfManager;
            _subshelfManager = subshelfManager;
            _orderBasketlogManager = orderBasketlogManager;
        }
        public async Task<IActionResult> Index()
        {
            //XmlDocument xmlVerisi = new XmlDocument();
            //xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            //float dolar = Convert.ToSingle(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
            //float euro = Convert.ToSingle(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
            HomeIndexViewModel model = new HomeIndexViewModel();
            var result = await _productManager.GetAll();
            var result2 = await _orderManager.GetAllDeleted();
            var result3 = await _shelfManager.GetAll();
            var result4 = await _subshelfManager.GetAll();
            var result5 = await _orderBasketlogManager.GetAll();
            model.TotalOrders = result2.Data.Orders.Count;
            int j = 0, sayac = 0;
            string[] OrderName = new string[result5.Data.OrderBasketLogs.Count];
            Array.Resize(ref model.Order, result5.Data.OrderBasketLogs.Count);
            Array.Resize(ref model.OrderSayac, result5.Data.OrderBasketLogs.Count);
            foreach (var item in result5.Data.OrderBasketLogs)
            {
                OrderName[j] = item.Product.Name;
                j++;
            }
            j = 0;

            for (int x = 0; x < result5.Data.OrderBasketLogs.Count; x++)
            {
                for (int k = 0; k < result5.Data.OrderBasketLogs.Count; k++)
                {
                    if (OrderName[x] == OrderName[k])
                    {
                        for (int l = 0; l < x; l++)
                        {
                            if (OrderName[l] == OrderName[x])
                                sayac = -1;
                        }
                        sayac++;
                    }
                }
                if (sayac != 0)
                {
                    model.Order[j] = (sayac + " Adet " + OrderName[j] + " malzemesinden alınmıştır.");
                    j++;
                }
                model.OrderSayac[j - 1] = sayac;
                sayac = 0;
            }
            Array.Sort(model.Order);
            Array.Reverse(model.Order);
            j = 0;
            //j++;
            //if (j == 10)
            //{
            //    j = 0;
            //    break;
            //}

            foreach (var item in result2.Data.Orders)
            {
                model.FirstName[j] = item.AppUser.FirstName;
                model.LastName[j] = item.AppUser.LastName;
                model.Note[j] = item.Note;
                model.Date[j] = item.CreatedDate.ToString();
                model.Id[j] = item.Id;
                j++;
                if (j == 10)
                    break;
            }
            foreach (var item in result.Data.Products)
            {
                for (int i = 0; i < 99; i++)
                    if (item.SubShelf.Number == i)
                        model.WarehouseOccupancy += 1;
                if (item.CurrencyId == 3)
                    model.TotalWarehouseValue += (item.Price * item.Stock);
                if (item.CurrencyId == 4)
                    model.TotalWarehouseValue += ((item.Price * item.Stock) * 18);
                if (item.CurrencyId == 5)
                    model.TotalWarehouseValue += ((item.Price * item.Stock) * 18);
                if (item.Unit.Name == "Adet")
                    model.TotalProducts += item.Stock;
                else
                    model.TotalProducts += 1;
            }
            model.WarehouseOccupancy = model.TotalProducts / model.WarehouseOccupancy;

            return View(model);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Tools()
        {
            return View();
        }
    }
}
