using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedUserSeller
    {
        public static void SeedInitialUserSeller(this ModelBuilder builder)
        {
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("1526ebb7-0765-48c6-8e4c-7126c7e8f882"), CNPJId = Guid.Parse("1d062100-3fc1-434d-9c3a-8be050138231"), AddressId = Guid.Parse("9d27afe4-cedd-440c-bee9-612633e6a2e3"), Email = "joao@gmail.com", ContactNumber = "(88) 37762-4466", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("222c978d-3f84-4700-83b5-f930eeabdd0e"), CNPJId = Guid.Parse("96e2aee6-b957-480d-8db4-dc91f6126385"), AddressId = Guid.Parse("fda23b7b-f8c5-4753-85b7-3dafb334967f"), Email = "leandro@gmail.com", ContactNumber = "(88) 52351-7612", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("6ad5ddc8-4530-479b-8a0e-a24f3405601f"), CNPJId = Guid.Parse("1d713bc5-1157-4962-9ca9-77e8e1b6616e"), AddressId = Guid.Parse("f9b1e80d-850e-4221-9cf0-7f72324865a6"), Email = "maria@gmail.com", ContactNumber = "(88) 15138-5437", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("0bd4d5b7-04a4-492f-85db-f4f390859248"), CNPJId = Guid.Parse("28804bcf-c9cb-4b66-b21e-3a099b2cd205"), AddressId = Guid.Parse("17005f01-a5e2-484f-8231-54b7d7d44149"), Email = "ana@gmail.com", ContactNumber = "(88) 89470-2432", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("1cde39df-b5c7-4f4a-9f1a-987e148c3075"), CNPJId = Guid.Parse("75e92fbd-f222-4efd-8f61-85686ee4fa6c"), AddressId = Guid.Parse("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), Email = "iago@gmail.com", ContactNumber = "(88) 60675-1641", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("18776840-d661-4bd4-88fd-21d3389ba3e8"), CNPJId = Guid.Parse("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"), AddressId = Guid.Parse("73f09bb3-56d9-491f-b100-31786f6a4d79"), Email = "mateus@gmail.com", ContactNumber = "(88) 58046-6592", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("b132a393-5404-4d47-b540-5d21a18449d5"), CNPJId = Guid.Parse("9766368e-6cff-4eca-aaaf-ad51d47dfcae"), AddressId = Guid.Parse("06fb4a76-3aa1-40c7-9f43-183090793809"), Email = "lucas@gmail.com", ContactNumber = "(88) 79824-2804", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("8dc7eac1-aa1b-4cc2-8d12-1e6e772b9352"), CNPJId = Guid.Parse("73a08f06-7a0b-4378-a483-04125276ff23"), AddressId = Guid.Parse("dcd2bdb5-93ce-4810-ac85-5faff4996546"), Email = "pedro@gmail.com", ContactNumber = "(88) 13470-1323", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("4d77813e-46d9-436b-a14c-6ff82912ae63"), CNPJId = Guid.Parse("f821a712-a18f-4fc3-a877-7ccac48823c2"), AddressId = Guid.Parse("9c06c239-c51b-4a89-b70f-902c2289ce9d"), Email = "carla@gmail.com", ContactNumber = "(88) 86602-5652", UserType = Enums.UserType.SELLER });
            builder.Entity<UserSellerViewModel>().HasData(new UserSellerViewModel() { Id = Guid.Parse("e2b0ad12-2aba-4635-b647-3c6861809064"), CNPJId = Guid.Parse("db39ac3e-21d3-4520-b35f-976d4b247905"), AddressId = Guid.Parse("b8caa459-b828-47c0-8eb3-b2186b509807"), Email = "carlos@gmail.com", ContactNumber = "(88) 32751-5601", UserType = Enums.UserType.SELLER });

        }
    }
}