using System.Threading.Tasks;
using Facpag.Application.Models.Bill.Commands;
using Facpag.Domain.Interfaces.Services.Bill;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Facpag.Application.Controllers
{
    //http:localhost:500/api/bills
    [Route("api/[Controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BillsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateBill(CreateBillCommand command)
        {
            var result = await _mediator.Send(command);
            return result.IsSuccess ? Ok() : StatusCode(500);
        }

    }
}
