using FinancialControl.LiquorStore.Entities;
using LiquorStore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Column("EnderecoId")]
        public Guid AddressId { get; set; }

        [Column("CNPJId")]
        public Guid? CNPJId { get; set; } = null;

        [Column("CPFId")]
        public Guid? CPFId { get; set; } = null;

        [Column("Contato")]
        public string ContactNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Tipo")]
        public UserType UserType { get; set; }

        public virtual AddressEntity Address { get; set; }

        public virtual LegalPersonEntity LegalPerson { get; set; }

        public virtual PhysicalPersonEntity PhysicalPerson { get; set; }

        public virtual ICollection<ShoppingCartEntity> ShoppingCarts { get; set; }

    }
}
