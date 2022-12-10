using FinancialControl.LiquorStore;
using System;

namespace LiquorStore.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
        public long Amount { get; set; }
        public string Type { get; set; }
    }
}
