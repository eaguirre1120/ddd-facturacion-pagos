using System;
using MediatR;

namespace Facpag.Application.Models.Bill.Queries
{
    public class GetAllBillByIdQuery : IRequest<ResponseBill>
    {
        public Guid Id { get; set; }
    }
}
