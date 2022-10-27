#pragma warning disable CS8603
using Logic.Domain;
using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : Identity
    {
        public BlogContext db;
        private readonly int id;

        public Repository(BlogContext context)
        {
            db = context;
        }
        public async Task<bool> CreateAsync(T item)
        {
            await db.Set<T>().AddAsync(item);
            await db.SaveChangesAsync();    
            return true;
          
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync(); 
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T item)
        {
             db.Set<T>().Update(item);
             await db.SaveChangesAsync();
             return item;
        }
        public async Task<bool> DeleteAsync(T item)
        {
            var result = await db.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id);
            if (item != null)
            {
            db.Set<T>().Remove(item);
            await db.SaveChangesAsync();
            }
            return true;

        } 


    }
}
