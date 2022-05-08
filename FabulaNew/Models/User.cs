using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Fabula.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; } // pk
        public int SettingsId { get; set; } // fk
        public UserSettings Settings { get; set; }
    }
}
