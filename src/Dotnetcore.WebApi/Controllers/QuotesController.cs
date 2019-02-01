using System.Threading.Tasks;
using Dotnetcore.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetcore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        private readonly IMediator _mediator;

        public QuotesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetRandom()
        {
            var quote = await _mediator.Send(new RandomQuoteQuery());
            
            return new OkObjectResult(quote);
        }
    }
}