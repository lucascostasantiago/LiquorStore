using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedPhysicalPerson
    {
        public static void SeedInitialPhysicalPerson(this ModelBuilder builder)
        {
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("c482574b-313b-44ec-ac9b-5e0049a81455"), CPF = "008.143.880-00", Name = "João Miguel", BirthDate = new DateTime(1990, 11, 14) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"), CPF = "718.274.630-15", Name = "Maria Clara", BirthDate = new DateTime(1998, 10, 16) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"), CPF = "695.478.320-00", Name = "Samuel", BirthDate = new DateTime(1997, 5, 21) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("d633a3ec-c604-494c-b52f-40346dcc3891"), CPF = "635.309.750-60", Name = "Arthur", BirthDate = new DateTime(1995, 6, 1) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("02660a38-5395-45a0-91df-d31cd2399644"), CPF = "503.443.210-29", Name = "Arthur", BirthDate = new DateTime(2001, 7, 7) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("e50ad915-b45c-4e04-87de-9f4818e91e80"), CPF = "416.121.070-10", Name = "Theo", BirthDate = new DateTime(1996, 3, 8) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("ae75e1d9-6479-40c2-8c02-20790b5792c0"), CPF = "142.305.050-94", Name = "Laura", BirthDate = new DateTime(1998, 3, 13) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"), CPF = "102.663.320-64", Name = "Maria Julia", BirthDate = new DateTime(1998, 3, 15) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("8dbd92f9-160f-4566-8761-ed0091242c89"), CPF = "037.680.480-71", Name = "Bernardo", BirthDate = new DateTime(1999, 2, 25) });
            builder.Entity<PhysicalPersonViewModel>().HasData(new PhysicalPersonViewModel() { Id = Guid.Parse("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"), CPF = "010.898.400-12", Name = "Davi", BirthDate = new DateTime(2002, 2, 5) });
        }
    }
}
