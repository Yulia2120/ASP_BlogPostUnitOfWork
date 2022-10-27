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
            return await db.Posts.FirstOrDefaultAsync(t=> t.Title == title);
        }

        public async Task<Post> GetByIdAsync(int? id)
        {
            return await db.Posts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Post> UpdateAsyncPost(int? id)
        {
            var post = await db.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if (post != null)
            {
            post.Title = post.Title;
            post.Content = post.Content;
            post.PostedOn = post.PostedOn;
            }
            await db.SaveChangesAsync();
            return post;
         
        }

       
    }
}
