using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class Shop11JDBContext : DbContext
    {
        public Shop11JDBContext()
        {

        }

        public Shop11JDBContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-AT94SBBO\\SQLEXPRESS;Database=ShopDb11J;Trusted_Connection=True;");
            }
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsOrders>().HasKey(po => new { po.ProductBarcode, po.OrderId });
            modelBuilder.Entity<ProductsOrders>().HasOne(po => po.Order).WithMany(o => o.Products).HasForeignKey(po => po.OrderId);
            modelBuilder.Entity<Order>().Property(o => o.Status).HasConversion<string>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<ProductsOrders> ProductsOrders { get; set; }

    }
}
