using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedAddress
    {
        public static void SeedInitalAddress(this ModelBuilder builder)
        {
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("9d27afe4-cedd-440c-bee9-612633e6a2e3"), State = "CE", City = "Fortaleza", Neighborhood = "Aerolândia", Street = "Raul Barbosa" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("fda23b7b-f8c5-4753-85b7-3dafb334967f"), State = "CE", City = "Fortaleza", Neighborhood = "Jacarecanga", Street = "José Jatahy" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("f9b1e80d-850e-4221-9cf0-7f72324865a6"), State = "CE", City = "Fortaleza", Neighborhood = "Alvaro Weyne", Street = "Francisco SA" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("17005f01-a5e2-484f-8231-54b7d7d44149"), State = "CE", City = "Fortaleza", Neighborhood = "Bairro Ellery", Street = "Tenente Lisboa" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), State = "CE", City = "Fortaleza", Neighborhood = "Mondubim", Street = "João Gentil" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("73f09bb3-56d9-491f-b100-31786f6a4d79"), State = "CE", City = "Fortaleza", Neighborhood = "Papicu", Street = "Manoel Sátiro" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("06fb4a76-3aa1-40c7-9f43-183090793809"), State = "CE", City = "Fortaleza", Neighborhood = "Pirambu", Street = "Desembargador Lauro Nogueira" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("dcd2bdb5-93ce-4810-ac85-5faff4996546"), State = "CE", City = "Fortaleza", Neighborhood = "Sapiranga", Street = "Cantelo Branco" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("9c06c239-c51b-4a89-b70f-902c2289ce9d"), State = "CE", City = "Fortaleza", Neighborhood = "Jóquei Clube", Street = "Mãe Lisboa" });
            builder.Entity<AddressViewModel>().HasData(new AddressViewModel() { Id = Guid.Parse("b8caa459-b828-47c0-8eb3-b2186b509807"), State = "CE", City = "Fortaleza", Neighborhood = "Bom Fim", Street = "Bom Fim" });
        }
    }
}