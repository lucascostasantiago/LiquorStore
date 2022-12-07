using LiquorStore.Enums;
using System;

namespace LiquorStore.DTO
{
    public class UserDTO
    {
        public Guid AddressId { get; set; }
        public Guid? CNPJId { get; set; } = null;
        public Guid? CPFId { get; set; } = null;
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
    }
}
