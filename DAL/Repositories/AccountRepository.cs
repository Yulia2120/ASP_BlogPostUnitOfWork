using Logic.Domain;
using Logic.Interfaces;
#pragma warning disable CS8603
namespace DAL.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(BlogContext context) : base(context)
        { }

        public Account AuthenticateUser(string email, string password)
        {
            return db.Accounts.SingleOrDefault(u => u.Email == email && u.Password == password);

        }


    }
}
