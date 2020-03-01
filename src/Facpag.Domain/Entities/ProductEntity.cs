using Facpag.Domain.ValueObject;

namespace Facpag.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public ProductName Name { get; internal set; }
        public Price Price { get; internal set; }
        public Stock Stock { get; internal set; }

        protected ProductEntity()
        {
        }

        public ProductEntity(ProductName name, Price price, Stock stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }



    }
}
