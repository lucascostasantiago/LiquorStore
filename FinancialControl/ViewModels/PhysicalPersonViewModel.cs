﻿using FinancialControl.LiquorStore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorStore.ViewModels
{
    [Table("CPF")]
    public class PhysicalPersonViewModel : BaseViewModel
    {
        [Column("CPF")]
        public string CPF { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("DataDeNascimento")]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<UserClientViewModel> UserClient { get; set; }
    }
}
