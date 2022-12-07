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
    }
}
