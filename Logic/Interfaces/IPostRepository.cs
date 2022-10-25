using Logic.Domain;

namespace Logic.Interfaces
{
    public interface IPostRepository:IRepository<Post>
    {
        public  Task<Post> FindPostName(string title);
        public Task<Post> UpdateAsyncPost(Post post);
    }
}
