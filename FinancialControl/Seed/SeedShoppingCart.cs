using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedShoppingCart
    {
        public static void SeedInitialShoppingCart(this ModelBuilder builder)
        {
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse(""), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse(""), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse(""), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("7c7fc09c-ef38-4bb2-af69-beda911ad77b"), Amount = 1 });
        }
    }
}
