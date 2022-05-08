using System.ComponentModel.DataAnnotations;

namespace Fabula.Models
{
    public class UserSettings
    {
        public int Id { get; set; } // pk
        public User User { get; set; }
        public string Nickname { get; set; }

        [StringLength(500)]
        public string CustomCss { get; set; }
    }
}
