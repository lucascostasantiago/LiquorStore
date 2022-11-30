using FinancialControl.LiquorStore;
using LiquorStore.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("Vendedor")]
    public class UserSellerViewModel : BaseViewModel
    {
        [Column("EnderecoId")]
        public Guid AddressId { get; set; }

        [Column("CNPJId")]
        public Guid CNPJId { get; set; }

        [Column("Contato")]
        public string ContactNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Tipo")]
        public UserType UserType { get; set; }

        public virtual AddressViewModel Address { get; set; }

        public virtual LegalPersonViewModel LegalPerson { get; set; }
    }
}
