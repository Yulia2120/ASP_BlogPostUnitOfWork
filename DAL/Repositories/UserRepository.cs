using Logic.Domain;
using Logic.Interfaces;

namespace DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BlogContext context) : base(context)
        {
        }
    }
}
