using FinancialControl.LiquorStore;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("CarrinhoCompras")]
    public class ShoppingCartViewModel : BaseViewModel
    {
        [Column("Cliente")]
        public string ClientId { get; set; }

        [Column("CodigoProduto")]
        public string ProductId { get; set; }

        [Column("Preco")]
        public double Price { get; set; }
    }
}
