using System.ComponentModel.DataAnnotations;

namespace LiquorStore.Enums
{
    public enum UserType
    {
        [Display(Name = "ADMIN")]
        ADMIN = 0,
        [Display(Name = "CUSTOMER")]
        CUSTOMER = 1,
        [Display(Name = "SELLER")]
        SELLER = 2
    }
}
