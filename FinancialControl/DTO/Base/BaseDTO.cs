using System;

namespace LiquorStore.DTO.Base
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
