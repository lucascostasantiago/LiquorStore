using LiquorStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedLegalPerson
    {
        public static void SeedInitialLegalPerson(this ModelBuilder builder)
        {
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("1d062100-3fc1-434d-9c3a-8be050138231"), CompanyName = "BlackRock Bebidas", CNPJ = "42.826.952/0001-09", Representative = "João" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("96e2aee6-b957-480d-8db4-dc91f6126385"), CompanyName = "Gela Guela", CNPJ = "99.433.240/0001-47", Representative = "Leandro" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("1d713bc5-1157-4962-9ca9-77e8e1b6616e"), CompanyName = "Cerveja e Amigos", CNPJ = "43.699.193/0001-23", Representative = "Maria" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("28804bcf-c9cb-4b66-b21e-3a099b2cd205"), CompanyName = "Cervejeiro Industria de Bebidas", CNPJ = "53.388.896/0001-94", Representative = "Ana" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("75e92fbd-f222-4efd-8f61-85686ee4fa6c"), CompanyName = "SS Distribuidora", CNPJ = "43.755.744/0001-29", Representative = "Iago" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"), CompanyName = "BR Bebidas", CNPJ = "41.891.718/0001-00", Representative = "Mateus" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("9766368e-6cff-4eca-aaaf-ad51d47dfcae"), CompanyName = "Barato 24H", CNPJ = "08.391.986/0001-80", Representative = "Lucas" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("73a08f06-7a0b-4378-a483-04125276ff23"), CompanyName = "Atacadão das Bebidas", CNPJ = "30.474.886/0001-76", Representative = "Pedro" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("f821a712-a18f-4fc3-a877-7ccac48823c2"), CompanyName = "Adega 2000", CNPJ = "82.531.763/0001-23", Representative = "Carla" });
            builder.Entity<LegalPersonEntity>().HasData(new LegalPersonEntity() { Id = Guid.Parse("db39ac3e-21d3-4520-b35f-976d4b247905"), CompanyName = "Bebidas Esfera", CNPJ = "36.175.312/0001-83", Representative = "Carlos" });
        }
    }
}
