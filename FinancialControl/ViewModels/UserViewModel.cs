using FinancialControl.LiquorStore;
using LiquorStore.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("Usuarios")]
    public class UserViewModel : BaseViewModel
    {
        [Column("Tipo")]
        public UserType UserType { get; set; }


        [Column("Name")]
        public string Name { get; set; }


        [Column("Contato")]
        public string ContactNumber { get; set; }


        [Column("Email")]
        public string Email { get; set; }


        [Column("CPF")]
        public string CPF { get; set; }


        [Column("Estado")]
        public string State { get; set; }


        [Column("Cidade")]
        public string City { get; set; }


        [Column("Bairro")]
        public string Neighborhood { get; set; }


        [Column("Rua")]
        public string Street { get; set; }
    }
}
