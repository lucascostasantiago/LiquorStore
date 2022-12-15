using System;
namespace FinancialControl.LiquorStore
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
