using DAL.Repositories;
using Logic.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private BlogContext _blogContext;
        public UnitOfWork(BlogContext context)

        {  _blogContext = context; }

        private BlogRepository _blogRepository;
        public IBlogRepository BlogRepository 
            {
            get
            {
                if (_blogRepository == null)
                    _blogRepository = new BlogRepository(_blogContext);

                return _blogRepository;
            }

            }

        private PostRepository _postRepository;
        public IPostRepository PostRepository
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_blogContext);

                return _postRepository;
            }

        }
        private AccountRepository _accountRepository;
        public IAccountRepository AccountRepository
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new AccountRepository(_blogContext);

                return _accountRepository;
            }
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
