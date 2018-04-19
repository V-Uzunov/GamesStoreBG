namespace GamesShopBG.Data
{
    using GamesShopBG.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class GamesShopBGDbContext : IdentityDbContext<User>
    {
        public GamesShopBGDbContext()
            : base("GamesShopBGDb", throwIfV1Schema: false)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        
        public static GamesShopBGDbContext Create()
        {
            return new GamesShopBGDbContext();
        }
    }
}