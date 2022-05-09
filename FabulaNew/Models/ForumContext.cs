using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fabula.Models
{
    public class ForumContext : IdentityDbContext<User>
    {
        public ForumContext() { }

        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options) { }

        public DbSet<User> UserGroup { get; set; }
        public DbSet<UserSettings> Settings { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<ChildPost> PostChildren { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("appDb");
            builder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Post>()
                .HasKey(p => p.PostId);

            builder.Entity<ChildPost>()
                .HasKey(cp => cp.PostId);

            builder.Entity<ChildPost>()
                .HasOne(cp => cp.Parent)
                .WithMany(p => p.Child)
                .HasForeignKey(cp => cp.ParentPostId);

            builder.Entity<User>()
                .HasOne(u => u.Settings)
                .WithOne(s => s.User)
                .HasForeignKey<User>(u => u.SettingsId);
        }
    }
}
