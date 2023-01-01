using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=10.108.206.10; Database=WarehouseWebDB2; integrated security=false; User Id=sa; password=123456");
            optionsBuilder.UseSqlServer("server=10.3.0.42; Database=WarehouseWebDB; integrated security=false; User Id=sa; password=123456");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderBasket>().HasKey(a => new { a.OrderId, a.ProductId });
            modelBuilder.Entity<Basket>().HasKey(a => new { a.AppUserId, a.ProductId });
        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<OrderBasket> OrderBaskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBasketLog> OrderBasketLogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubShelf> SubShelves { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ProductLog> ProductLogs { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}



