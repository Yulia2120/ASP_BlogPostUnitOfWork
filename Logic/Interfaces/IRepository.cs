using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IRepository<T> where T : class
    {
       Task <bool> CreateAsync(T item);

        Task <List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task UpdateAsync(T item);

        Task <bool> DeleteAsync(T item);
    }
}
