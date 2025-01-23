using BT_Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BT_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Index([FromQuery]AuthenticationRequestModel authenticationRequestModel)
        {
            return Ok(authenticationRequestModel);
        }
    }
}
    