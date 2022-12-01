using LiquorStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorStore.Seed
{
    public static class SeedAdminUser
    {
        public static void SeedInitialAdminUser(this ModelBuilder builder)
        {
            builder.Entity<AdminUserViewModel>().HasData(new AdminUserViewModel() { Id = Guid.Parse("6f24a4d2-d04d-4164-b1eb-adda25a94807"), CNPJ = "81.108.962/0001-60", Name = "admin", Email = "admin@gmail.com", ContactNumber = "(88) 61964-4368", UserType = Enums.UserType.ADMIN });
        }
    }
}
