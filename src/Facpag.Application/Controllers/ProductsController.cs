using System;
using System.Net;
using System.Threading.Tasks;
using Facpag.Domain.Interfaces.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace Facpag.Application.Controllers
{
    //http:localhost:500/api/products
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IProductService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
