using FinancialControl.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialControl.Models
{
    public class RevenueModel : BaseEntity
    {
        [Column("Title")]
        [Required(ErrorMessage = "Titulo deve ser informado!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nome deve ter entre 1 e 50 caracteres!")]
        public string Title { get; set; }

        [Column("Value")]
        [Required(ErrorMessage = "Valor deve ser informado!")]
        [Range(0.1, 1000000000000, ErrorMessage = "Valor deve ser entre 0.1 e 1000000000000 !")]
        public decimal Value { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("Date")]
        [Required(ErrorMessage = "Data deve ser informada!")]
        public DateTime Date { get; set; }

        [Column("Type")]
        [Required(ErrorMessage = "Tipo da Receita deve ser informada!")]
        public RevenueType RevenueType { get; set; }
    }
}
