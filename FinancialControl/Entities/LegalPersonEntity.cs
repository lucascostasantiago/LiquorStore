using FinancialControl.LiquorStore.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("CNPJ")]
    public class LegalPersonEntity : BaseEntity
    {
        [Column("CNPJ")]
        public string CNPJ { get; set; }

        [Column("Empresa")]
        public string CompanyName { get; set; }

        [Column("Representante")]
        public string Representative { get; set; }

        public virtual ICollection<UserEntity> User { get; set; }
    }
}
