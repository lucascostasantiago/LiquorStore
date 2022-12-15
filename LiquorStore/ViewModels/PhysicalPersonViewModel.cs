using FinancialControl.LiquorStore;
using System;

namespace LiquorStore.ViewModels
{
    public class PhysicalPersonViewModel : BaseViewModel
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
