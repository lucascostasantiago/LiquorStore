using FinancialControl.LiquorStore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("Produtos")]
    public class ProductsViewModel : BaseViewModel
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

        public virtual ICollection<SalesHistoryViewModel> SalesHistories { get; set; }
    }
}
