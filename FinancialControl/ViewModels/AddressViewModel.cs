using FinancialControl.LiquorStore;

namespace LiquorStore.ViewModels
{
    public class AddressViewModel : BaseViewModel
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
    }
}
