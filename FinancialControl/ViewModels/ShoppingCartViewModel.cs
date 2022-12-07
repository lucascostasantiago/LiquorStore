using FinancialControl.LiquorStore;
using LiquorStore.Enums;

namespace LiquorStore.ViewModels
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public double Amount { get; set; }
        public string ProductCode { get; set; }
        public string ClientCPF { get; set; }
        public double TotalPurchaseAmount { get; set; }
        public FormOfPayment FormOfPayment { get; set; }
    }
}
