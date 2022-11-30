using LiquorStore.Seed;
using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LiquorStore.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<ProductsViewModel> Products { get; set; }
        public DbSet<ShoppingCartViewModel> ShoppingCarts { get; set; }
        public DbSet<SalesHistoryViewModel> SalesHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Configure(builder);
            CallSeeds(builder);
        }

        public void CallSeeds(ModelBuilder builder)
        {
            builder.SeedModel();
            builder.SeedUser();
            builder.SeedProduct();
            builder.SeedSalesHistorys();
            //builder.SeedShoppingCart();
        }

        public void Configure(ModelBuilder builder)
        {
            builder.Entity<SalesHistoryViewModel>(entity =>
            {
                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Price).IsRequired();

                entity.HasOne(e => e.Products)
                      .WithMany(e => e.SalesHistories)
                      .HasForeignKey(e => e.ProductId);
            });
        }
    }
}
