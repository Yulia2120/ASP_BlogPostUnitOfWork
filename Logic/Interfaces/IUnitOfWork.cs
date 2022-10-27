namespace Logic.Interfaces
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
        IPostRepository PostRepository { get; }
        IAccountRepository AccountRepository { get; }

     
    }
}
