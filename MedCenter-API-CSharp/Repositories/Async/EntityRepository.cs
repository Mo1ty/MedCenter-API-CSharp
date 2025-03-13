using MedCenter_API_CSharp.Data;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Repositories.Async
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context;


        public EntityRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<T?> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity; //Может быть null, потом разберемся
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();

            return entities;
        }


        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

    }
}
