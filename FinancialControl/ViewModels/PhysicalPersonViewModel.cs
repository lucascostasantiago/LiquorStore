using FinancialControl.LiquorStore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("PessoaFisica")]
    public class PhysicalPersonViewModel : BaseViewModel
    {
        [Column("CPF")]
        public string CPF { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        public virtual ICollection<UserClientViewModel> Users { get; set; }
    }
}
