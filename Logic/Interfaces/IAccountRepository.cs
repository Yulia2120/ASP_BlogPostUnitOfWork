using Logic.Domain;

namespace Logic.Interfaces
{
    public interface IAccountRepository:IRepository<Account>
    {
       
        public Account AuthenticateUser(string email, string password);
    }
}
