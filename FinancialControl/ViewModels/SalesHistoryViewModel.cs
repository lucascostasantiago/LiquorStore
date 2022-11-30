using FinancialControl.LiquorStore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("HistoricoDeVendas")]
    public class SalesHistoryViewModel : BaseViewModel
    {
        [Column("CodigoProduto")]
        public Guid ProductId { get; set; }

        [Column("Quantidade")]
        public long Amount { get; set; }

        [Column("Preco")]
        public double Price { get; set; }

        public virtual ProductsViewModel Products { get; set; }
    }
}
