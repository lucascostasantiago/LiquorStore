using LiquorStore.ViewModels;
using System;

namespace LiquorStore.Utils
{
    public class Validate
    {
        public void ValidateUpdate(ProductsViewModel vm)
        {
            if (vm.Id == Guid.Parse("00000000-0000-0000-0000-000000000000")) throw new Exception("Não foi possível atualizar este produto.");
            if (vm.ProductName == null) throw new Exception("Não foi possível atualizar este produto.");
            if (vm.ProductCode == null) throw new Exception("Não foi possível atualizar este produto.");
            if (vm.Price == 0) throw new Exception("Não foi possível atualizar este produto.");
            if (vm.Type == null) throw new Exception("Não foi possível atualizar este produto.");
            if (vm.CreationDate == DateTime.Parse("01/01/0001 00:00:00")) throw new Exception("Não foi possível atualizar este produto.");
        }
    }
}
