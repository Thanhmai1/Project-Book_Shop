using Microsoft.EntityFrameworkCore;
using Project_Book_Shop.Models;

namespace Project_Book_Shop
{
    public class BookShopDbContext
    {
        public BookShopDbContext(DbContextOptions<BookShopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            base.OnModelCreating(modelBuilder);
        }
    }
}
