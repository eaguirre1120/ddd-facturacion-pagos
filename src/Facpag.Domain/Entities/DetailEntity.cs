using System;
using Facpag.Domain.ValueObject;

namespace Facpag.Domain.Entities
{
    public class DetailEntity : BaseEntity
    {
        public Guid BillId { get; set; }
        public Guid ProductId { get; internal set; }
        public ProductName ProductName { get; internal set; }
        public int Quantity { get; internal set; }
        public Price Price { get; internal set; }
        protected DetailEntity()
        {

        }
        public DetailEntity(Guid billId, Guid productId, ProductName productName, int quantity, Price price)
        {
            BillId = billId;
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public void SetBillId(Guid billId)
        {
            BillId = billId;
        }
        public void SetProductId(Guid productId)
        {
            ProductId = productId;
        }
        public void SetProductName(ProductName productName)
        {
            ProductName = productName;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void SetPrice(Price price)
        {
            Price = price;
        }
    }
}
