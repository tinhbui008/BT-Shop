using Microsoft.AspNetCore.Identity;

namespace BT_Identity.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string DeviceType { get; set; }
    }
}
