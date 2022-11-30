using FinancialControl.LiquorStore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("CNPJ")]
    public class LegalPersonViewModel : BaseViewModel
    {
        [Column("CNPJ")]
        public string CNPJ { get; set; }

        [Column("Empresa")]
        public string CompanyName { get; set; }

        [Column("Representante")]
        public string Representative { get; set; }

        public virtual ICollection<UserSellerViewModel> UserSeller { get; set; }

    }
}
