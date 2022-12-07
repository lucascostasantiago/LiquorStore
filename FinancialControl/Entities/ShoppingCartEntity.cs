using FinancialControl.LiquorStore.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("CarrinhoDeCompras")]
    public class ShoppingCartEntity : BaseEntity
    {
        [Column("Cliente")]
        public Guid? ClientId { get; set; } = null;

        [Column("CodigoProduto")]
        public Guid ProductId { get; set; }

        [Column("Quantia")]
        public double Amount { get; set; }

        public virtual ProductsEntity Products { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
