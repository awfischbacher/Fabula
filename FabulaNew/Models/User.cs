using Microsoft.AspNetCore.Identity;

namespace Fabula.Models
{
    public class User : IdentityUser
    {
        public UserSettings Settings { get; set; }
    }
}
