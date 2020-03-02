using System;

namespace Facpag.Application.Models
{
    public class ResponseProduct
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
    }
}
