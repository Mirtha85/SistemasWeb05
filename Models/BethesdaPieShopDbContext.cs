using Microsoft.EntityFrameworkCore;

namespace SistemasWeb01.Models
{
    public class BethesdaPieShopDbContext : DbContext
    {
        public BethesdaPieShopDbContext(DbContextOptions<BethesdaPieShopDbContext> options) : base(options)
        {
            // migrations history is stored at table __EFMigrationsHistory
            Database.Migrate();// this will migrate the database on startup
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        //verificar
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}