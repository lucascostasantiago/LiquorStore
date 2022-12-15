using FinancialControl.LiquorStore;
using System;

namespace LiquorStore.ViewModels
{
    public class SalesHistoryViewModel : BaseViewModel
    {
        public Guid ProductId { get; set; }
        public long Amount { get; set; }
        public double Price { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
