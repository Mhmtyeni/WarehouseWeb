using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddDbContext<Context>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IBasketService, BasketManager>();
            serviceCollection.AddScoped<IBrandService, BrandManager>();
            serviceCollection.AddScoped<ICurrencyService, CurrencyManager>();
            serviceCollection.AddScoped<IOrderBasketLogService, OrderBasketLogManager>();
            serviceCollection.AddScoped<IOrderBasketService, OrderBasketManager>();
            serviceCollection.AddScoped<IOrderService, OrderManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IShelfService, ShelfManager>();
            serviceCollection.AddScoped<ISubCategoryService, SubCategoryManager>();
            serviceCollection.AddScoped<ISubShelfService, SubShelfManager>();
            serviceCollection.AddScoped<IProductLogService, ProductLogManager>();
            serviceCollection.AddScoped<IUnitService, UnitManager>();
            serviceCollection.AddScoped<IFactoryService, FactoryManager>();
            serviceCollection.AddScoped<IProjectService, ProjectManager>();
            return serviceCollection;
        }
    }
}
