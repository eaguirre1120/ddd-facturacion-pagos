using System;
using System.Threading;
using System.Threading.Tasks;
using Facpag.Domain.Entities;
using Facpag.Domain.Interfaces.Services.Bill;
using Facpag.Domain.Interfaces.Services.Detail;
using Facpag.Domain.ValueObject;
using MediatR;

namespace Facpag.Application.Models.Bill.Commands
{
    public class CreateBillCommandHandler : IRequestHandler<CreateBillCommand, CommandResult>
    {
        private IBillService _service;
        private IDetailService _serviceDetail;
        private readonly IMediator _mediator;

        public CreateBillCommandHandler(IBillService service, IDetailService serviceDetail, IMediator mediator)
        {
            _service = service;
            _serviceDetail = serviceDetail;
            _mediator = mediator;
        }

        public async Task<CommandResult> Handle(CreateBillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                BillEntity bill = new BillEntity(
                                        request.client,
                                        request.telephone,
                                        new Email(request.email),
                                        request.paymentType);

                var result = await _service.Post(bill);
                if (result != null)
                {
                    foreach (var item in request.detail)
                    {
                        DetailEntity detail = new DetailEntity(
                                                            result.Id,
                                                            item.productId,
                                                            new ProductName(item.productName),
                                                            item.quantity,
                                                            new Price(item.price)
                                                            );
                        await _serviceDetail.Post(detail);
                    }
                    await _mediator.Publish(new CreatedBillEvent
                    {
                        id = result.Id,
                        client = result.Client,
                        telephone = result.Telephone,
                        email = result.Email.Address,
                        paymentType = result.PaymentType
                    });
                    return CommandResult.Success(result);
                    // return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                }
                else
                {
                    return CommandResult.Fail("Hubo un error al registrar la Factura");
                }

            }
            catch (ArgumentException e)
            {

                return CommandResult.Fail(e.Message);
            }

        }
    }
}
