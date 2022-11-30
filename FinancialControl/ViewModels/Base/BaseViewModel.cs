using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancialControl.LiquorStore
{
    public class BaseViewModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("DataDeCriacao")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Column("DataDeAtualizacao")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
