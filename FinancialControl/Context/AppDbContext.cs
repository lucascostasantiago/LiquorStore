using LiquorStore.Entities;
using LiquorStore.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LiquorStore.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductsEntity> Products { get; set; }
        public DbSet<ShoppingCartEntity> ShoppingCarts { get; set; }
        public DbSet<SalesHistoryEntity> SalesHistories { get; set; }
        public DbSet<PhysicalPersonEntity> PhysicalPerson { get; set; }
        public DbSet<AddressEntity> Address { get; set; }
        public DbSet<LegalPersonEntity> LegalPerson { get; set; }
        public DbSet<SalesHistoryEntity> SalesHistory { get; set; }

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
            builder.SeedInitialUser();
            builder.SeedInitialProduct();
            builder.SeedInitialSalesHistory();
            builder.SeedInitialLegalPerson();
            builder.SeedInitialShoppingCart();
        }

        public void Configure(ModelBuilder builder)
        {

            builder.Entity<AddressEntity>(entity =>
            {
                entity.Property(e => e.State).IsRequired();
                entity.Property(e => e.City).IsRequired();
                entity.Property(e => e.Neighborhood).IsRequired();
                entity.Property(e => e.Street).IsRequired();
            });

            builder.Entity<PhysicalPersonEntity>(entity =>
            {
                entity.Property(e => e.CPF).IsRequired();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.CPF).IsUnique();
            });

            builder.Entity<ProductsEntity>(entity =>
            {
                entity.Property(e => e.ProductCode).IsRequired();
                entity.Property(e => e.ProductName).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Type).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.ProductCode).IsUnique();
            });

            builder.Entity<SalesHistoryEntity>(entity =>
            {
                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Price).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();

                entity.HasOne(e => e.Products)
                      .WithMany(e => e.SalesHistories)
                      .HasForeignKey(e => e.ProductId);
            });

            builder.Entity<ShoppingCartEntity>(entity =>
            {
                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.ClientId).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();

                entity.HasOne(e => e.Products)
                      .WithMany(e => e.ShoppingCarts)
                      .HasForeignKey(e => e.ProductId);

                entity.HasOne(e => e.User)
                      .WithMany(e => e.ShoppingCarts)
                      .HasForeignKey(e => e.ClientId);
            });

            builder.Entity<LegalPersonEntity>(entity =>
            {
                entity.Property(e => e.CNPJ).IsRequired();
                entity.Property(e => e.CompanyName).IsRequired();
                entity.Property(e => e.Representative).IsRequired();

                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.CNPJ).IsUnique();
            });

            builder.Entity<UserEntity>(entity =>
            {
                entity.Property(e => e.CNPJId).IsRequired(false).HasDefaultValue(null);
                entity.Property(e => e.CPFId).IsRequired(false).HasDefaultValue(null);
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
                      .WithMany(e => e.User)
                      .HasForeignKey(e => e.CNPJId);

                entity.HasOne(e => e.PhysicalPerson)
                      .WithMany(e => e.User)
                      .HasForeignKey(e => e.CPFId);
            });
        }
    }
}
