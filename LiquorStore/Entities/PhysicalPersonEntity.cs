using FinancialControl.LiquorStore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("CPF")]
    public class PhysicalPersonEntity : BaseEntity
    {
        [Column("CPF")]
        public string CPF { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("DataDeNascimento")]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<UserEntity> User { get; set; }
    }
}
