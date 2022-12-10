using LiquorStore.DTO.Base;
using LiquorStore.Enums;
using System;

namespace LiquorStore.DTO
{
    public class UserDTO : BaseDTO
    {
        public Guid AddressId { get; set; }
        public Guid? CNPJId { get; set; } = null;
        public Guid? CPFId { get; set; } = null;
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
    }
}
