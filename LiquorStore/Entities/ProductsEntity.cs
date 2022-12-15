using FinancialControl.LiquorStore.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.Entities
{
    [Table("Produtos")]
    public class ProductsEntity : BaseEntity
    {
        [Column("NomeProduto")]
        public string ProductName { get; set; }

        [Column("CodigoProduto")]
        public string ProductCode { get; set; }

        [Column("Preco")]
        public double Price { get; set; }

        [Column("Quantidade")]
        public long Amount { get; set; }

        [Column("Tipo")]
        public string Type { get; set; }

        public virtual ICollection<SalesHistoryEntity> SalesHistories { get; set; }
        public virtual ICollection<ShoppingCartEntity> ShoppingCarts { get; set; }
    }
}
