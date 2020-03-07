using System;
using System.Collections.Generic;

namespace Facpag.Application.Models.Bill
{
    public class ResponseBill
    {
        public Guid id { get; set; }
        public string client { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string paymentType { get; set; }
        public List<ResponseDetail> detail { get; set; }
    }
}
