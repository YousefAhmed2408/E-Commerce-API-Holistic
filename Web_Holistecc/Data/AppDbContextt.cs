using Microsoft.EntityFrameworkCore;
using Web_Holistecc.Models;

namespace Web_Holistecc.Data
{
    public class AppDbContextt : DbContext
    {
        public AppDbContextt(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Order> orders  { get; set; }

        public DbSet<Product> products  { get; set; }

        public DbSet<ShoppingCart> shoppingCarts { get; set; }
    }
}
