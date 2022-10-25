using DAL.Repositories;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
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
        private UserRepository _userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_blogContext);

                return _userRepository;
            }
        }

       
    }
}
