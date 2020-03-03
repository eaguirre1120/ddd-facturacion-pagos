using Facpag.Domain.Interfaces.Services.Bill;
using Microsoft.AspNetCore.Mvc;

namespace Facpag.Application.Controllers
{
    //http:localhost:500/api/bills
    [Route("api/[Controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private IBillService _service;

        public BillsController(IBillService service)
        {
            _service = service;
        }

    }
}
