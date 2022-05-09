using System.ComponentModel.DataAnnotations;

namespace Fabula.Models
{
    public class UserSettings
    {
        public int Id { get; set; } // pk
        public User User { get; set; }
        public string Nickname { get; set; }

        // IMPORTANT: For the future, DO NOT use this property
        // without *first* validating this as actual CSS (which
        // could be a security vulnerability waiting to happen)
        // and verifying that it only modifies properties within
        // the box of the post.
        [StringLength(500)]
        public string CustomCss { get; set; }
    }
}
