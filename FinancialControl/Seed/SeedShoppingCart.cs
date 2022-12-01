using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedShoppingCart
    {
        public static void SeedInitialShoppingCart(this ModelBuilder builder)
        {
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("3b5336d8-472f-48af-87ee-309104ce2445"), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("103f2129-c7be-433b-8a62-34a5167823b9"), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("3c80653a-c85d-4602-8807-71297ae74f6f"), ClientId = Guid.Parse("1949929f-ac10-4bef-a83a-f617b3f42018"), ProductId = Guid.Parse("7c7fc09c-ef38-4bb2-af69-beda911ad77b"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("1ec52c74-c51a-4f2c-8820-8db727e10ed6"), ClientId = Guid.Parse("6617afd4-60e4-415c-908d-4bd0ac005f14"), ProductId = Guid.Parse("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("42bd6db1-855c-494f-bcea-2841774f49c8"), ClientId = Guid.Parse("a6158c79-8802-485d-8e0c-12b02574c81b"), ProductId = Guid.Parse("86337ec5-cb59-493f-8e0f-2501c2125e51"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("24a7ab91-bfc5-4846-b268-ac715823b28a"), ClientId = Guid.Parse("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"), ProductId = Guid.Parse("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("d43cb3ef-9004-4db1-a546-0c9d65a97bf5"), ClientId = Guid.Parse("6617afd4-60e4-415c-908d-4bd0ac005f14"), ProductId = Guid.Parse("37b1ae77-8591-4b78-96a6-9b59165acfc8"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("243d15cd-226e-43dd-a2fb-8022cadb3053"), ClientId = Guid.Parse("6617afd4-60e4-415c-908d-4bd0ac005f14"), ProductId = Guid.Parse("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("0157258b-dfa9-4445-a5d4-31ffeb176fb3"), ClientId = Guid.Parse("59d200e2-5f8a-48a9-9cda-d012b9271ab3"), ProductId = Guid.Parse("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), Amount = 1 });
            builder.Entity<ShoppingCartViewModel>().HasData(new ShoppingCartViewModel() { Id = Guid.Parse("6965cec1-65e3-4ee5-abf2-f299f9f8981a"), ClientId = Guid.Parse("564f335f-35bd-430b-a330-541403ade35f"), ProductId = Guid.Parse("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), Amount = 1 });
        }
    }
}
