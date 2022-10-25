#pragma warning disable CS8603
using Logic.Domain;
using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context)
        {
        }

        public async Task<Post> FindPostName(string title)
        {
            return await db.Posts.OrderBy(x => x.Title).FirstOrDefaultAsync();
        }
    }
}
