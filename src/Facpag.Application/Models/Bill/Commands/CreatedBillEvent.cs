using System;
using MediatR;

namespace Facpag.Application.Models.Bill.Commands
{
    public class CreatedBillEvent : INotification
    {
        public Guid id { get; set; }
        public string client { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string paymentType { get; set; }
    }
}
