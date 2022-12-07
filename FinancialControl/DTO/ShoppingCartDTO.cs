using LiquorStore.DTO.Base;
using System;

namespace LiquorStore.DTO
{
    public class ShoppingCartDTO : BaseDTO
    {
        public Guid ClientId { get; set; }
        public Guid ProductId { get; set; }
        public double Amount { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
