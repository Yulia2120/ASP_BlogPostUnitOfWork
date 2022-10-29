using Logic.Domain;

namespace Logic.Interfaces
{
    public interface IRepository<T> where T : Identity
    {
       Task <T> CreateAsync(T item);

        Task <List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> UpdateAsync(T item);

        Task <bool> DeleteAsync(T item);
    }
}
