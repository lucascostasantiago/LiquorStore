using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancialControl.LiquorStore.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("DataDeCriacao")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Column("DataDeAtualizacao")]
        public DateTime UpdateDate { get; set; }
    }
}
