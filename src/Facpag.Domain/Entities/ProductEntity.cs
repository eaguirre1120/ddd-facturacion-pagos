using Facpag.Domain.ValueObject;

namespace Facpag.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public ProductName Name { get; set; }
        public Price Price { get; set; }
        public Stock Stock { get; set; }

    }
}
