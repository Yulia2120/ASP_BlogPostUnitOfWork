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
        public async Task<Post> UpdateAsyncPost(Post post)
        {
            var postFromDb = await db.Posts.FindAsync(new object[] { post.PostId });
            if (postFromDb != null)
            {
            postFromDb.Title = post.Title;
            postFromDb.Content = post.Content;
            postFromDb.PostedOn = post.PostedOn;
            }
            await db.SaveChangesAsync();
            return post;
         
        }
    }
}
