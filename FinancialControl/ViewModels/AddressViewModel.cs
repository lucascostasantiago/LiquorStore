using FinancialControl.LiquorStore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("Endereco")]
    public class AddressViewModel : BaseViewModel
    {
        [Column("Estado")]
        public string State { get; set; }


        [Column("Cidade")]
        public string City { get; set; }


        [Column("Bairro")]
        public string Neighborhood { get; set; }


        [Column("Rua")]
        public string Street { get; set; }

        public virtual ICollection<UserClientViewModel> UserClient { get; set; }
        public virtual ICollection<UserSellerViewModel> UserSeller { get; set; }
    }
}
