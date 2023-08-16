
using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity //public yaptığımız için diğer classlar da buna erişim sağlayabiliyor.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}