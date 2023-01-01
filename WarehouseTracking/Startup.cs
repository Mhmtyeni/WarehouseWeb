using BusinessLayer.AutoMapper.Profiles;
using BusinessLayer.Extensions;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WarehouseTracking.CustomValidators;

namespace WarehouseTracking
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.LoadMyServices();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.User.RequireUniqueEmail = true;
            }).AddErrorDescriber<CustomIdentityValidator>().AddPasswordValidator<CustomPasswordValidator>().AddEntityFrameworkStores<Context>();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "Test";
                options.ExpireTimeSpan = TimeSpan.FromDays(7);
                options.LoginPath = new PathString("/Account/Login");
                options.LogoutPath = new PathString("/Account/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "WarehouseTracking",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
                options.AccessDeniedPath = new PathString("/Account/AccessDenied");
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(BasketProfile),
                typeof(BrandProfile),
                typeof(AppUserProfile),
                typeof(CategoryProfile),
                typeof(CurrencyProfile),
                typeof(OrderBasketLogProfile),
                typeof(OrderProfile),
                typeof(ProductProfile),
                typeof(ShelfProfile),
                typeof(SubCategoryProfile),
                typeof(SubShelfProfile),
                typeof(OrderBasketProfile
                ),
                typeof(ProductLogProfile),
                typeof(UnitProfile),
                typeof(FactoryProfile),
                typeof(ProjectProfile)
                );
            services.AddHttpContextAccessor();
            services.AddMvc().AddJsonOptions(
           options =>
           {
               options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithRedirects("/Error/PageNotFound");
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Request}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
