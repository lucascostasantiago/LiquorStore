using System.ComponentModel.DataAnnotations;

namespace LiquorStore.Enums
{
    public enum ProductType
    {
        [Display(Name = "WHISKY")]
        WHISKY = 0,
        [Display(Name = "CERVEJA")]
        CERVEJA = 1,
        [Display(Name = "REFRIGERANTE")]
        REFRIGERANTE = 2,
        [Display(Name = "AGUA")]
        AGUA = 3
    }
}
