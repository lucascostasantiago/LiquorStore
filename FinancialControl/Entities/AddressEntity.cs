using FinancialControl.LiquorStore.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("Endereco")]
    public class AddressEntity : BaseEntity
    {
        [Column("Estado")]
        public string State { get; set; }


        [Column("Cidade")]
        public string City { get; set; }


        [Column("Bairro")]
        public string Neighborhood { get; set; }


        [Column("Rua")]
        public string Street { get; set; }

        public virtual ICollection<UserEntity> UserSeller { get; set; }
    }
}
