using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> CreateAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
