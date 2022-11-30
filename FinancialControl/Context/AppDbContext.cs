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

        public DbSet<UserClientViewModel> Users { get; set; }
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
            builder.SeedInitalAddress();
            builder.SeedInitialPhysicalPerson();
            builder.SeedInitialUserClient();
            builder.SeedInitialProduct();
            builder.SeedInitialSalesHistory();
            builder.SeedInitialLegalPerson();
            builder.SeedInitialUserSeller();
        }

        public void Configure(ModelBuilder builder)
        {

            builder.Entity<AddressViewModel>(entity =>
            {
                entity.Property(e => e.State).IsRequired();
                entity.Property(e => e.City).IsRequired();
                entity.Property(e => e.Neighborhood).IsRequired();
                entity.Property(e => e.Street).IsRequired();
            });

            builder.Entity<PhysicalPersonViewModel>(entity =>
            {
                entity.Property(e => e.CPF).IsRequired();
                entity.Property(e => e.Name).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.CPF).IsUnique();
            });

            builder.Entity<ProductsViewModel>(entity =>
            {
                entity.Property(e => e.ProductCode).IsRequired();
                entity.Property(e => e.ProductName).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Type).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.ProductCode).IsUnique();
            });

            builder.Entity<SalesHistoryViewModel>(entity =>
            {
                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Price).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();

                entity.HasOne(e => e.Products)
                      .WithMany(e => e.SalesHistories)
                      .HasForeignKey(e => e.ProductId);
            });

            builder.Entity<ShoppingCartViewModel>(entity =>
            {
                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.ClientId).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();

                entity.HasOne(e => e.Products)
                      .WithMany(e => e.ShoppingCarts)
                      .HasForeignKey(e => e.ProductId);

                entity.HasOne(e => e.UserClient)
                      .WithMany(e => e.ShoppingCarts)
                      .HasForeignKey(e => e.ClientId);
            });

            builder.Entity<UserClientViewModel>(entity =>
            {
                entity.Property(e => e.AddressId).IsRequired();
                entity.Property(e => e.CPFId).IsRequired();
                entity.Property(e => e.ContactNumber).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.UserType).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.ContactNumber).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();


                entity.HasOne(e => e.Address)
                      .WithMany(e => e.UserClient)
                      .HasForeignKey(e => e.AddressId);

                entity.HasOne(e => e.PhysicalPerson)
                      .WithMany(e => e.UserClient)
                      .HasForeignKey(e => e.CPFId);
            });

            builder.Entity<LegalPersonViewModel>(entity =>
            {
                entity.Property(e => e.CNPJ).IsRequired();
                entity.Property(e => e.CompanyName).IsRequired();
                entity.Property(e => e.Representative).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.CNPJ).IsUnique();
            });

            builder.Entity<UserSellerViewModel>(entity =>
            {
                entity.Property(e => e.CNPJId).IsRequired();
                entity.Property(e => e.AddressId).IsRequired();
                entity.Property(e => e.ContactNumber).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.UserType).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.ContactNumber).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();

                entity.HasOne(e => e.Address)
                      .WithMany(e => e.UserSeller)
                      .HasForeignKey(e => e.AddressId);

                entity.HasOne(e => e.LegalPerson)
                      .WithMany(e => e.UserSeller)
                      .HasForeignKey(e => e.CNPJId);
            });
        }
    }
}
