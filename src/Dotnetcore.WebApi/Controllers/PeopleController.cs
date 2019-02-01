using Microsoft.AspNetCore.Mvc;

namespace Dotnetcore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {

        [HttpGet]
        public IActionResult GetPeople()
        {
            return new OkObjectResult("Jim");
        }
    }
}