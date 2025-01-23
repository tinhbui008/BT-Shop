using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BT_User.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly OidcSettings _oidcSettings;

        public UsersController(IOptions<OidcSettings> oidcSettings)
        {
            _oidcSettings = oidcSettings.Value;
        }

        [Authorize()]
        [HttpGet("[action]")]
        public IActionResult GetOidcSettings()
        {
            return Ok(_oidcSettings);
        }
    }
}
