using FinancialControl.LiquorStore;
using LiquorStore.Enums;
using System;

namespace LiquorStore.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public Guid AddressId { get; set; }
        public Guid? CNPJId { get; set; } = null;
        public Guid? CPFId { get; set; } = null;
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string Representative { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
    }
}
