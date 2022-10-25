using Logic.Domain;
using Logic.Interfaces;

namespace DAL.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogContext context) : base(context)
        {
        }
    }
}
