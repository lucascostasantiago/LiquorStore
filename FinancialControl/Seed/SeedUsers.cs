using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedUsers
    {
        public static void SeedInitialUser(this ModelBuilder builder)
        {
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), CPFId = Guid.Parse("c482574b-313b-44ec-ac9b-5e0049a81455"), AddressId = Guid.Parse("9d27afe4-cedd-440c-bee9-612633e6a2e3"), Email = "joao@gmail.com", ContactNumber = "85904736783", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("59315f8a-ccd3-4a63-a202-93e41629ca8c"), CPFId = Guid.Parse("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"), AddressId = Guid.Parse("fda23b7b-f8c5-4753-85b7-3dafb334967f"), Email = "ana@gmail.com", ContactNumber = "40239750012", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("59d200e2-5f8a-48a9-9cda-d012b9271ab3"), CPFId = Guid.Parse("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"), AddressId = Guid.Parse("f9b1e80d-850e-4221-9cf0-7f72324865a6"), Email = "pedro@gmail.com", ContactNumber = "73480291082", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("6b412a8a-c604-405b-93b3-a5608f38cd15"), CPFId = Guid.Parse("d633a3ec-c604-494c-b52f-40346dcc3891"), AddressId = Guid.Parse("17005f01-a5e2-484f-8231-54b7d7d44149"), Email = "maria@gmail.com", ContactNumber = "45231807095", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("064d3464-78f3-42c2-a7bb-1dc36e4c7374"), CPFId = Guid.Parse("02660a38-5395-45a0-91df-d31cd2399644"), AddressId = Guid.Parse("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), Email = "julia@gmail.com", ContactNumber = "26785950058", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"), CPFId = Guid.Parse("e50ad915-b45c-4e04-87de-9f4818e91e80"), AddressId = Guid.Parse("73f09bb3-56d9-491f-b100-31786f6a4d79"), Email = "carlos@gmail.com", ContactNumber = "45668730050", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("a6158c79-8802-485d-8e0c-12b02574c81b"), CPFId = Guid.Parse("ae75e1d9-6479-40c2-8c02-20790b5792c0"), AddressId = Guid.Parse("06fb4a76-3aa1-40c7-9f43-183090793809"), Email = "lucas@gmail.com", ContactNumber = "29900889037", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("776d4164-eaec-4cee-afef-3a128e33399a"), CPFId = Guid.Parse("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"), AddressId = Guid.Parse("dcd2bdb5-93ce-4810-ac85-5faff4996546"), Email = "erik@gmail.com", ContactNumber = "63313114083", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("6617afd4-60e4-415c-908d-4bd0ac005f14"), CPFId = Guid.Parse("8dbd92f9-160f-4566-8761-ed0091242c89"), AddressId = Guid.Parse("9c06c239-c51b-4a89-b70f-902c2289ce9d"), Email = "vitor@gmail.com", ContactNumber = "39532915052", UserType = Enums.UserType.CUSTOMER });
            builder.Entity<UserClientViewModel>().HasData(new UserClientViewModel() { Id = Guid.Parse("564f335f-35bd-430b-a330-541403ade35f"), CPFId = Guid.Parse("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"), AddressId = Guid.Parse("b8caa459-b828-47c0-8eb3-b2186b509807"), Email = "joaopedro@gmail.com", ContactNumber = "74668105007", UserType = Enums.UserType.CUSTOMER });
        }
    }
}
