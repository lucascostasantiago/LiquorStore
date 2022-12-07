using FinancialControl.LiquorStore.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("HistoricoDeVendas")]
    public class SalesHistoryEntity : BaseEntity
    {
        [Column("CodigoProduto")]
        public Guid ProductId { get; set; }

        [Column("Quantidade")]
        public long Amount { get; set; }

        [Column("Preco")]
        public double Price { get; set; }

        public virtual ProductsEntity Products { get; set; }
    }
}
