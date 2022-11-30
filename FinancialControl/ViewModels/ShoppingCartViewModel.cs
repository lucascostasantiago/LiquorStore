using FinancialControl.LiquorStore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("CarrinhoDeCompras")]
    public class ShoppingCartViewModel : BaseViewModel
    {
        [Column("Cliente")]
        public Guid ClientId { get; set; }

        [Column("CodigoProduto")]
        public Guid ProductId { get; set; }

        [Column("Quantia")]
        public double Amount { get; set; }

        public virtual ProductsViewModel Products { get; set; }
        public virtual UserClientViewModel UserClient { get; set; }
    }
}
