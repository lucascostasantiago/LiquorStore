using LiquorStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedSalesHistory
    {
        public static void SeedInitialSalesHistory(this ModelBuilder builder)
        {
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("95742b06-0dd0-45fa-81dc-706f79f9552e"), ProductId = Guid.Parse("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), Amount = 3, Price = 7.50 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("ebed77af-213b-498b-95f0-b5ddf1acf184"), ProductId = Guid.Parse("86337ec5-cb59-493f-8e0f-2501c2125e51"), Amount = 2, Price = 14.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("fd060ef5-10d7-4ac1-a799-5f2a81d883ab"), ProductId = Guid.Parse("47538b32-2f9b-4a25-b97c-b15da6332da1"), Amount = 2, Price = 18.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("7b95bc36-dc41-488e-9741-cafeaaa5a495"), ProductId = Guid.Parse("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), Amount = 1, Price = 140.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("e0cde259-a819-4bed-8c06-6875594d5df0"), ProductId = Guid.Parse("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), Amount = 3, Price = 100.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("d634a500-f1af-4629-991a-684e2c72c944"), ProductId = Guid.Parse("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), Amount = 4, Price = 28.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("c7877672-a069-49d8-aef4-3892ef4dfdf8"), ProductId = Guid.Parse("47538b32-2f9b-4a25-b97c-b15da6332da1"), Amount = 10, Price = 90.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("6d700b6f-c1f4-49ce-99c0-c2eabd26e05e"), ProductId = Guid.Parse("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), Amount = 20, Price = 150.00 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("9e77f700-9538-423b-86ca-576cb7da1f17"), ProductId = Guid.Parse("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), Amount = 7, Price = 17.50 });
            builder.Entity<SalesHistoryEntity>().HasData(new SalesHistoryEntity() { Id = Guid.Parse("8ca5419d-a561-4f61-a3ba-ee4a4dbb1cf4"), ProductId = Guid.Parse("906aa293-31bf-4427-a3ec-64120df57b0c"), Amount = 9, Price = 63.00 });
        }
    }
}
