using Microsoft.AspNetCore.Mvc;

namespace OpenApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenApiController : ControllerBase
    {
        [HttpPut(Name = "BreakOpenApi")]
        public IActionResult Put(BreakOpenApiModel model)
        {
            return Ok();
        }
    }
}