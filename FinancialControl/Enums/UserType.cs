using System.ComponentModel.DataAnnotations;

namespace LiquorStore.Enums
{
    public enum UserType
    {
        [Display(Name = "ADMIN")]
        ADMIN = 0,
        [Display(Name = "CONSUMER")]
        CONSUMER = 1
    }
}
