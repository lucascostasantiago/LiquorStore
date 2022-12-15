using FinancialControl.LiquorStore;

namespace LiquorStore.ViewModels
{
    public class LegalPersonViewModel : BaseViewModel
    {
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string Representative { get; set; }
    }
}
