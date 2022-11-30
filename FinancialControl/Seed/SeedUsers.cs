using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedUsers
    {
        public static void SeedUser(this ModelBuilder builder)
        {
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("3dbf1e9f-ded9-43c8-83ff-a9c8fa2f77ac"), Email = "admin@gmail.com", Name = "ADMIN", ContactNumber = "88997836065", CPF = "12345678900", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim" , UserType = Enums.UserType.ADMIN });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), Email = "joao@gmail.com", Name = "João", ContactNumber = "85904736783", CPF = "90899044093", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("59315f8a-ccd3-4a63-a202-93e41629ca8c"), Email = "ana@gmail.com", Name = "Ana", ContactNumber = "40239750012", CPF = "12009272064", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("59d200e2-5f8a-48a9-9cda-d012b9271ab3"), Email = "pedro@gmail.com", Name = "Pedro", ContactNumber = "73480291082", CPF = "25309677097", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("6b412a8a-c604-405b-93b3-a5608f38cd15"), Email = "maria@gmail.com", Name = "Maria", ContactNumber = "45231807095", CPF = "28843942069", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("064d3464-78f3-42c2-a7bb-1dc36e4c7374"), Email = "julia@gmail.com", Name = "Julia", ContactNumber = "26785950058", CPF = "23098226048", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"), Email = "carlos@gmail.com", Name = "Carlos", ContactNumber = "45668730050", CPF = "86168814094", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("a6158c79-8802-485d-8e0c-12b02574c81b"), Email = "lucas@gmail.com", Name = "Lucas", ContactNumber = "29900889037", CPF = "35736507080", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("776d4164-eaec-4cee-afef-3a128e33399a"), Email = "erik@gmail.com", Name = "Erik", ContactNumber = "63313114083", CPF = "23097156038", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("6617afd4-60e4-415c-908d-4bd0ac005f14"), Email = "vitor@gmail.com", Name = "Vitor", ContactNumber = "39532915052", CPF = "71499571020", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
            builder.Entity<UserViewModel>().HasData(new UserViewModel() { Id = Guid.Parse("564f335f-35bd-430b-a330-541403ade35f"), Email = "joaopedro@gmail.com", Name = "João Pedro", ContactNumber = "74668105007", CPF = "70834490072", State = "CE", City = "Limoeiro", Neighborhood = "Bom Fim", Street = "Bom Fim", UserType = Enums.UserType.CONSUMER });
        }
    }
}
