using LiquorStore.DTO.Base;
using System;

namespace LiquorStore.DTO
{
    public class SalesHistoryDTO : BaseDTO
    {
        public Guid ProductId { get; set; }
        public long Amount { get; set; }
        public double Price { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string ProductName { get; set; }
    }
}
