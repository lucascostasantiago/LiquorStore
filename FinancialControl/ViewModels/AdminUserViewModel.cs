using LiquorStore.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using FinancialControl.LiquorStore;

namespace LiquorStore.ViewModels
{
    [Table("UsuarioAdministrador")]
    public class AdminUserViewModel : BaseViewModel
    {

        [Column("CNPJ")]
        public string CNPJ { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Contato")]
        public string ContactNumber { get; set; }

        [Column("Nome")]
        public string Name { get; set; }

        [Column("Tipo")]
        public UserType UserType { get; set; }
    }
}
