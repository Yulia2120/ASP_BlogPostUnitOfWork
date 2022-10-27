using Logic.Domain;

namespace Logic.Interfaces
{
    public interface IPostRepository:IRepository<Post>
    {
        public  Task<Post> FindPostName(string title);
        public Task<Post> UpdateAsyncPost(int? id);
        Task<Post> GetByIdAsync(int? id);
    }
}
