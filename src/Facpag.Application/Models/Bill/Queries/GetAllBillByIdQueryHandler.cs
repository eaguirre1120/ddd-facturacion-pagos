using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Facpag.Data.Context;
using Facpag.Domain.Entities;
using Facpag.Domain.Interfaces.Services.Bill;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Facpag.Application.Models.Bill.Queries
{
    public class GetAllBillByIdQueryHandler : IRequestHandler<GetAllBillByIdQuery, ResponseBill>
    {
        private IBillService _service;
        private MyContext _context { get; set; }

        public GetAllBillByIdQueryHandler(IBillService service, MyContext context)
        {
            _service = service;
            _context = context;
        }
        public async Task<ResponseBill> Handle(GetAllBillByIdQuery request, CancellationToken cancellationToken)
        {

            BillEntity bill = await _service.Get(request.Id);
            ResponseBill response = new ResponseBill();

            // DbSet<DetailEntity> dataset = _context.Set<DetailEntity>();
            // var detail = await dataset.SingleOrDefaultAsync(b => b.BillId.Equals(bill.Id));
            List<ResponseDetail> details = new List<ResponseDetail>();
            // details.Add(new ResponseDetail
            // {
            //     productId = detail.ProductId,
            //     productName = detail.ProductName.Value,
            //     quantity = detail.Quantity,
            //     price = detail.Price.Amount
            // }
            // );
            details.Add(new ResponseDetail
            {
                productId = Guid.Parse("2165f599-6cf3-48d4-b060-2f86a13b3726"),
                productName = "Tablet Samsung",
                quantity = 2,
                price = 245
            }
            );

            response.id = bill.Id;
            response.client = bill.Client;
            response.telephone = bill.Telephone;
            response.email = bill.Email.Address;
            response.paymentType = bill.PaymentType;
            response.detail = details;

            return response;

        }
    }
}
