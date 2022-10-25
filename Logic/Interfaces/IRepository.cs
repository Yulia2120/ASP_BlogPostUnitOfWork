using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IRepository<T> where T : class
    {
       Task <T> CreateAsync(T item);

        IAsyncEnumerable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task UpdateAsync(T item);

        Task <T> DeleteAsync(T item);
    }
}
