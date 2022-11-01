using Logic.Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
         : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Account> Accounts { get; set; } = null!;

    }
}
