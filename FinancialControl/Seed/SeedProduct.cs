using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedProduct
    { 
        public static void SeedInitialProduct(this ModelBuilder builder)
        {
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), ProductName = "Whisky Jack Daniels 1000 Ml", ProductCode = "1010/2022", Price = 140.00, Amount = 100, Type = "Whisky" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), ProductName = "WHISKY JOHNNIE WALKER RED LABEL 1L", ProductCode = "2020/2022", Price = 100.00, Amount = 100, Type = "Whisky" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("7c7fc09c-ef38-4bb2-af69-beda911ad77b"), ProductName = "Whisky Black & White 1L", ProductCode = "3030/2022", Price = 80.00, Amount = 100, Type = "Whisky" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), ProductName = "Budweiser 330ml", ProductCode = "4040/2022", Price = 7.50, Amount = 100, Type = "Cerveja" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("37b1ae77-8591-4b78-96a6-9b59165acfc8"), ProductName = "Cerveja Heineken Premium Puro Malte Lager", ProductCode = "5050/2022", Price = 8.00, Amount = 100, Type = "Cerveja" }) ;
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("906aa293-31bf-4427-a3ec-64120df57b0c"), ProductName = "Cerveja Spaten Puro Malte, Long Neck com 355ml Spaten 355", ProductCode = "6060/2022", Price = 7.00, Amount = 100, Type = "Cerveja" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), ProductName = "Cerveja Brahma Duplo Malte Puro Malte Lata 350ml", ProductCode = "7070/2022", Price = 3.50, Amount = 100, Type = "Cerveja" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("47538b32-2f9b-4a25-b97c-b15da6332da1"), ProductName = "Coca-Cola 2L", ProductCode = "8080/2022", Price = 9.00, Amount = 100, Type = "Refrigerante" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("53cee177-5425-4f77-84dc-9afd35e6b9c0"), ProductName = "Guaraná 2L", ProductCode = "9090/2022", Price = 7.00, Amount = 100, Type = "Refrigerante" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("86337ec5-cb59-493f-8e0f-2501c2125e51"), ProductName = "Fanta Laranja 2L", ProductCode = "9890/2022", Price = 7.00, Amount = 100, Type = "Refrigerante" });
            builder.Entity<ProductsViewModel>().HasData(new ProductsViewModel() { Id = Guid.Parse("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), ProductName = "Água mineral", ProductCode = "5590/2022", Price = 2.50, Amount = 100, Type = "Água" });
        }
    }
}
