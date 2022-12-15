using LiquorStore.DTO.Base;

namespace LiquorStore.DTO
{
    public class ProductsDTO : BaseDTO
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
        public long Amount { get; set; }
        public string Type { get; set; }
    }
}
