using FinancialControl.LiquorStore;
using LiquorStore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("Cliente")]
    public class UserClientViewModel : BaseViewModel
    {
        [Column("EnderecoId")]
        public Guid AddressId { get; set; }

        [Column("CPFId")]
        public Guid CPFId { get; set; }

        [Column("Contato")]
        public string ContactNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Tipo")]
        public UserType UserType { get; set; }

        public virtual PhysicalPersonViewModel PhysicalPerson { get; set; }

        public virtual AddressViewModel Address { get; set; }

        public virtual ICollection<ShoppingCartViewModel> ShoppingCarts { get; set; }
    }
}
