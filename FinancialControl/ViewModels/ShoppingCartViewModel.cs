using FinancialControl.LiquorStore;
using System;

namespace LiquorStore.ViewModels
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public Guid? ClientId { get; set; } = null;
        public Guid ProductId { get; set; }
        public double Amount { get; set; }
    }
}
