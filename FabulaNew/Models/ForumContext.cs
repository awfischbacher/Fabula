using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fabula.Models
{
    public class ForumContext : IdentityDbContext<User>
    {
        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
