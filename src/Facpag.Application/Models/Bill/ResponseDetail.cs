using System;

namespace Facpag.Application.Models.Bill
{
    public class ResponseDetail
    {
        public Guid productId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
